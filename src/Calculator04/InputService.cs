using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator06
{
    public class InputService
    {
        public string ReadCommand() {
            Console.Write("Operation: ");
            string command = Console.ReadLine();
            return command;
        }

        public int[] ReadArguments() {

            Console.Write("Value 1: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Value 2: ");
            int y = int.Parse(Console.ReadLine());

            return new int[] { x, y };
        }
    }
}
