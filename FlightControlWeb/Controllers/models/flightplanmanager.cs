using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace FlightControlWeb.Controllers.models
{
    public class flightplanmanager
    {
        segments asegment = new segments();

        public void addsegmnet(segments s)
        {
            asegment.latitude = 22;
            asegment.longitude = 24;
            asegment.timespan_seconds = 100;
        }
        private static List<segments> listasegments = new List<segments>() {
        new segments {latitude=22,longitude=24,timespan_seconds=100},
        new segments {latitude=52,longitude=54,timespan_seconds=50}
        };
        private static List<InitialLocation> InitialLocation = new List<InitialLocation>() {
        new InitialLocation {latitude=22,longitude=24,date_time=DateTime.Now},
        new InitialLocation {latitude=52,longitude=54,date_time=DateTime.Now}
        };
        public static List<Flightplan> flights = new List<Flightplan>()

        {
            new Flightplan  {   initial_location=InitialLocation.First(), passenger =2,
              company_name="bla bla",segments=listasegments, FlightPlanId="aaac12"},
         
        };

      
        public void addflight(Flightplan f)
        {
            flights.Add(f);
            
        }

        public void deleteflight(string id)
        {
            Flightplan p = flights.Where(x => x.FlightPlanId == id).FirstOrDefault();
            if (p == null)
            {
                throw new Exception("id not found ");
            }
            else
            {
                flights.Remove(p);
            }

        }

        public IEnumerable<Flightplan> GetallFlights()
        {
            return flights;
        }

       public Flightplan getbyid(String id)
        {
            Flightplan p = flights.Where(x => x.FlightPlanId == id).FirstOrDefault();
            if (p == null)
            {
                throw new Exception("id not found ");
            }
            else
            {
                return p;
            }
        }

        public void updateflight(Flight n)
        {
           
        }
    }
}

