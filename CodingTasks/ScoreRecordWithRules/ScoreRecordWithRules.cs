using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTasks.ScoreRecordWithRules
{
    internal class ScoreRecordWithRules
    {
        public static int SumScore(List<string> ops)
        {
            int result = 0;
            List<int> add = new List<int>();
            foreach (var op in ops)
            {
                int num;
                if (Int32.TryParse(op, out num))
                {
                    add.Add(num);
                }
                else if (op == "+")
                {
                    int temp = add[add.Count - 1] + add[add.Count - 2];
                    add.Add(temp);
                }
                else if (op == "D")
                {
                    int temp = add[add.Count - 1] * 2;
                    add.Add(temp);
                }
                else if (op == "C")
                {
                    add.RemoveAt(add.Count - 1);
                }
            }
            foreach (var item in add)
            {
                result = result + item;
            }


            return result;
        }
    }
}
