using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.IO;

namespace _06_Data_Structures_Arrays
{
    class Program
    {
        /* 058 List-of-Data-Structures: https://en.wikipedia.org/wiki/List_of_data_structures */
        /* 059 Computer-Memory: http://statmath.wu.ac.at/courses/data-analysis/itdtHTML/node55.html */
        /* 059 Crash-Course-RAMs-and-Registers: https://www.youtube.com/watch?v=fpnE6UAfbtU */
        /* JavaScript Var vs Let vs Const: https://dev.to/sethusenthil/var-vs-let-vs-const-1cgc */

        /* 062 Arrays-Repl https://repl.it/@aneagoie/DataStructures-Arrays */
        /* 066 Data-Structure-Array-Repl https://repl.it/@aneagoie/DataStructure-Array-Implementation */
        /* 068 Reverse-String-Repl https://repl.it/@aneagoie/ReverseString-exercise */
        /* 069 Solution-Code https://repl.it/@aneagoie/ReverseString */
        /* 070 mergeSortedArrays-exercise-Repl https://repl.it/@aneagoie/MergeSortedArrays-exercise */
        /* 071 Solution-Code https://replit.com/@aneagoie/MergeSortedArrays */

        static void Main(string[] args)
        {
            //ImplementArray();
            //ReverseString();
            //ReverseString2();
            //ReverseString3();
            MergeSortedArrays(new int[] { 0, 3, 4, 31 }, new int[] { 4, 6, 30 });

           Console.ReadKey();
        }

        #region [ImplementArray]
        private static void ImplementArray()
        {
            int arraySize = 15;
            Array array = new Array(arraySize);
            for (int i = 0; i < arraySize; i++)
            { 
                array.Push(i);
            }
            Console.WriteLine(array.Get());

            array.Pop();
            Console.WriteLine(array.Get());

            array.Delete(1);
            Console.WriteLine(array.Get());

            array.Push("Ashraf");
            Console.WriteLine(array.Get());

            for (int i = 1; i < arraySize; i++)
            {
                array.Push(i * 100);
            }
            Console.WriteLine(array.Get());

        }
        #endregion

        #region [Reverse A String 1]
        private static string ReverseString(string str = "Hi My Name Is Ashraf") // Time complexity O(n)
        {
            if (str == null || str.Length < 2)
            {
                return "Chek the inputs!";
            }

            string revString = "";
            char[] charArray = str.ToCharArray();

            for (int i = str.Length - 1; i >= 0  ; i--) // Time complexity O(n)
            {
                revString = revString + charArray[i];
            }

            Console.WriteLine(revString);
            return revString;
        }
        #endregion

        #region [Reverse A String 2] 
        static string ReverseString2(string str = "Hi My Name Is Ashraf") // No Good! Time complexity O(n^2)
        {
            if (str == null || str.Length < 2)
            {
                return "Chek the inputs!";
            }

            char[] revArray = str.ToCharArray();
            char temp = ' ';

            for (int i = 0; i < revArray.Length; i++) // Time complexity O(n^2)
            {
                for (int j = 0; j < revArray.Length - 1 - i; j++)
                {
                    //if (revArray[j] > revArray[j+1]) // if you want to sort it
                    //{
                    temp = revArray[j];
                    revArray[j] = revArray[j + 1];
                    revArray[j + 1] = temp;
                    //}
                }
            }

            string rev = string.Join(" ", revArray);
            Console.WriteLine(rev);
            return rev;
        }
        #endregion

        #region [Reverse A String 3] 
        static string ReverseString3(string str = "Hi My Name Is Ashraf") // Time complexity O(n^2)
        {
            if (str == null || str.Length < 2)
            {
                return "Chek the inputs!";
            }

            string s = string.Join("", str.Reverse()); // Ok 
            string s2 = string.Join("", str.ToCharArray().Reverse()); // Ok 
            string s3 = string.Join(" ", str.Split(' ').Reverse()); // x

            return s;
        }
        #endregion

        #region [Merge Sorted Arrays]
        static int[] MergeSortedArrays(int[] array1, int[] array2) // Time complexity O(n)
        {
            int[] mergedArrays = new int[array1.Length + array2.Length];
            int idx1 = 0;
            int idx2 = 0;
            for (int i = 0; i < mergedArrays.Length; i++)
            {
                if(idx1 < array1.Length && idx2 < array2.Length && array1[idx1] < array2[idx2])
                {
                    mergedArrays[i] = array1[idx1++];
                }
                else if (idx1 < array1.Length && idx2 < array2.Length && array1[idx1] >= array2[idx2])
                {
                    mergedArrays[i] = array2[idx2++];
                }
                else if(idx1 < array1.Length || idx2 > array2.Length)
                {
                    mergedArrays[i] = array1[idx1++];
                }
                else if (idx2 < array2.Length || idx1 > array1.Length)
                {
                    mergedArrays[i] = array2[idx2++];
                }
            }

            Console.WriteLine(string.Join(",", mergedArrays));
            return mergedArrays;
        }
        #endregion
    }

}
