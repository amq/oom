using NUnit.Framework;
using System;
using Task4;

namespace Tests
{
    [TestFixture]
    public class HistoryTest
    {
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
        [Test]
        public void CanUpdateHistoryTemperature()
        {
            var x = new History("Czech Republic", "Prague", DateTime.Now, "Sunny", 10.5, Unit.Celsius);

            x.UpdateTemperature(5, Unit.Celsius);

            Assert.IsTrue(x.Country == "Czech Republic");
            Assert.IsTrue(x.City == "Prague");
            Assert.IsTrue(x.Clouds == "Sunny");
            Assert.IsTrue(x.Temperature.Number == 5);
            Assert.IsTrue(x.Temperature.Unit == Unit.Celsius);
        }
    }
}

