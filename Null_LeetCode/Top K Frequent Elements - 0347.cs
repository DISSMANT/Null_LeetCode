using System.Collections.Generic;

namespace Null_LeetCode
{
    public class TopKFrequentElements0347
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            var lenght = nums.Length;
            
            var frequentBest = new int[k];
            var hashTable = new Dictionary<int, List<int>>();
            var counter = new Dictionary<int, int>();
            
            // Грубый подсчёт [число : кол-во раз]
            foreach (var num in nums)
            {
                if (counter.ContainsKey(num)) counter[num]++;
                else counter.Add(num, 1);
            }
            
            // Создание словаря [кол-во раз : число]
            for (var x = 0; x < lenght; x++)
                hashTable.Add(x + 1, new List<int>());
            
            // Добавление во второй словарь из перового словаря
            foreach (var pair in counter)
                hashTable[pair.Value].Add(pair.Key);

            var counterK = 0;
            
            // Проход по второму словарю и добавление в массив-на-выход
            for (var x = hashTable.Count; x > 0; x--)
            {
                if (counterK == k) break;
                if (hashTable[x].Count <= 0) continue;
                foreach (var num in hashTable[x])
                {
                    frequentBest[counterK] = num;
                    counterK++;
                }
            }

            return frequentBest;
        }
    }
}