using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Threading.Tasks;
using FlightControlWeb.Controllers.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace FlightControlWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightsController : ControllerBase
    {
        

        
        [HttpGet]
        public void GetFlights([FromQuery(Name = "relative_to")]string relativeTime)
        {

           // DateTime mytime = DateTime.Parse(relativeTime);
            foreach (var mydata in flightplanmanager.flights)
            {
                DateTime damytime = mydata.initial_location.date_time;
                DateTime d1 = mydata.initial_location.date_time;

                int size = mydata.segments.Count;
                for (int i=0; i< size; i++)
                {
                    damytime= damytime.AddSeconds(mydata.segments[i].timespan_seconds);
                   
                }
                mydata.endtime = damytime;
               DateTime  d2 = damytime;
                DateTime targetDt = DateTime.Parse(relativeTime);
                if (targetDt.Ticks >= d1.Ticks && targetDt.Ticks <= d2.Ticks)
                {
                   // addtolist 
                }

            }


        }

        // POST: api/Flights
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Flights/5
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
