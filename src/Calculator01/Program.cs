using System;

namespace Calculator02
{
    /*
     * Basic Calculator Program
     */
    class Program
    {
        // command types options
        static string[] commands = { "Add", "Sub", "Mul", "Div" };

        // main function for our program
        static void Main(string[] args)
        {
            while (true)
            {
                // ask for command selection
                Console.Write("Operation: ");
                string command = Console.ReadLine(); 

                int index = Array.IndexOf(commands, command);
                int result = 0;

                if (index != -1)
                {
                    // ask for First Argument
                    Console.Write("Value 1:");
                    int x = int.Parse(Console.ReadLine());

                    // ask for Second Argument
                    Console.Write("Value 2:");
                    int y = int.Parse(Console.ReadLine());

                    // evaluate valid commands
                    switch (index)
                    {
                        case 0:
                            result = Add(x, y);
                            break;
                        case 1:
                            result = Sub(x, y);
                            break;
                        case 2:
                            result = Mul(x, y);
                            break;
                        case 3:
                            result = Div(x, y);
                            break;
                        default:
                            break;
                    }

                    // return output
                    Console.WriteLine("Result: " + result);
                }
                else
                {
                    System.Console.WriteLine("Mistake!");
                }
            }
        }

        /*
         * Calculation Methods
         */ 

        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Sub(int x, int y)
        {
            return x - y;
        }

        static int Mul(int x, int y)
        {
            return x * y;
        }

        static int Div(int x, int y)
        {
            return x / y;
        }
    }
}