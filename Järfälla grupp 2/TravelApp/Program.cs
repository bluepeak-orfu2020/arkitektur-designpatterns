using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Enter number 1: ");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter number 2: ");
                int y = int.Parse(Console.ReadLine());
                int userChoise = -1;

            while (userChoise !=0)
            {
                Console.WriteLine("Choose the action: 1 - add, 2 - multiply, 3 - substract, 4 - devide, 0 - to exit.");
                try
                {
                    userChoise = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    userChoise = 5;
                }

                IStrategy strategy = null;
                if (userChoise == 1)
                {
                    strategy = new AdditionStrategy();
                }
                else if (userChoise == 2)
                {
                    strategy = new MultiplicationStrategy();
                }
                else if (userChoise == 3)
                {
                    strategy = new SubtractionStrategy();
                }
                else if (userChoise == 4)
                {
                    strategy = new DivisionStrategy();
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

            Console.WriteLine("Program exit");
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
