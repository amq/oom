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
        public void CanCreateHistory()
        {
            var x = new History("Czech Republic", "Prague", DateTime.Now, "Sunny", 10.5, Unit.Celsius);

            Assert.IsTrue(x.Country == "Czech Republic");
            Assert.IsTrue(x.City == "Prague");
            Assert.IsTrue(x.Clouds == "Sunny");
            Assert.IsTrue(x.Temperature.Number == 10.5);
            Assert.IsTrue(x.Temperature.Unit == Unit.Celsius);
        }
    }
}

