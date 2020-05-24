using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightControlWeb.Controllers.models
{
    public class InitialLocation
    {
        public long longitude { get; set; }

        public double latitude { get; set; }

        public DateTime date_time { get; set; }
    }
}
