﻿// See https://aka.ms/new-console-template for more information
using CodingTasks.AlphabetPositionString;
using CodingTasks.FindTheMaxInt;
using CodingTasks.SumEvenNumbersFromIntArray;

int[] numbers = new int[] { 23, 22, 67, 89, 9, 76, 66 };
//Console.WriteLine("Sum of the even numbers in the array is : {0}", SumEvenNumbersFromIntArray.SumEven(numbers).ToString());

//FindTheMaxSum.MaxInt(15, 5);

//int d = Convert.ToInt32('E');
//Console.WriteLine((d % 32).ToString());
string str = "Turing";
int n = str.Length;
Console.WriteLine("Sum of the characters with their respective numbers from a string : {0}", AlphabetPositionString.PositionAlphabet(str).ToString());

