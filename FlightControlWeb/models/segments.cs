using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightControlWeb.Controllers.models
{
    public class segments
    {
        public double longitude { get; set; }
        public double latitude { get; set; }
        public double timespan_seconds { get; set; }

        public void setall(double lo, double la, double t)
        {
            this.longitude = lo;
            this.latitude = la;
            this.timespan_seconds = t;
        }

    }
}
