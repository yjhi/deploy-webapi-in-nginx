using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace APITemplate.Controller
{
    public class TestController : ApiController
    {
        // Test Get1
        // api/Test/TestGet
        [HttpGet]
        public IHttpActionResult TestGet()
        {
            return Ok(new {Data="",Code=0,Message="OK" });
        }

        // Test Get2
        // api/Test/TestGet
        [HttpGet]
        public IHttpActionResult TestGet(string param1)
        {
            return Ok(new { Data = param1, Code = 0, Message = "OK" });
        }


        // Test Get3
        // api/Test/TestGet
        [HttpGet]
        public IHttpActionResult TestGet(string param1,string param2)
        {
            return Ok(new { Data = "param1="+ param1+ ",param2="+param2, Code = 1, Message = "OK" });
        }


        // Test Post
        [HttpGet]
        public IHttpActionResult TestPost()
        {
            return Ok(new { Data = "", Code = 1, Message = "OK" });
        }
        // Test Post1
        [HttpPost]
        public IHttpActionResult TestPost([FromBody]string param1)
        {
            return Ok(new { Data = param1, Code = 1, Message = "OK" });
        }

   

    }
}
