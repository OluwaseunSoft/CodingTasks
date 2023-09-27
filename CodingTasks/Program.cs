// See https://aka.ms/new-console-template for more information
using CodingTasks.AlphabetPositionString;
using CodingTasks.FindTheMaxInt;
using CodingTasks.SplitStringIntoEqualChunks;
using CodingTasks.SumEvenNumbersFromIntArray;

int[] numbers = new int[] { 23, 22, 67, 89, 9, 76, 66 };
//Console.WriteLine("Sum of the even numbers in the array is : {0}", SumEvenNumbersFromIntArray.SumEven(numbers).ToString());

//FindTheMaxSum.MaxInt(15, 5);

//Console.WriteLine("Sum of the characters with their respective numbers from a string : {0}", AlphabetPositionString.PositionAlphabet("turing", 2).ToString());
string s = "abcde";
int chunk = 2;
var tokens = SplitStringIntoEqualChunks.ChunkMethod(s, chunk);

Console.WriteLine(String.Join(",", tokens));

