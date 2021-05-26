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

            MathCommmand command = null;
            if (opt == "+") {
                Console.WriteLine("Skriv två tal");
                var tal1 = Convert.ToInt32(Console.ReadLine());
                var tal2 = Convert.ToInt32(Console.ReadLine());
                command = new AdditionCommand(tal1, tal2);
            } else if (opt == "-") {
                Console.WriteLine("Skriv två tal");
                var tal1 = Convert.ToInt32(Console.ReadLine());
                var tal2 = Convert.ToInt32(Console.ReadLine());
                command = new SubtractionCommand(tal1, tal2);
            } else if (opt == "/") {
                Console.WriteLine("Skriv två tal");
                var tal1 = Convert.ToInt32(Console.ReadLine());
                var tal2 = Convert.ToInt32(Console.ReadLine());
                command = new DivisionCommand(tal1, tal2);
            } else {
                Console.WriteLine("Ogiltigt val");
            }

            if (command != null)
            {
                command.Execute();
            }

            Console.ReadLine();
        }

        interface MathCommmand
        {
            void Execute();
        }

        class AdditionCommand : MathCommmand
        {
            int x;
            int y;

            public AdditionCommand(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public void Execute()
            {
                var sum = x + y;
                Console.WriteLine($"Resultatet av adderingen blev: {sum}");
            }
        }
        
        class SubtractionCommand : MathCommmand
        {
            int x;
            int y;

            public SubtractionCommand(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public void Execute()
            {
                var sum = x - y;
                Console.WriteLine($"Resultatet av subtraktion blev: {sum}");
            }
        }
        
        class DivisionCommand : MathCommmand
        {
            int x;
            int y;

            public DivisionCommand(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public void Execute()
            {
                var sum = x / y;
                Console.WriteLine($"Resultatet av divideringen blev: {sum}");
            }
        }
    }
}
