using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator06
{
    public class CalculatorReplLoop
    {
        CommandInputParser commandInputParser;
        Calculator calculator;
        InputService inputService;
        OutputService outputService;

        public CalculatorReplLoop()
        {
            commandInputParser = new CommandInputParser();
            calculator = new Calculator();
            inputService = new InputService();
            outputService = new OutputService();
        }

        public void Run()
        {
           
            while (true)
            {
                string command = inputService.ReadCommand();

                try
                {
                    CommandTypes commandType = commandInputParser.ParseCommand(command);

                    Arguments arguments = inputService.ReadArguments();

                    outputService.WriteResult(calculator.Calculate(commandType, arguments).ToString());
                }
                catch (Exception)
                {
                    Console.WriteLine("Mistake!");
                }
            }
        }
    }
}
