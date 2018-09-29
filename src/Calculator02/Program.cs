using System;

namespace Calculator02
{
    /*
     * Basic Calculator Program
     * 1. Change array of commands to enums. 
     *      - replace index based selection to enhance selection   
     *      - interchange of elements affects the existing index selection
     *      - create and enumeration of command types
     *      - create CommandInputParser class
     */    

    class Program
    {       

        static void Main(string[] args)
        {
            CommandInputParser commandInputParser = new CommandInputParser();

            while (true)
            {
                Console.Write("Operation: ");
                string command = Console.ReadLine();

                try
                {
                    CommandTypes commandType = commandInputParser.ParseCommand(command);
                    int result = 0;
                    int x = 0;
                    int y = 0;

                    switch (commandType)
                    {
                        case CommandTypes.Add:
                            Console.Write("Value 1:");
                            x = int.Parse(Console.ReadLine());

                            Console.Write("Value 2:");
                            y = int.Parse(Console.ReadLine());

                            result = Add(x, y);

                            break;
                        case CommandTypes.Sub:
                            Console.Write("Value 1:");
                            x = int.Parse(Console.ReadLine());

                            Console.Write("Value 2:");
                            y = int.Parse(Console.ReadLine());

                            result = Sub(x, y);
                            break;
                        case CommandTypes.Mul:
                            Console.Write("Value 1:");
                            x = int.Parse(Console.ReadLine());

                            Console.Write("Value 2:");
                            y = int.Parse(Console.ReadLine());

                            result = Mul(x, y);
                            break;
                        case CommandTypes.Div:
                            Console.Write("Value 1:");
                            x = int.Parse(Console.ReadLine());

                            Console.Write("Value 2:");
                            y = int.Parse(Console.ReadLine());

                            result = Div(x, y);
                            break;
                        default:
                            break;
                    }

                    Console.WriteLine("Result: " + result);
                }
                catch (Exception)
                {
                    Console.WriteLine("Mistake!");
                }
            }
        }

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