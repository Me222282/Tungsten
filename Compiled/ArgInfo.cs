using System;

namespace Compiled
{
    public struct ArgInfo
    {
        public ArgInfo(ArgType type, object @ref)
        {
            Type = type;
            Reference = @ref;
        }

        public ArgType Type { get; }
        public object Reference { get; }

        public static ArgInfo Var(object value)
        {
            ArgType type = value switch
            {
                byte => ArgType.Byte,
                sbyte => ArgType.Sbyte,
                short => ArgType.Short,
                ushort => ArgType.Ushort,
                int => ArgType.Int,
                uint => ArgType.Uint,
                long => ArgType.Long,
                ulong => ArgType.Ulong,

                float => ArgType.Float,
                double => ArgType.Double,
                decimal => ArgType.Double,
                bool => ArgType.Bool,
                
                char => ArgType.Char,
                string => ArgType.String,

                Delegate => ArgType.Method,

                IntPtr => ArgType.Pointer,
                UIntPtr => ArgType.Pointer,
                ValueType => ArgType.Memory,
                _ => ArgType.MemPtr
            };

            return new ArgInfo(type, value);
        }
    }
}
