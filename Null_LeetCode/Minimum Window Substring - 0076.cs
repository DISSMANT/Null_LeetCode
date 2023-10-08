using System.Collections.Generic;
using System.Security.Policy;

namespace Null_LeetCode
{
    public class Minimum_Window_Substring___0076
    {
        public string MinWindow(string s, string t)
        {
            if (t == "") return "";
            
            var currentWindow = new Dictionary<char, int>();
            var target = new Dictionary<char, int>();

            var result = (0, 0);
            var resultLength = int.MaxValue;
            
            foreach (var currentChar in t)
            {
                if (target.ContainsKey(currentChar)) target[currentChar]++;
                else target.Add(currentChar, 1);
            }

            var targetBool = target.Count;
            var currentBool = 0;

            var left = 0;
            for (var right = 0; right < s.Length; right++)
            {
                var currentChar = s[right];
                
                if (currentWindow.ContainsKey(currentChar)) currentWindow[currentChar]++;
                else currentWindow.Add(currentChar, 1);

                if (target.ContainsKey(currentChar) && currentWindow[currentChar] == target[currentChar]) currentBool++;

                while (currentBool == targetBool)
                {
                    var size = right - left + 1;

                    if (size < resultLength)
                    {
                        result = (left, right);
                        resultLength = size;
                    }

                    currentWindow[s[left]]--;
                    if (target.ContainsKey(s[left]) && currentWindow[s[left]] < target[s[left]])
                        currentBool--;

                    left++;
                }

            }
            
            
            return resultLength == int.MaxValue ? "" : s.Substring(result.Item1, result.Item2 - result.Item1 + 1);
        }
    }
}