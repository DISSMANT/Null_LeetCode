using System;
using System.Collections.Generic;
using System.Linq;

namespace Null_LeetCode
{
    public class GroupAnagrams0049
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            if (strs.Length == 0) return default;
            var res = new Dictionary<string, IList<string>>();
            foreach (var str in strs)
            {
                var tempChars = str.ToCharArray();
                Array.Sort(tempChars);
                var key = new string(tempChars);
                
                if (!res.ContainsKey(key))
                    res.Add(key, new List<string>());
                res[key].Add(str);
            }
            
            return res.Values.ToList();
        }
    }
}