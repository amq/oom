using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        public static void Main(string[] args)
        {
            var weather_forecast = new[]
            {
                new Weather("Austria", "Vienna", "Cloudy", 60.8, Unit.Fahrenheit),
                new Weather("Ukraine", "Kyiv", "Sunny", 13.2, Unit.Celsius),
                new Weather("Croatia", "Split", "Sunny", 20.1, Unit.Celsius),
            };
            foreach (var w in weather_forecast)
            {
                Console.WriteLine("{0}/{1}\n{2}\n{3:0.00}°\n", w.Country, w.City, w.Clouds, w.GetTemperature(Unit.Celsius));
            }
        }
    }
}
