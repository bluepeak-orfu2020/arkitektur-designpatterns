using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift
{
    interface ITempProvider
    {
        List<TempInC> GetWeatherData();
    }
}
