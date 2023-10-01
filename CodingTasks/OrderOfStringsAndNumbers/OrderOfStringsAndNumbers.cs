using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTasks.OrderOfStringsAndNumbers
{
    internal class OrderOfStringsAndNumbers
    {
        public string OrderOfStrings(string s)
        {
            var space = s.Split(' ');
            Dictionary<int, string> dic = new Dictionary<int, string>();
            foreach (var item in space)
            {
                var num = item[item.Length - 1].ToString();
                var subString = item.Substring(0, item.Length - 1);
                dic.Add(Convert.ToInt16(num), subString);
            }

            var de = dic.OrderBy(k => k.Key);

            string res = "";
            foreach (var item in de)
            {
                res = res + item.Value.ToString();
                res = res + " ";
            }
           return res.Trim();
        }
    }
}
