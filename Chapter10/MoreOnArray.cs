using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace Chapter10
{
    internal class MoreOnArray
    {
        private static bool CheckPassed(int score)
        {
            return score >= 60;
        }
        private static void Print(int value)
        {
            Console.WriteLine($"{value} ");
        }
        static void Main(string[] args)
        {
            int[] score = new int[] { 80, 74, 81, 90, 34 };
            foreach (int i in score)Console.Write($"{i} ");
            Console.WriteLine();

            Array.Sort(score);
            Array.ForEach<int>(score,new Action<int>(Print));
            Console.WriteLine();
            Console.WriteLine($"Number of dimensions : {score.Rank}");
            Console.WriteLine($"Binary Serach : 81 is at "+$"{Array.BinarySearch<int>(score,90)}");
            Console.WriteLine($"Linear Search : 90 is at "+$"{Array.IndexOf(score,90)}");
            Console.WriteLine($"{Array.TrueForAll<int>(score,CheckPassed)}");

        }
    }
}*/
