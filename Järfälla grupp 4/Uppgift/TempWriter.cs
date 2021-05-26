using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift
{
    class TempWriter
    {
        public void PresentData(List<TempInC> tempList)
        {
            foreach (TempInC city in tempList)
            {
                Console.WriteLine($"The temperature in {city.City} is : {city.Temp} in C");
            }

        }
    }
}
