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
            List<ulong> sums = new List<ulong>();
            foreach (var item in arr)
            {
                ulong sum = arr.Select(i => (ulong)i).Aggregate((a, b) => a + b);
                sums.Add(sum - (ulong)item);
            }
            Console.WriteLine($"{sums.Min()} {sums.Max()}");
        }
    }
}
