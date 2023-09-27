using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTasks.SplitStringIntoEqualChunks
{
    internal static class SplitStringIntoEqualChunks
    {
        public static IEnumerable<string> ChunkSplit(this string str, int chunkSize)
        {
            Console.WriteLine("Question : Splitting a string into chunks of a certain size.");
            for (int i = 0; i < str.Length; i += chunkSize)
            {
                yield return str.Substring(i, Math.Min(chunkSize, str.Length - i));
            }
        }

        public static string SplitChunkSize()
        {
            string str = "abcde";
            int chunkSize = 2;
            for (int i = 0; i < str.Length; i += chunkSize)
            {
                str.Substring(i, Math.Min(chunkSize, str.Length - i));
            }
            return "true";
        }

        public static IEnumerable<string> ChunkMethod(string str, int chunkSize)
        {
            return str.Chunk(chunkSize).Select(s => new string(s)).ToArray();
        }
    }
}
