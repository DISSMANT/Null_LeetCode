using System;
using System.Linq;
using System.Xml.Schema;

namespace Null_LeetCode
{
    public class ValidPalindrome0125
    {
        public bool IsPalindrome(string s)
        {
            var newChars = s.Where(char.IsLetterOrDigit).ToArray();
            var newStr = new string(newChars).ToLower();
            
            var length = newStr.Length - 1;
            
            var leftPointer = 0;
            var rightPointer = length;

            while (leftPointer < rightPointer)
            {
                if (newStr[leftPointer] != newStr[rightPointer])
                    return false;
                leftPointer++;
                rightPointer--;
            }

            return true;
        }

        public bool IsPalindromeNoTransform(string s)
        {
            var length = s.Length - 1;
            
            var leftPointer = 0;
            var rightPointer = length;

            while (leftPointer < rightPointer)
            {
                var left = s[leftPointer];
                var right = s[rightPointer];
                var leftIsLetter = char.IsLetterOrDigit(left);
                var rightIsLetter = char.IsLetterOrDigit(right);

                if (!leftIsLetter)
                {
                    leftPointer++;
                    continue;
                }

                if (!rightIsLetter)
                {
                    rightPointer--;
                    continue;
                }
                if (char.ToLower(left) != char.ToLower(right))
                    return false;
                leftPointer++;
                rightPointer--;
            }

            return true;
        }
    }
}