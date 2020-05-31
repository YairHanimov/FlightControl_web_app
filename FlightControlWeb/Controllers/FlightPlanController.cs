using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlightControlWeb.Controllers.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FlightControlWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightPlanController : ControllerBase
    {

        Random rand = new Random();

        public const string Alphabet =
        "abcdefghijklmnopqrstuvwyxzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        public static flightplanmanager flymanager = new flightplanmanager();
        private flightmanager fmanage = new flightmanager();
        // GET: api/Flight
        [HttpGet]
        public IEnumerable<Flightplan> Getflight()
        {
           return flymanager.GetallFlights();
        }

        // GET: api/Flight/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<Flightplan> GetAsync(string id)
        {
            if (flymanager.getbyid(id)==null)
            {
                foreach (var serverdata in iservermanager.allserverslist)
                {
                    Flightplan flightPlan = new Flightplan();
                    string param = "/api/FlightPlan/";
                    flightPlan = await askserver(serverdata, param + id);
                    if (flightPlan.company_name != null)
                    {
                        return flightPlan;


                    }
                }
                return null; 
            }
            else
          return  flymanager.getbyid(id);
        }

        // POST: api/Flight
        [HttpPost]
        public Flightplan Post(Flightplan f)
        {
            string dammyf = GenerateString(10);
            f.FlightPlanId = dammyf;

            flymanager.addflight(f);
            
            

            return f;

        }


        // PUT: api/Flight/5
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
        public async Task<Flightplan> askserver(server servers, string s)
        {

            Httpclientclass httpRequestClass = new Httpclientclass();
            var result = await httpRequestClass.makeRequest(servers.ServerURL + s);

            Flightplan fl = new Flightplan();
            fl = JsonConvert.DeserializeObject<Flightplan>(result);
            return fl;
        }
    }
}
