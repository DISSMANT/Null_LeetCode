using System;
using System.Collections;
using System.Collections.Generic;

namespace Null_LeetCode
{
    public class ValidParantheses0020
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();

            foreach (var c in s)
                if (c == '{' || c == '(' || c == '[')
                    stack.Push(c);
                else
                {
                    if (stack.Count == 0)
                        return false;
                    var pop = stack.Pop();
                    if ((pop == '{' && c != '}') || (pop == '(' && c != ')') || (pop == '[' && c != ']'))
                        return false;
                }

            return stack.Count == 0;
        }
    }
}