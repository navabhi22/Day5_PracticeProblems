using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_PracticeProblems
{
    public class SwapNumber
    {
        /// <summary>
        /// Swaps the number.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        public static void SwapNum(int a, int b)
        {

            Console.WriteLine("before swap a = " + a + " b = " + b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine(" after swap a = " + a + " b = " + b);

        }
    }
}