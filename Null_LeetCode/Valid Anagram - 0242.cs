using System;
using System.Collections.Generic;
using System.Linq;

namespace Null_LeetCode
{
    public class ValidAnagram0242
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;
            
            var dictS = new Dictionary<char, int>();
            foreach (var c in s)
            {
                if (dictS.ContainsKey(c)) dictS[c]++;
                else dictS.Add(c, 1);
            }

            var dictT = new Dictionary<char, int>();
            foreach (var c in t)
            {
                if (dictT.ContainsKey(c)) dictT[c]++;
                else dictT.Add(c, 1);
            }

            return dictS.Count == dictT.Count &&
                   dictS.Keys.All(key => dictT.ContainsKey(key) && dictT[key] == dictS[key]);
        }
    }
}