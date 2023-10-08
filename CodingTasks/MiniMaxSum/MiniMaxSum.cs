using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTasks.MiniMaxSum
{
    internal class MiniMaxSum
    {
        public static void MiniMaxSumFunction(int[] arr)
        {
            List<Int64> sums = new List<Int64>();

            for (int i = 0; i < arr.Length; i++)
            {
                Int64 num = arr.ToList().Sum() - arr[i];
                sums.Add(num);
            }
            Console.WriteLine($"{sums.Min()} {sums.Max()}");
        }
    }
}
