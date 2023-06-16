using System;

namespace Null_LeetCode
{
    internal abstract class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(new SearchATwoDMatrix0074().SearchMatrix(new int[][] {new []{1,3,5,7},
                                                                                    new []{10,11,16,20},
                                                                                    new []{23,30,34,60}}, 3));

            // for (int x = 0; x < t.Length; x++)
            // {
            //     Console.WriteLine(t[x]);
            // }
        }
    }
}