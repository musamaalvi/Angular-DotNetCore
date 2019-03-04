using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DotNetCore.Controllers
{


    [Route("api/[Controller]")]
    public class testController : Controller
    {
        [HttpGet("/api/values")]
        public IEnumerable<string> Get(){
            return new string [] {"a","b","c" };
        }
    }
}