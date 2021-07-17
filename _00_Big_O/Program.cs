using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Big_O
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nemo = new string[1] { "nemo" };
            findNemo(nemo);

            Console.ReadKey();
        }

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

    }
}
