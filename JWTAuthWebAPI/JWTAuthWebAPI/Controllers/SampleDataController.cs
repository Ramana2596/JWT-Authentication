using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JWTAuthWebAPI.Controllers
{
    public class SampleDataController : ApiController
    {
        [Authorize]
        [HttpGet]
        public List<string> GetSampleData() {
            List<string> newSampleData = new List<string>();
            newSampleData.Add("Test");
            return newSampleData;
        }
    }
}
