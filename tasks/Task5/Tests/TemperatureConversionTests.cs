using NUnit.Framework;
using Task4;

namespace Tests
{
    [TestFixture]
    public class TemperatureConversionTest
    {
        [Test]
        public void TemperatureConversionPositiveFahrenheit()
        {
            var x = TemperatureConversion.Get(10, Unit.Fahrenheit);
            Assert.IsTrue(x == 50);
        }
        [Test]
        public void TemperatureConversionNegativeFahrenheit()
        {
            var x = TemperatureConversion.Get(-10, Unit.Fahrenheit);
            Assert.IsTrue(x == 14);
        }
        [Test]
        public void TemperatureConversionPositiveCelsius()
        {
            var x = TemperatureConversion.Get(10, Unit.Celsius);
            Assert.IsTrue(x < -12.222 && x > -12.223);
        }
        [Test]
        public void TemperatureConversionNegativeCelsius()
        {
            var x = TemperatureConversion.Get(-10, Unit.Celsius);
            Assert.IsTrue(x < -23.333 && x > -23.334);
        }
    }
}

