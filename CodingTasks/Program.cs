// See https://aka.ms/new-console-template for more information
using CodingTasks.AlphabetPositionString;
using CodingTasks.BinaryOutput;
using CodingTasks.FindTheMaxInt;
using CodingTasks.ScoreRecordWithRules;
using CodingTasks.SplitStringIntoEqualChunks;
using CodingTasks.SumEvenNumbersFromIntArray;

int[] numbers = new int[] { 23, 22, 67, 89, 9, 76, 66 };
//Console.WriteLine("Sum of the even numbers in the array is : {0}", SumEvenNumbersFromIntArray.SumEven(numbers).ToString());

//FindTheMaxSum.MaxInt(15, 5);

//Console.WriteLine("Sum of the characters with their respective numbers from a string : {0}", AlphabetPositionString.PositionAlphabet("turing", 2).ToString());

//var tokens = SplitStringIntoEqualChunks.ChunkMethod("abcde", 2);

//Console.WriteLine(String.Join(",", tokens));

//List<string> ops = new List<string> { "5", "2", "C", "D", "+" };
//Console.WriteLine(ScoreRecordWithRules.SumScore(ops).ToString());

var tokens = BinaryOutput.BinaryFigure(7);

Console.WriteLine(String.Join(",", tokens));

//
//Console.WriteLine(d);
//string s = "red2 blue5 black4 green1 gold3";
//var space = s.Split(' ');
//Dictionary<int, string> dic = new Dictionary<int, string>();
//foreach(var item in space)
//{
//    var num = item[item.Length - 1].ToString();
//    var subString = item.Substring(0, item.Length - 1);
//    dic.Add(Convert.ToInt16(num), subString);
//}

//var de = dic.OrderBy(k=>k.Key);

//string res = "";
//foreach(var item in de)
//{
//    res = res + item.Value.ToString();
//    res = res + " ";
//}
//Console.WriteLine(res.Trim());


