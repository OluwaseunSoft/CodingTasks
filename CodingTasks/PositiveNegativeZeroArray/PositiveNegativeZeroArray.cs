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
        }
    }
}
