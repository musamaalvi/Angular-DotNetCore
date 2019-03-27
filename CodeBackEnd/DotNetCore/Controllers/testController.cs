using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DotNetCore.Controllers
{

    [Route("api/[Controller]")]
    public class testController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get(){
            return new string [] {"a","b","c" };
        }

        [HttpGet("{id}")]
        public string Get(int id) => $"Returning the called id: {id}" ;
    }
}