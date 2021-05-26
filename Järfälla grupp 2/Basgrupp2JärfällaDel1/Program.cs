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


                if (userChoice == 1)
                {
                    Console.WriteLine(Add(x, y));
                }
                else if (userChoice == 2)
                {
                    Console.WriteLine(Multiplicate(x, y));
                }
                else if (userChoice == 3)
                {
                    Console.WriteLine(Substract(x, y));
                }
                else if (userChoice == 4)
                {
                    Console.WriteLine(Divide(x, y));
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
            }

            Console.ReadKey();

        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Multiplicate(int x, int y)
        {
            return x * y;
        }

        static int Divide(int x, int y)
        {
            return x / y;
        }
        static int Substract(int x, int y)
        {
            return x - y;
        }
    }
}
