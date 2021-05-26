using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift
{
    public class TempInC
    {
        public float Temp { get; set; }
        public string City { get; set; }

        public TempInC(float temp, string city)
        {
            Temp = temp;
            City = city;
        }
    }
}
