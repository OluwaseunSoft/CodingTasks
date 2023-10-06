using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTasks.PositiveNegativeZeroArray
{
    internal class PositiveNegativeZeroArray
    {
        public static void PositiveNegativeZeroArrayMethod(int[] arr)
        {
            Console.WriteLine("{0}", ((decimal)arr.Where(x => x == 0).Count() / (decimal)arr.Length).ToString("N6"));
            Console.WriteLine("{0}", ((decimal)arr.Where(x => x < 0).Count() / (decimal)arr.Length).ToString("N6"));
            Console.WriteLine("{0}", ((decimal)arr.Where(x => x > 0).Count() / (decimal)arr.Length).ToString("N6"));
        }
    }
}
