using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherTempProvider;

namespace Uppgift
{
    class WeatherProviderAdapter : ITempProvider
    {
        WeatherProvider provider;
        public WeatherProviderAdapter(WeatherProvider provider)
        {
            this.provider = provider;
        }

        public List<TempInC> GetWeatherData()
        {
            var result = new List<TempInC>();

            foreach (var weatherItem in provider.GetWeatherData())
            {
                result.Add(new TempInC(ConvertFtoC(weatherItem.Temp), weatherItem.City));
            }

            return result;
        }

        private float ConvertFtoC(float f)
        {
            return (f - 32) * 5/9;
        }
    }
}
