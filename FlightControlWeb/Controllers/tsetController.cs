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

        private flightplanmanager flymanager = new flightplanmanager();
        // GET: api/tset
        [HttpGet]
        public IEnumerable<Flightplan> Getflight()
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
        public Flightplan Post(Flightplan f)
        {

            flymanager.addflight(f);
            return f;
            
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
