﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightControlWeb.Controllers.models
{
    interface iflightmanager
    {
        IEnumerable<Flight> GetallFlights();
        Flight getflyightbyid(string id);
        void addflight(Flight f);
        void updateflight(Flight f);
        void deleteflight(string id);
            
    }
}
