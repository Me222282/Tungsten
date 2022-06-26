using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiled
{
    public class FuncInfo : IInstInfo
    {
        public FuncInfo(Function func, ArgInfo[] args, ArgInfo @return)
        {
            Function = func;
            Arguments = args;
            ReturnValue = @return;
        }

        public Function Function { get; }
        public ArgInfo[] Arguments { get; }
        public ArgInfo ReturnValue { get; }
    }
}
