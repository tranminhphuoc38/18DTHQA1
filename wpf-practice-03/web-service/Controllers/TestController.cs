using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace web_service.Controllers
{
    public class TestController : ApiController
    {
        public string Hello() {
            return "Hello";
        }
    }
}
