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
            var commands = new Dictionary<string, MathCommmand> {
                { "+", new AdditionCommand() },
                { "-", new SubtractionCommand() },
                { "/", new DivisionCommand() }
            };
            Console.WriteLine("Vill du addera(+), subtrahera(-) eller dividera(/)?");
            string opt = Console.ReadLine();

            if (commands.ContainsKey(opt))
            {
                MathCommmand command = commands[opt];
                command.Execute();
            }
            else
            {
                Console.WriteLine("Ogiltigt val");
            }

            Console.ReadLine();
        }

        interface MathCommmand
        {
            void Execute();
        }

        abstract class TwoNumberMathCommand : MathCommmand
        {
            public void Execute()
            {
                Console.WriteLine("Skriv två tal");
                var tal1 = Convert.ToInt32(Console.ReadLine());
                var tal2 = Convert.ToInt32(Console.ReadLine());
                var result = Compute(tal1, tal2);
                Console.WriteLine($"Resultatet av adderingen blev: {result}");
            }

            protected abstract int Compute(int tal1, int tal2);
        }

        class AdditionCommand : TwoNumberMathCommand
        {

            protected override int Compute(int tal1, int tal2)
            {
                return tal1 + tal2;
            }
        }
        
        class SubtractionCommand : TwoNumberMathCommand
        {

            protected override int Compute(int tal1, int tal2)
            {
                return tal1 - tal2;
            }
        }

        class DivisionCommand : TwoNumberMathCommand
        {

            protected override int Compute(int tal1, int tal2)
            {
                return tal1 / tal2;
            }
        }
    }
}
