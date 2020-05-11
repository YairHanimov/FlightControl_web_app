using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlightControlWeb.Controllers.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightControlWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class tsetController : ControllerBase
    {
        private iflightmanager flymanager = new flightmanager();
        // GET: api/tset
        [HttpGet]
        public IEnumerable<Flight> Getflight()
        {
           return flymanager.GetallFlights();
        }

        // GET: api/tset/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/tset
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/tset/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
