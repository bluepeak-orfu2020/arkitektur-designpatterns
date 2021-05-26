using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternGuess
{
    interface IVehicle
    {
        int Wheels { get; set; }
         string Brand { get; set; }
         string Color { get; set; }
        string Type { get; set; }
    }
}
