using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTasks.AlphabetPositionString
{
    internal class AlphabetPositionString
    {
        public static int num = 31;
        public static int PositionAlphabet(string s, int n)
        {
            Console.WriteLine("Question : Write a C# Sharp program that returns the sum all the characters with their respective numbers from a string.");
            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine((s[i] & num) + " ");
                ans += (s[i] & num);
            }

            return ans;
        }

        public static int PositionAlphabet(string s)
        {
            Console.WriteLine("Question : Write a C# Sharp program that returns the sum all the characters with their respective numbers from a string.");

            return s.ToLower().Where(x => Char.IsLetter(x))
                .Select(x => (int)x % 32).ToArray().Sum();
        }

    }
}
