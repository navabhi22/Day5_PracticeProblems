using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_PracticeProblems
{
    public class FindingLargest
    {

        public static void FindLaegestNum()
        {
            int num1, num2, num3;

            Console.WriteLine("Find the largest of three numbers ");

            Console.WriteLine("input the first number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("input the second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("input the third number");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine(" The 1st number is largest");
                }
                else
                {
                    Console.WriteLine(" the 3rd number is largest");
                }
            }

            else if (num2 > num3)
            {
                Console.WriteLine("The 2nd num Largest");
            }
            else
            {
                Console.WriteLine("the 3rd number is largest");
            }

        }
    }
}