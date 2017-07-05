using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using WebApiTest.Data;

namespace WebApiTest.Service.GetCustomer
{
    public class GetCustomerHandler : IAsyncRequestHandler<GetCustomerQuery, GetCustomerResult>
    {
        private NorthwindContext context;
        private IMapper mapper;

        public GetCustomerHandler()
        {
            var config = new MapperConfiguration(b =>
            {
                b.CreateMap<Models.Customer, Service.Customer>();
            });
            this.context = new NorthwindContext();
            this.mapper = new AutoMapper.Mapper(config);
        }

        public async Task<GetCustomerResult> Handle(GetCustomerQuery message)
        {
            var model = new GetCustomerResult();

            try
            {
                var validator = new GetCustomerQueryValidator();
                var v = validator.Validate(message);

                model.Success = v.IsValid;
                if (v.IsValid)
                {
                    var temp = await this.context.Customers
                        .Where(b => b.CustomerID == message.CustomerID)
                        .ToArrayAsync();

                    model.Result = temp
                        .Select(b => mapper.Map<Models.Customer, Service.Customer>(b))
                        .ToArray();

                }
                else
                {
                    model.ErrorMessage = String.Join(Environment.NewLine, v.Errors.Select(b => b.ErrorMessage));
                }
            }
            catch (Exception ex)
            {
                model.Success = false;
                model.ErrorMessage = ex.Message;
            }

            return model;
        }
    }
}
