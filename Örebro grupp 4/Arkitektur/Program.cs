using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkitektur
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vill du addera(+), subtrahera(-) eller dividera(/)?");
            string opt = Console.ReadLine();
            if (opt == "+") {
                Console.WriteLine("Skriv två tal");
                var tal1 = Convert.ToInt32(Console.ReadLine());
                var tal2 = Convert.ToInt32(Console.ReadLine());
                var sum = tal1 + tal2;
                Console.WriteLine($"Resultatet av adderingen blev: {sum}");
            } else if (opt == "-") {
                Console.WriteLine("Skriv två tal");
                var tal1 = Convert.ToInt32(Console.ReadLine());
                var tal2 = Convert.ToInt32(Console.ReadLine());
                var sum = tal1 - tal2;
                Console.WriteLine($"Resultatet av subtraheringen blev: {sum}");
            } else if (opt == "/") {
                Console.WriteLine("Skriv två tal");
                var tal1 = Convert.ToInt32(Console.ReadLine());
                var tal2 = Convert.ToInt32(Console.ReadLine());
                var sum = tal1 / tal2;
                Console.WriteLine($"Resultatet av divideringen blev: {sum}");
            } else {
                Console.WriteLine("Ogiltigt val");
            }
            Console.ReadLine();
        }
    }
}
