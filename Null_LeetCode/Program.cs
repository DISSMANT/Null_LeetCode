using System;

namespace Null_LeetCode
{
    internal abstract class Program
    {
        public static void Main(string[] args)
        {
            var mS = new MinStack();
            
            mS.Push(-2);
            mS.Push(0);
            mS.Push(-3);
            
            Console.WriteLine(mS.Top().ToString());
            Console.WriteLine(mS.GetMin());
            mS.Pop();
            Console.WriteLine(mS.Top().ToString());
            Console.WriteLine(mS.GetMin().ToString());
        }
    }
}