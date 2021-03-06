using System;

namespace Basgrupp2JärfällaDel1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter number 1: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number 2: ");
            int y = int.Parse(Console.ReadLine());

            int userChoice = -1;

            while (userChoice != 0)
            {

                Console.WriteLine("Choose the action: 1 - add, 2 - multiply, 3 - substract, 4 - divide, 0 - to exit.");
                try
                {
                    userChoice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    userChoice = 5;
                }

                IStrategy strategy = null;
                if (userChoice == 1)
                {
                    strategy = new AdditionStrategy();
                }
                else if (userChoice == 2)
                {
                    strategy = new MultiplicationStrategy();
                }
                else if (userChoice == 3)
                {
                    strategy = new SubtractionStrategy();
                }
                else if (userChoice == 4)
                {
                    strategy = new DivisionStrategy();
                }
                else if (userChoice == 0)
                {
                    Console.WriteLine("Exiting!");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong input, try again!");
                }

                if (strategy != null)
                {
                    Console.WriteLine(strategy.Compute(x, y));
                }
            }

            Console.ReadKey();

        }

        interface IStrategy
        {
            int Compute(int num1, int num2);
        }

        public class AdditionStrategy : IStrategy
        {
            public int Compute(int num1, int num2)
            {
                return num1 + num2;
            }
        }

        public class SubtractionStrategy : IStrategy
        {
            public int Compute(int num1, int num2)
            {
                return num1 - num2;
            }
        }

        public class MultiplicationStrategy : IStrategy
        {
            public int Compute(int num1, int num2)
            {
                return num1 * num2;
            }
        }

        public class DivisionStrategy : IStrategy
        {
            public int Compute(int num1, int num2)
            {
                return num1 / num2;
            }
        }
    }
}
