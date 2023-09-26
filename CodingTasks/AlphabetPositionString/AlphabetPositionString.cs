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

            var r = s.ToLower().Where(x => Char.IsLetter(x))
               .Select(x => x % 32).ToArray();
            var str = String.Join("", r);
            int result = 0;

            

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < str.Length; j++)
                {
                    result += Int32.Parse(str[j].ToString());
                }
                str = result.ToString();
                result = 0;
            }

            return Int32.Parse(str.ToString());
        }

    }
}
