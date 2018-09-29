using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator06
{
    public class Calculator
    {
        public int Calculate(CommandTypes commandType, Arguments arguments)
        {
            switch (commandType)
            {
                case CommandTypes.Add:
                    return this.Add(arguments);
                case CommandTypes.Sub:
                    return this.Sub(arguments);
                case CommandTypes.Mul:
                    return this.Mul(arguments);
                case CommandTypes.Div:
                    return this.Div(arguments);
                default:
                    throw new InvalidOperationException();
            }
        }

        public int Add(Arguments arguments)
        {
            return arguments.X + arguments.Y;
        }

        public int Sub(Arguments arguments)
        {
            return arguments.X - arguments.Y;
        }

        public int Mul(Arguments arguments)
        {
            return arguments.X * arguments.Y;
        }

        public int Div(Arguments arguments)
        {
            return arguments.X / arguments.Y;
        }
    }
}
