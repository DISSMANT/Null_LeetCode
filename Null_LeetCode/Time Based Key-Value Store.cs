using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Null_LeetCode
{
    public class TimeMap
    {
        private Dictionary<string, List<(string value, int time)>> dataBase;


        public TimeMap()
        {
            dataBase = new Dictionary<string, List<(string value, int time)>>();
        }

        public void Set(string key, string value, int timestamp)
        {
            if (dataBase.ContainsKey(key))
                dataBase[key].Add((value, timestamp));
            else
                dataBase.Add(key, new List<(string value, int time)>(new (string value, int time)[] {(value, timestamp)}));
        }

        public string Get(string key, int timestamp)
        {
            if (!dataBase.ContainsKey(key))
                return "";
            
            var values = dataBase[key];
            var outputResult = "";

            var left = 0;
            var right = values.Count - 1;

            while (left <= right)
            {
                var middle = (right - left) / 2 + left;

                if (values[middle].time <= timestamp)
                {
                    outputResult = values[middle].value;
                    left = middle + 1;
                }
                else
                    right = middle - 1;
            }

            return outputResult;
        }
    }
}