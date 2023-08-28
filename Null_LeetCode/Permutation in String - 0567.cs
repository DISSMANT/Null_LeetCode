using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security;

namespace Null_LeetCode
{
    public class PermutationInString0567
    {
        public bool CheckInclusion(string s1, string s2)
        {
            if (s1.Length > s2.Length) return false;
            
            var first = Enumerable.Repeat(0, 26).ToArray();
            var second = Enumerable.Repeat(0, 26).ToArray();

            for (var x = 0; x < s1.Length; x++)
            {
                first[s1[x] - 'a']++;
                second[s2[x] - 'a']++;
            }

            var succeedChars = 0;

            for (var x = 0; x < 26; x++)
                if (first[x] == second[x]) succeedChars++;

            var left = 0;

            for (var right = s1.Length; right < s2.Length; right++)
            {
                if (succeedChars == 26) return true;

                var currentChar = s2[right] - 'a';
                second[currentChar]++;

                if (first[currentChar] == second[currentChar])
                    succeedChars++;
                else if (first[currentChar] + 1 == second[currentChar])
                    succeedChars--;

                currentChar = s2[left] - 'a';
                second[currentChar]--;

                if (first[currentChar] == second[currentChar])
                    succeedChars++;
                else if (first[currentChar] - 1 == second[currentChar])
                    succeedChars--;

                left++;
            }

            return succeedChars == 26;
        }
    }
}