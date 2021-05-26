using System;
using System.Collections.Generic;
using WeatherTempProvider;

namespace Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            SHMITempProvider provider = new SHMITempProvider();
            WeatherProvider provider2 = new WeatherProvider();

            TempWriter writer = new TempWriter();
            var data = new List<TempInC>();
            data.AddRange(provider.GetWeatherData());
            data.AddRange(provider2.GetWeatherData());
            writer.PresentData(data);

            Console.ReadLine();
        }
    }
}
