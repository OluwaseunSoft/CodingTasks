using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTasks.FindTheMaxInt
{
    internal class FindTheMaxSum
    {
        public static void MaxInt(int max, int min)
        {
            List<int> list = new List<int>();
            List<int> list2 = new List<int>();
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            for (int i = min; i <= max; i++)
            {
                list.Add(i);
            }
            foreach (var item in list)
            {
                int tempA = 0;
                if (item.ToString().Length > 1)
                {
                    var sss = item.ToString().ToCharArray();
                    for (int i = 0; i < sss.Length; i++)
                    {
                        var temp = sss[i].ToString();
                        tempA += Convert.ToInt32(temp);
                    }
                    list2.Add(tempA);
                }
                else
                {
                    //tempA += Convert.ToInt32(item);
                    //list2.Add((int)item);
                }
                dictionary.Add(item, tempA);
            }
            var count1 = 0;
            foreach (var item in dictionary)
            {
                foreach (var item2 in list2)
                {
                    if (item.Key == item2)
                    {
                        Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
                        count1++;
                    }
                }

            }
            Console.WriteLine(count1);
        }
    }
}
