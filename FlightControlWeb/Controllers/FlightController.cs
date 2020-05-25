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
        public IEnumerable<Flight> GetFlights([FromQuery(Name = "relative_to")]string relativeTime)
        {
                 List<Flight> listtosend = new List<Flight>();

           // DateTime mytime = DateTime.Parse(relativeTime);
            foreach (var mydata in flightplanmanager.flights)
            {
                DateTime damytime = mydata.initial_location.date_time;
                DateTime d1 = mydata.initial_location.date_time;

                int size = mydata.segments.Count;
                DateTime firstcompare = mydata.initial_location.date_time;
                InitialLocation firstloack = mydata.initial_location;
                for (int i=0; i< size; i++)
                {
                    damytime= damytime.AddSeconds(mydata.segments[i].timespan_seconds);
                    DateTime d2 = damytime;
                    //DateTime targetDt = DateTime.Parse(relativeTime);
                     DateTime targetDt = DateTime.Parse(relativeTime);
                    if (targetDt.Ticks > firstcompare.Ticks && targetDt.Ticks < d2.Ticks)
                    {
                        Flight dammy = new Flight();
                        dammy.flight_id = mydata.FlightPlanId;
                        dammy.company_name = mydata.company_name;
                        dammy.passengers = mydata.passenger;
                        TimeSpan timespan = targetDt - firstcompare;
                        TimeSpan allwaysegment = d2 - firstcompare;
                        double transitiontime = timespan.TotalSeconds;
                        double allway = allwaysegment.TotalSeconds;
                        double calulate = transitiontime / allway;
                        double newlat =firstloack.latitude+( (mydata.segments[i].latitude - firstloack.latitude) * calulate);
                        double newlong = firstloack.longitude + ((mydata.segments[i].longitude - firstloack.longitude) * calulate);
                        dammy.longitude = newlong;
                        dammy.latitude = newlat;
                        listtosend.Add(dammy);
                    }

                    mydata.endtime = damytime;
                    firstcompare = damytime;

                    // addtolist 
                    firstloack.latitude = mydata.segments[i].latitude;
                    firstloack.latitude = mydata.segments[i].longitude;

                }

            }
            return listtosend;

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
