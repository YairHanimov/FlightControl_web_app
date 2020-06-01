using FlightControlWeb.Controllers;
using FlightControlWeb.Controllers.models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private Mock<flightplanmanager> fpm { get; set; }
        public Task<IEnumerable<Flight>> KK { get; private set; }
        public Task<IEnumerable<Flight>> after { get; private set; }

        private readonly FlightsController  myflightconrol;

        [TestMethod]

        
        public void TestMethod1()
        {
           
            after = myflightconrol.GetFlightsAsync(k.date_time.ToString());
            Console.WriteLine(after);
            Assert.Equals(4, 4);
        }

        public void  testflight()
        {
            Mock<FlightsController> servertest = new Mock<FlightsController>();

            List<Flight> kk = new List<Flight>();
            kk.Add(k);
            servertest.Setup(x => x.GetFlightsAsync("2020 - 05 - 31T18: 10:21")).Returns(KK);
        }
        Flight k = new Flight { company_name = "test", flight_id = "123", latitude = 3, 
            longitude = 2, is_external = false };
        server a = new server { ServerId = "123", ServerURL = "url of 123 test" };
        server b = new server { ServerId = "456", ServerURL = "url of 456 test" };

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
              company_name="mtest company",segments=listasegments, FlightPlanId="aaac12"},

        };
    }
    
}
