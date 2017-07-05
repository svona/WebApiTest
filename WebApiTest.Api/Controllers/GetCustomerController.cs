using Microsoft.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Net.Http;
using System.Web.Http.Results;
using WebApiTest.Api.Controllers.ActionResults;
using WebApiTest.Service;
using WebApiTest.Service.GetCustomer;

namespace WebApiTest.Api.Controllers
{
    // [ApiVersion("1.0")]
    public class GetCustomerController : ApiController
    {
        private IWebApiService webApiService;

        public GetCustomerController(IWebApiService webApiService)
        {
            this.webApiService = webApiService;
        }
        
        [HttpGet]
        [Route("api/GetCustomer/{customerId}")]
        public async Task<HttpResponseMessage> GetCustomer(string customerId)
        {
            var result = await this.webApiService.Mediator.Send(new GetCustomerQuery { CustomerID = customerId });
            return HttpResponseHelper.OkObject(Request, result);
        }
    }
}