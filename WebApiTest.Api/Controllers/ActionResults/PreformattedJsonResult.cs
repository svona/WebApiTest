using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApiTest.Api.Controllers.ActionResults
{
    public class PreformattedJsonResult : ContentResult
    {
        public PreformattedJsonResult(string json)
        {
            this.Content = json;
            this.ContentType = "application/json";
            this.ContentEncoding = System.Text.Encoding.UTF8;
        }
    }
}