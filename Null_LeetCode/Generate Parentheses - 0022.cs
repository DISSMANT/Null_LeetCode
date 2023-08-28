using System;
using System.Collections.Generic;

namespace Null_LeetCode
{
    public class GenerateParentheses0022
    {
        private static int N;
        private static List<string> output = new List<string>();

        public IList<string> GenerateParenthesis(int n)
        {
            output.Clear();
            N = n * 2;
            
            DifferentBrackets(new char[N], 0, 0, new Stack<char>());
            
            return output;
        }

        private static void DifferentBrackets(char[] brackets, int k, int balance, Stack<char> stack)
        {
            while (!false)
            {
                if (k == N)
                    output.Add(new string(brackets));
                else
                {
                    if (balance > 0)
                    {
                        brackets[k] = ')';
                        DifferentBrackets(brackets, k + 1, balance - 1, stack);
                    }

                    if (balance + 1 <= N - (k + 1))
                    {
                        brackets[k] = '(';
                        k++;
                        balance++;
                        continue;
                    }
                }

                break;
            }
        }
    }
}