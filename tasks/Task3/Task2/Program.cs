using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        public static void Main(string[] args)
        {
            var items = new IWeather[]
            {
                new Forecast("Austria", "Vienna", "Cloudy", 60.8, Unit.Fahrenheit),
                new Forecast("Ukraine", "Kyiv", "Sunny", 13.2, Unit.Celsius),
                new Forecast("Croatia", "Split", "Sunny", 20.1, Unit.Celsius),
                new History("Czech Republic", "Prague", DateTime.Now, "Sunny", 10.5, Unit.Celsius),
                new History("Greece", "Athens", DateTime.Now, "Sunny", 18.6, Unit.Celsius),
            };
            foreach (var w in items)
            {
                Console.WriteLine("{0}\n{1:0.00}°\n", w.Clouds, w.GetTemperature(Unit.Celsius));
            }
        }
    }
}
