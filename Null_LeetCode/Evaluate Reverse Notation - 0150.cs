using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Emit;

namespace Null_LeetCode
{
    public class EvaluateReverseNotation
    {
        public int EvalRPN(string[] tokens)
        {
            var stack = new Stack<int>();
            var length = tokens.Length;
            
            for (var x = 0; x < length; x++)
            {
                var symbol = tokens[x];
                if (IsOperand(symbol))
                {
                    int f = stack.Pop(), s = stack.Pop();
                    switch (symbol)
                    {
                        case "-": stack.Push(s - f);
                            break;
                        case "+": stack.Push(s + f);
                            break;
                        case "/": stack.Push(s / f);
                            break;
                        case "*": stack.Push(s * f);
                            break;
                    }
                }
                else
                    stack.Push(int.Parse(symbol));
            }

            return stack.Pop();
        }

        private static bool IsOperand(string str)
        {
            return str == "-" || str == "+" || str == "*" || str == "/";
        }
    }
}