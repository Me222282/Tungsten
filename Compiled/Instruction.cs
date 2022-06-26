using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiled
{
    public class Instruction
    {
        private Instruction(InstType type, IInstInfo info)
        {
            Type = type;
            Info = info;
        }

        public InstType Type { get; }
        public IInstInfo Info { get; }

        public static Instruction Call(Function function, ArgInfo[] arguments, ArgInfo @return)
        {
            return new Instruction(InstType.FunctionCall, new FuncInfo(function, arguments, @return));
        }
        public static Instruction MemAlloc(int size)
        {
            return new Instruction(InstType.Alloc, new AllocInfo(false, size));
        }
        public static Instruction StackAlloc(int size)
        {
            return new Instruction(InstType.Alloc, new AllocInfo(true, size));
        }
    }
}
