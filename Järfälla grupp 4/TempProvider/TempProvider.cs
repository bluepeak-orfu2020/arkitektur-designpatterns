using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempProvider
{
    public class TempProvider
    {
        public TempInF GetData()
        {
            return new TempInF(61f);
        }
    }

    public class TempInF
    {
        public float Temp { get; set; }
        public TempInF(float temp)
        {
            Temp = temp;
        }
    }

}
