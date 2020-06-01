using FlightControlWeb.Controllers;
using FlightControlWeb.Controllers.models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace XUnitTestflight
{
    public class UnitTest1
    {
        private readonly FlightPlanController fpc;

        public void flightconrloertest()
        {
            var mock = new Mock<ICalculator>();

            mock.Setup(x => x.Add(2, 2)).Returns(4);
            mock.Setup(x => x.Subtract(5, 2)).Returns(3);

            this._calculator = mock.Object;
        }

        [Fact]
        public void Calculator_Should_Add()
        {
            var result = _calculator.Add(2, 2);

            Assert.Equal(4, result);
        }

        [Fact]
        public void Calculator_Should_Subtract()
        {
            var result = _calculator.Subtract(5, 2);

            Assert.Equal(3, result);
        }
    
}
}
