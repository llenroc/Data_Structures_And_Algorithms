using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Big_O
{
    class Program
    {
        /* Big O Complexity Chart: https://www.bigocheatsheet.com/ */

        #region [#Big O Cheat Sheet:]
        /* 
            #Big O Cheat Sheet:

            -Big Os-

            O(1) Constant- no loops
            O(log N) Logarithmic- usually searching algorithms have log n if they are sorted (Binary Search)
            O(n) Linear- for loops, while loops through n items
            O(n log(n)) Log Liniear- usually sorting operations
            O(n^2) Quadratic- every element in a collection needs to be compared to ever other element. Two
            nested loops
            O(2^n) Exponential- recursive algorithms that solves a problem of size N
            O(n!) Factorial- you are adding a loop for every element

            Iterating through half a collection is still O(n)
            Two separate collections: O(a * b)


            -What can cause time in a function?-

            Operations (+, -, *, /)
            Comparisons (<, >, ==)
            Looping (for, while)
            Outside Function call (function())


            -Rule Book-

            Rule 1: Always worst Case
            Rule 2: Remove Constants
            Rule 3: Different inputs should have different variables. O(a+b). A and B arrays nested would be
            O(a*b)
            + for steps in order
            * for nested steps
            Rule 4: Drop Non-dominant terms


            -What causes Space complexity?-

            Variables
            Data Structures
            Function Call
            Allocations
        */
        #endregion

        static void Main(string[] args)
        {
            findNemo(nemo); /* _025_findNemo */
            logAllPairsOfArray(boxes); /* _037_logAllPairsOfArray */

            Console.ReadKey();
        }

        /* _025_findNemo */
        static string[] nemo = new string[1] { "nemo" };
        static void findNemo(string[] array)  // Big O: O(n) --> Linear Time
        {
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == "nemo")
                {
                    Console.WriteLine("Found Nemo!");
                }
            }
        }

        /* _037_logAllPairsOfArray */
        static char[] boxes = new char[5] { 'a', 'b', 'c', 'd', 'e' };
        static void logAllPairsOfArray(char[] boxes)  // Big O: O(n * n) or O(n^2) --> Quadratic Time
        {
            for (int i = 0; i < boxes.Length; i++)
            {
                for (int j = 0; j < boxes.Length; j++)
                {
                    Console.WriteLine("{0}-{1}", boxes[i], boxes[j]);
                }
                Console.WriteLine();
            }
        }





    }
}
