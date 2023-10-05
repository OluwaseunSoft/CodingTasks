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
            var zero = arr.Where(x => x == 0).Count();
            var nega = arr.Where(x => x < 0).Count();
            var posi = arr.Where(x => x > 0).Count();
            Console.WriteLine("{0}", ((decimal)zero / (decimal)arr.Length).ToString("N6"));
            Console.WriteLine("{0}", ((decimal)nega / (decimal)arr.Length).ToString("N6"));
            Console.WriteLine("{0}", ((decimal)posi / (decimal)arr.Length).ToString("N6"));            
        }
    }
}
