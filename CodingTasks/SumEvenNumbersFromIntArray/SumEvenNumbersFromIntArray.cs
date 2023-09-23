using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTasks.SumEvenNumbersFromIntArray
{
    internal class SumEvenNumbersFromIntArray
    {
        public static int SumEven(int[] numbers)
        {
            Console.WriteLine("Question : Given an array of ints, write a C# method to total all the values that are even numbers.");

            return numbers.Where(x => x % 2 == 0).Sum();
        }
    }
}
