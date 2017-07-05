using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;

namespace WebApiTest.Api.Controllers.ActionResults
{
    public static class HttpResponseHelper
    {
        public static HttpResponseMessage OkObject(HttpRequestMessage request, object data)
        {
            return request.CreateResponse(System.Net.HttpStatusCode.OK, data, "application/json");
        }
    }
}