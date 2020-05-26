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
    public class servercontolerController : ControllerBase
    {
       public static iservermanager managaerserver;
        // GET: api/servercontoler
        [HttpGet]
        public IEnumerable<server> Get()
        {
          return  managaerserver.getallservers(); 
        }

        // GET: api/servercontoler/5
        [HttpGet("{id}", Name = "Get")]
        public server Get(string id)
        {
          return  managaerserver.getbyid(id);
        }

        // POST: api/servercontoler
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/servercontoler/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            managaerserver.deleteserver(id);
        }
    }
}
