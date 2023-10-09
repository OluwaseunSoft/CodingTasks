using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTasks.MiniMaxSum
{
    internal class MiniMaxSum
    {
        public static void MiniMaxSumFunction(List<int> arr)
        {
            List<Int64> sums = new List<Int64>();

            foreach (var item in arr)
            {
                sums.Add(arr.ToList().Sum() - item);
            }
            Console.WriteLine($"{sums.Min()} {sums.Max()}");
        }
    }
}
