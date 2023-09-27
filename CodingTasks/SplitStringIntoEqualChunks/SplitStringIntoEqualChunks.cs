using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTasks.SplitStringIntoEqualChunks
{
    internal class SplitStringIntoEqualChunks
    {
        public static IEnumerable<string> ChunkSplit(string str, int chunkSize)
        {
            Console.WriteLine("Question : Splitting a string into chunks of a certain size.");
            for (int i = 0; i < str.Length; i += chunkSize)
            {
                yield return str.Substring(i, Math.Min(chunkSize, str.Length - i));
            }
        }
    }
}
