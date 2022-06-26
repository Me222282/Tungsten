using System;

namespace Compiled
{
    public struct InstType
    {
        private InstType(int i)
        {
            _value = i;
        }

        private readonly int _value;

        public override bool Equals(object obj)
        {
            return (obj is InstType ii &&
                ii._value == _value) ||
                (obj is int i &&
                i == _value);
        }
        public override int GetHashCode() => HashCode.Combine(_value);

        public static bool operator ==(InstType l, InstType r) => l.Equals(r);
        public static bool operator !=(InstType l, InstType r) => !l.Equals(r);

        public static implicit operator InstType(int i) => new InstType(i);
        public static implicit operator int(InstType ii) => ii._value;

        public const int FunctionCall = 0;
        public const int Add = 1;
        public const int Subtract = 2;
        public const int Multiply = 3;
        public const int Divide = 4;
        public const int HeapAlloc = 5;
        public const int Dealloc = 6;
        public const int StackAlloc = 7;
        public const int StackPop = 8;
        public const int SetVar = 9;
    }
}
