using System.Security.Policy;
using System;
using System.Collections.Generic;

namespace Null_LeetCode
{
    public class ContainsDuplicate0217
    {
        public bool ContainsDuplicate(int[] nums)
        {
            var hash = new Dictionary<int, bool>();

            foreach (var num in nums)
            {
                if (hash.ContainsKey(num))
                    return true;
                else
                    hash.Add(num, true);
            }

            return false;
        }
        
        // Создаём хеш-таблицу
        // Добавляем значения в хэш-таблицу
        // Если находим значение до добавления -> возращаем значение
        public bool AnotherContainsDuplicate(int[] nums)
        {
            var hash = new HashSet<int>(nums);

            return nums.Length != hash.Count;
        }
    }
}