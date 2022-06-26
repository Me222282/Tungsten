namespace Compiled
{
    public enum InstType : int
    {
        FunctionCall,
        Add,
        Subtract,
        Multiply,
        Divide,
        HeapAlloc,
        Dealloc,
        StackAlloc,
        StackPop,
        SetVar
    }
}
