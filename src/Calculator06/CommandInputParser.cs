﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator06
{
    public class CommandInputParser
    {
        public CommandTypes ParseCommand(string command)
        {
            return (CommandTypes)Enum.Parse(typeof(CommandTypes), command);
        }
    }
}
