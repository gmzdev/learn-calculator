using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator06
{
    public class Calculator
    {
        public int Calculate(CommandTypes commandType, int x, int y)
        {
            switch (commandType)
            {
                case CommandTypes.Add:
                    return this.Add(x, y);
                case CommandTypes.Sub:
                    return this.Sub(x, y);
                case CommandTypes.Mul:
                    return this.Mul(x, y);
                case CommandTypes.Div:
                    return this.Div(x, y);
                default:
                    throw new InvalidOperationException();
            }
        }

        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Sub(int x, int y)
        {
            return x - y;
        }

        public int Mul(int x, int y)
        {
            return x * y;
        }

        public int Div(int x, int y)
        {
            return x / y;
        }
    }
}
