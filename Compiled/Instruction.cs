using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiled
{
    public class Instruction
    {
        private Instruction(InstType type, ArgInfo[] args)
        {
            Type = type;
            Arguments = args;
        }

        public InstType Type { get; }
        public ArgInfo[] Arguments { get; }
    }
}
