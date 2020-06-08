using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightControlWeb.Controllers.models
{
    public class Flightplan
    
         {
        public int passenger { get; set; }
        public string company_name { get; set; }
       
        public  InitialLocation initial_location { get; set; }

        public List<segments> segments { get; set; }
        public string FlightPlanId { get; set; }

        public DateTime endtime { get; set; }


    }

}
