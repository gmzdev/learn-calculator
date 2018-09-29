using System;

namespace Calculator06
{
    /*
     * Basic Calculator Program
     * 1. Change array of commands to enums. 
     *      - replace index based selection to enhance selection   
     *      - interchange of elements affects the existing index selection
     *      - create and enumeration of command types
     *      - create CommandInputParser class
     * 2. Refactor Calculation Operations
     *      - eliminate repitive calculation codes  
     *      - create a Calculator class
     */

    class Program
    {
        static void Main(string[] args)
        {
            CommandInputParser commandInputParser = new CommandInputParser();
            Calculator calculator = new Calculator();

            while (true)
            {
                Console.Write("Operation: ");
                string command = Console.ReadLine();

                try
                {
                    CommandTypes commandType = commandInputParser.ParseCommand(command);                    

                    Console.Write("Value 1: ");
                    int x = int.Parse(Console.ReadLine());

                    Console.Write("Value 2: ");
                    int y = int.Parse(Console.ReadLine());

                    int result = calculator.Calculate(commandType, x, y);                   

                    Console.WriteLine("Result: " + result);
                }
                catch (Exception)
                {
                    Console.WriteLine("Mistake!");
                }
            }
        }
    }
}