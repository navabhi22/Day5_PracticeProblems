﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_PracticeProblems
{
    public class VowelOrConsonant
    {
        /// <summary>
        /// To check for Vowel or Consonants
        /// </summary>
        public static void CheckVowelAndConsonant()
        {
            Console.WriteLine("Enter a character");
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine(ch + " is a Vowel");
            }
            else if ((ch >= 'a') && (ch <= 'z') || (ch >= 'A') && (ch <= 'Z'))
            {
                Console.WriteLine(ch + " is a Consonant");
            }
            else
            {
                Console.WriteLine("enter a valid character");
            }
        }
    }
}
