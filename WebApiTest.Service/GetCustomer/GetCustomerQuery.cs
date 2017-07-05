using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiTest.Service.GetCustomer
{
    public class GetCustomerQuery : IRequest<GetCustomerResult>
    {
        public string CustomerID { get; set; }
    }
}
