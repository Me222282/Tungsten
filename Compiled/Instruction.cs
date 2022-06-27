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

        public static Instruction Call(Function func, ReadOnlySpan<ArgInfo> args)
        {
            ArgInfo[] arguments = new ArgInfo[args.Length + 1];
            args.CopyTo(new Span<ArgInfo>(arguments, 1, args.Length));

            arguments[0] = new ArgInfo(ArgType.Method, func);

            return new Instruction(InstType.FunctionCall, arguments);
        }
    }
}
