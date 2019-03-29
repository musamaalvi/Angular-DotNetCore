using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DotNetCore.Controllers
{

    [Route("api/[Controller]")]
    public class testController : Controller
    {
        [HttpGet]
        public IActionResult Get(){
            return Ok(new string [] {"a","b","c" });
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id) => Ok($"Returning the called id: {id}");


        [HttpPost, Route("testingFunction/testing")]
        public IActionResult testing([FromBody] dataClass value){


            return CreatedAtAction("Get",value);
        }

        
    }

    public class dataClass {
        public int id ;
        public string value;
    }
}