using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTasks.BinaryOutput
{
    internal class BinaryOutput
    {
        public static int[] BinaryFigure(int n)
        {
            int[] result = new int[n + 1];
            for (int i = 0; i < n + 1; i++)
            {
                int counter = 0;
                string binary = Convert.ToString(i, 2);
                var charBin = binary.ToCharArray();
                foreach (var item in charBin)
                {
                    if (item == '1')
                    {
                        counter++;
                    }
                }
                //var counter = binary.Where(x => x == '1').Count();
                result[i] = counter;
            }
            return result;
        }
    }
}
