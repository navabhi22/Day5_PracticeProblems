using System;

namespace Day5_PracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day 6 Practice Problems ");
            Console.WriteLine("Enter the number ");
            int N = Convert.ToInt32(Console.ReadLine());    

            string Output =EvenOdd.CheckEvenOdd(N);    
            Console.WriteLine(Output);
        }
    }
}