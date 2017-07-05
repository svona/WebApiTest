using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiTest.Api.Controllers.ActionResults
{
    public class BetterJsonResult : PreformattedJsonResult
    {
        public BetterJsonResult(object data) 
            : base(JsonConvert.SerializeObject(data))
        {

        }
    }
}