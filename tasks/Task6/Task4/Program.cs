using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading;

namespace Task4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();

            var producer = new Subject<IWeather>();

            producer.Subscribe(x => Console.WriteLine($"Latest temparature in {x.Country}/{x.City}: {x.GetTemperature(Unit.Celsius):0.00}°C"));

            while (true)
            {
                Observable.Start(() =>
                {
                    var europe = new IWeather[]
                    {
                    new Forecast("Ukraine", "Kyiv", "Sunny", rnd.Next(15, 22) - rnd.NextDouble(), Unit.Celsius),
                    new Forecast("Austria", "Vienna", "Cloudy", rnd.Next(10, 20) - rnd.NextDouble(), Unit.Celsius)
                    };
                    foreach (var w in europe)
                    {
                        producer.OnNext(w);
                    }
                    Thread.Sleep(rnd.Next(4000, 8000));
                });

                Observable.Start(() =>
                {
                    var asia = new IWeather[]
                    {
                    new Forecast("Japan", "Tokyo", "Showers", rnd.Next(8, 14) - rnd.NextDouble(), Unit.Celsius),
                    new Forecast("China", "Beijing", "Sunny", rnd.Next(12, 18) - rnd.NextDouble(), Unit.Celsius)
                    };
                    foreach (var w in asia)
                    {
                        producer.OnNext(w);
                    }
                    Thread.Sleep(rnd.Next(4000, 8000));
                });

                Observable.Start(() =>
                {
                    var americas = new IWeather[]
                    {
                    new Forecast("USA", "Washington DC", "Cloudy", rnd.Next(50, 70) - rnd.NextDouble(), Unit.Fahrenheit),
                    new Forecast("Brazil", "Brasília", "Rainy", rnd.Next(8, 18) - rnd.NextDouble(), Unit.Celsius)
                    };
                    foreach (var w in americas)
                    {
                        producer.OnNext(w);
                    }
                    Thread.Sleep(rnd.Next(4000, 8000));
                });
            }
        }
    }
}
