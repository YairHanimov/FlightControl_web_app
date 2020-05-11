using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightControlWeb.Controllers.models
{
    public class flightmanager : iflightmanager
    {
        private static List<Flight> flights = new List<Flight>()
        {
            new Flight  { flight_id =3, longitude =33, latitude =32, passengers =2,
              company_name="bla bla",date_time=DateTime.Now,is_external=true},
             new Flight  { flight_id =80, longitude =33, latitude =32, passengers =2,
              company_name="bla bla",date_time=DateTime.Now,is_external=true}
        };
        
       
        
    public void addflight(Flight f)
        {
            flights.Add(f);
        }

        public void deleteflight(int  id)
        {
            Flight f = flights.Where(f => f.flight_id == id).FirstOrDefault();
           
            flights.Remove(f);
        }

        public IEnumerable<Flight> GetallFlights()
        {
            return flights;
        }

        public Flight getflyightbyid(int id)
        {
            Flight f = flights.Where(f => f.flight_id == id).FirstOrDefault();
            return f;
        }

        public void updateflight(Flight n)
        {
            Flight fl = flights.Where(f => f.flight_id == n.flight_id).FirstOrDefault();
            fl.flight_id = n.flight_id;
            fl.longitude = n.longitude;
            fl.latitude = n.latitude;
            fl.is_external = n.is_external;
            fl.passengers = n.passengers;
            fl.date_time = n.date_time;
            fl.company_name = n.company_name;
        }
    }
}
