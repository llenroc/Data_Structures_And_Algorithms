using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Big_O
{
    class Program
    {
        /* Big O Complexity Chart: https://towardsdatascience.com/understanding-time-complexity-with-python-examples-2bda6e8158a7 */

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
        static void logAllPairsOfArray(char[] boxes)
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
