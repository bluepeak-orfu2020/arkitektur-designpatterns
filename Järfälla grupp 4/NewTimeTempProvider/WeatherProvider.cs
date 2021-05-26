using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherTempProvider
{
    public class WeatherProvider
    {
        public List<IWeatherTemp> GetWeatherData()
        {
            List<IWeatherTemp> Weather = new List<IWeatherTemp>()
            {
                new TempInF(61f, "New York"),
                new TempInF(72f, "Chicago"),
                new TempInF(81f, "Los Angeles"),
                new TempInF(84f, "Stockholm"),
                new TempInF(60f, "London")
        };
            return Weather;
        }
    }
}
