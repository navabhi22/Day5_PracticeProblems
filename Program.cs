using System;

namespace Day5_PracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day 6 Practice Problems ");
            Console.WriteLine("Enter the number 1 ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number 2 ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            SwapNumber.SwapNum(num1, num2);

            
        }
    }
}