using FlightControlWeb.Controllers;
using FlightControlWeb.Controllers.models;
using Microsoft.VisualBasic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Mock<flightplanmanager> mockmanager;
        Mock<iservermanager> servermanage;
        FlightPlanController flightplancontrol = new FlightPlanController();
        FlightsController flightcontrol = new FlightsController();
        serversController servertest = new serversController();

        [TestMethod]

        public void cheakthepostofflight()
        {

            instalationplan();
            Flightplan plan = new Flightplan();
            
            string timetotest = DateTime.Now.AddSeconds(11380+200).ToString();
            plan = flightplancontrol.Getflight().First();
            string get_compamy_name;
            get_compamy_name = plan.company_name;
           
                
            Assert.AreEqual(get_compamy_name, "test");
            
           
        }
        [TestMethod]

        public void cheak_id_sharefromservers()
        {

            instalationplan();

            Flightplan plan = new Flightplan();

            string timetotest = DateTime.Now.AddSeconds(11380 + 200).ToString();
            plan = flightplancontrol.Getflight().First();
            string id = plan.FlightPlanId;
            Flightplan planfrom_id=   flightplancontrol.GetAsync(id).Result;


            Assert.AreEqual(planfrom_id.FlightPlanId, flightplancontrol.Getflight().First().FlightPlanId);


        }


          void instalationplan()
        {
           

        var flight = new FlightsController();
        Flightplan k = new Flightplan();

        segments newseg = new segments();
        newseg.setall(22, 22, 2000);
            k.company_name = "test";
            k.initial_location = new InitialLocation();
        DateTime tt = new DateTime();
        tt = DateTime.Now;
            k.initial_location.setalll(22, 22, tt);
            k.segments = new System.Collections.Generic.List<segments>();
            k.segments.Add(newseg);
            // flightplanmanager.flights.Add(k);
            flightplancontrol.Post(k);

        }

        [TestMethod]

        public void testserverbyid()
        {
            var servercontroler = new serversController();
            server myserver = new server();
            myserver.ServerId = "test_id";
            myserver.ServerURL = "www.server_test.com";
            servercontroler.Post(myserver);

            server myresoult = servercontroler.Get("test_id");

           Assert.AreEqual( "www.server_test.com", myresoult.ServerURL);


        }
    }


}
