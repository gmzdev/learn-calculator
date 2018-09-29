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
     * 3. Refactor Input Operations
     *      - organize Input related operations
     *      - create Input Service class
     * 4. Improvement
     *      - replace index based selection to enhance selection 
     *      - create Argument model class
     *      - refactor Output Operation
     *      - create Output Service class
     */

    class Program
    {
        static void Main(string[] args)
        {
            CommandInputParser commandInputParser = new CommandInputParser();
            Calculator calculator = new Calculator();
            InputService inputService = new InputService();
            OutputService outputService = new OutputService();

            while (true)
            {
                string command = inputService.ReadCommand();

                try
                {
                    CommandTypes commandType = commandInputParser.ParseCommand(command);                    

                    Arguments arguments = inputService.ReadArguments();

                    int result = calculator.Calculate(commandType, arguments);

                    outputService.WriteResult(result.ToString());
                }
                catch (Exception)
                {
                    Console.WriteLine("Mistake!");
                }
            }
        }
    }
}