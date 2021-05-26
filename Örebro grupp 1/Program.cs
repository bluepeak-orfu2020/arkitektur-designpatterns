using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            Prod client = new Prod();
            Console.WriteLine("Skriv in fordonstyp[ENTER] sen önskat märke[ENTER]");
            var Märke = client.Production(Console.ReadLine(), Console.ReadLine());
            Console.WriteLine($"we created a {Märke.Type} with {Märke.Wheels} Wheels, color {Märke.Color} and of make {Märke.Brand}");
            Console.ReadLine();
        }
    }
}
