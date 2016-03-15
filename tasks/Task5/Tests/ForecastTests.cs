using NUnit.Framework;
using System;
using Task4;

namespace Tests
{
    [TestFixture]
    public class ForecastTest
    {
        [Test]
        public void CanCreateForecast()
        {
            var x = new Forecast("Austria", "Vienna", "Cloudy", 60.8, Unit.Fahrenheit);

            Assert.IsTrue(x.Country == "Austria");
            Assert.IsTrue(x.City == "Vienna");
            Assert.IsTrue(x.Clouds == "Cloudy");
            Assert.IsTrue(x.Temperature.Number == 60.8);
            Assert.IsTrue(x.Temperature.Unit == Unit.Fahrenheit);
        }
        [Test]
        public void CanUpdateForecastTemperature()
        {
            var x = new Forecast("Austria", "Vienna", "Cloudy", 60.8, Unit.Fahrenheit);

            x.UpdateTemperature(23, Unit.Celsius);

            Assert.IsTrue(x.Country == "Austria");
            Assert.IsTrue(x.City == "Vienna");
            Assert.IsTrue(x.Clouds == "Cloudy");
            Assert.IsTrue(x.Temperature.Number == 23);
            Assert.IsTrue(x.Temperature.Unit == Unit.Celsius);
        }
    }
}

