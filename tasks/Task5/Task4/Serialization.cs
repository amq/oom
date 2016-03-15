using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Task4
{
    class Serialization
    {
        public static void Run(IWeather[] items)
        {
            var forecast = items[0];

            // 1. serialize a single forecast to a JSON string
            Console.WriteLine(JsonConvert.SerializeObject(forecast));

            // 2. ... with nicer formatting
            Console.WriteLine(JsonConvert.SerializeObject(forecast, Formatting.Indented));

            // 3. serialize all items
            // ... include type, so we can deserialize sub-classes to interface type
            var settings = new JsonSerializerSettings() { Formatting = Formatting.Indented, TypeNameHandling = TypeNameHandling.Auto };
            Console.WriteLine(JsonConvert.SerializeObject(items, settings));

            // 4. store json string to file "items.json" on your Desktop
            var text = JsonConvert.SerializeObject(items, settings);
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var filename = Path.Combine(desktop, "items.json");
            File.WriteAllText(filename, text);

            // 5. deserialize items from "items.json"
            // ... and print Clouds of deserialized items
            var textFromFile = File.ReadAllText(filename);
            var itemsFromFile = JsonConvert.DeserializeObject<IWeather[]>(textFromFile, settings);
            foreach (var x in itemsFromFile) Console.WriteLine($"{x.Clouds}");
        }
    }
}