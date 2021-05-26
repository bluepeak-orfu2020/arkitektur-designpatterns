using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift
{
    public class SHMITempProvider
    {
        public List<TempInC> GetWeatherData()
        {
            List<TempInC> Weather = new List<TempInC>()
            {
                new TempInC(23f, "New York"),
                new TempInC(26f, "Chicago"),
                new TempInC(35f, "Los Angeles"),
                new TempInC(13f, "Stockholm"),
                new TempInC(16f, "London")
        };
            return Weather;
        }
    }
}
