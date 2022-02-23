namespace Day5_PracticeProblems
{
    internal class EvenOdd
    {
        /// <summary>
        /// Checks for Even and Odd number.
        /// </summary>
        /// <param name="N">The n.</param>
        /// <returns></returns>
        public static string CheckEvenOdd(int N)
        {
            if (N % 2 == 0)
            {

                return $"{N} is an even number";

            }
            else
            {

                return $"{N} is an Odd number";
            }
        }
    }
}

