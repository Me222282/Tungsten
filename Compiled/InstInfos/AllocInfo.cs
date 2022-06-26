using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiled
{
    public class AllocInfo : IInstInfo
    {
        public AllocInfo(bool stack, int size)
        {
            Stack = stack;
            SIze = size;
        }

        public bool Stack { get; }
        public int SIze { get; }
    }
}
