﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightControlWeb.Controllers.models
{
    public class InitialLocation
    {
        public double longitude { get; set; }

        public double latitude { get; set; }

        public DateTime date_time { get; set; }
        public void setalll(double lo, double la, DateTime t)
        {
            this.longitude = lo;
            this.latitude = la;
            this.date_time = t;
        }
    }
   
}
