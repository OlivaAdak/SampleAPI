using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetValuesController : ControllerBase
    {
        // GET: api/<GetValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Sunny_Day", "Rainy_Day" };
        }

        // GET api/<GetValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "Day";
        }

        // POST api/<GetValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<GetValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GetValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
