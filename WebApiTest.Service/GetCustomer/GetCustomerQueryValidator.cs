using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiTest.Service.GetCustomer
{
    class GetCustomerQueryValidator : AbstractValidator<GetCustomerQuery>
    {
        public GetCustomerQueryValidator()
        {
            this.RuleFor(b => b.CustomerID).NotEmpty();
            this.RuleFor(b => b.CustomerID).Length(5);
        }
    }
}
