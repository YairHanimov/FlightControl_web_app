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

        Random rand = new Random();

        public const string Alphabet =
        "abcdefghijklmnopqrstuvwyxzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        public static flightplanmanager flymanager = new flightplanmanager();
        private flightmanager fmanage = new flightmanager();
        // GET: api/tset
        [HttpGet]
        public IEnumerable<Flightplan> Getflight()
        {
           return flymanager.GetallFlights();
        }

        // GET: api/tset/5
        [HttpGet("{id}", Name = "Get")]
        public Flightplan Get(string id)
        {
          return  flymanager.getbyid(id);
        }

        // POST: api/tset
        [HttpPost]
        public Flightplan Post(Flightplan f)
        {
            string dammyf = GenerateString(10);
            f.FlightPlanId = dammyf;

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
        public void Delete(string id)
        {
            flymanager.deleteflight(id);
        }
        public string GenerateString(int size)
        {
            char[] chars = new char[size];
            for (int i = 0; i < size; i++)
            {
                chars[i] = Alphabet[rand.Next(Alphabet.Length)];
            }
            return new string(chars);
        }
    }
}
