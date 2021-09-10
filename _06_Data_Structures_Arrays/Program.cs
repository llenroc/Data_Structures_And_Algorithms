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
        /* 066 Data-Structure-ArrayDS-Repl https://repl.it/@aneagoie/DataStructure-ArrayDS-Implementation */
        /* 068 Reverse-String-Repl https://repl.it/@aneagoie/ReverseString-exercise */
        /* 069 Solution-Code https://repl.it/@aneagoie/ReverseString */
        /* 070 mergeSortedArrays-exercise-Repl https://repl.it/@aneagoie/MergeSortedArrays-exercise */
        /* 071 Solution-Code https://replit.com/@aneagoie/MergeSortedArrays */

        /* leetcode */
        /* 0. Reverse String: https://leetcode.com/problems/reverse-string/ */
        /* 0. Merge Sorted Arrays LeetCode: https://leetcode.com/problems/merge-sorted-array/ */
        /* 1. Two Sum: https://leetcode.com/problems/two-sum/description/ */
        /* 53. Maximum Subarray: https://leetcode.com/problems/maximum-subarray/description/ */
        /* 283. Move Zeroes: https://leetcode.com/problems/move-zeroes/description/ */
        /* 217. Contains Duplicate: https://leetcode.com/problems/contains-duplicate/description/ */
        /* 189. Rotate ArrayDS: https://leetcode.com/problems/rotate-array/description/ */

        /* regex: https://regex101.com/ */

        /* coderbyte */
        /* Longest Word: https://coderbyte.com/information/Longest%20Word */


        static void Main(string[] args)
        {
            //ImplementArray();

            //ReverseString();
            //ReverseString2();
            //ReverseString3();
            //ReverseString4();
            //ReverseString5();
            //ReverseString6();

            //MergeSortedArrays(new int[] { 0, 3, 4, 31 }, new int[] { 4, 6, 30 });
            //MergeSortedArrays2(new int[] { 0, 3, 4, 31, 37, 39, 43, 48 }, new int[] { 4, 6, 30, 32, 33, 34, 35, 38, 40, 41, 44, 46, 47 });

            //MergeSortedArraysLeetCode(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3);
            //MergeSortedArraysLeetCode(new int[] { 0, 3, 4, 31, 37, 39, 43, 48, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, }, 8, new int[] { 4, 6, 30, 32, 33, 34, 35, 38, 40, 41, 44, 46, 47 }, 13);

            //TwoSum(new int[] { 2,7,11,15}, 9);
            //TwoSum(new int[] { 3, 2, 4 }, 6);
            //TwoSum(new int[] { 3, 3 }, 6);
            //TwoSum2(new int[] { 2, 7, 11, 15 }, 9);
            //TwoSum2(new int[] { 3, 2, 4 }, 6);
            //TwoSum2(new int[] { 3, 3 }, 6);

            //TwoSum3(new int[] { 3, 2, 4 }, 6);
            //TwoSum3(new int[] { 3, 3 }, 6);

            //MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
            //MaxSubArray(new int[] { 1 });
            //MaxSubArray(new int[] { 5, 4, -1, 7, 8 });
            //MaxSubArray2(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
            //MaxSubArray3(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }); // x
            //MaxSubArray3(new int[] { 5, 4, -1, 7, 8 }); // x

            //MoveZeroes(new int[] { 0, 1, 0, 3, 12 });
            //MoveZeroes2(new int[] { 0, 1, 0, 3, 12 });
            //MoveZeroes3(new int[] { 0, 1, 0, 3, 12 });

            //ContainsDuplicate(new int[] { 1, 2, 3, 1 });
            //ContainsDuplicate(new int[] { 1, 2, 3, 4 });
            //ContainsDuplicate(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 });

            //Rotate(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3); // Expected: [5, 6, 7, 1, 2, 3, 4]
            //Rotate(new int[] { -1, -100, 3, 99 }, 2); // Expected [3,99,-1,-100]
            //Rotate(new int[] { 1, 2 }, 3); // Expected [2,1]
            //Rotate(new int[] { 1, 2, 3 }, 2); // Expected [2,3,1]
            //Rotate(new int[] { 1, 2, 3, 4, 5, 6 }, 2); // Expected [5,6,1,2,3,4]
            //Rotate(new int[] { 1, 2, 3, 4, 5, 6 }, 4); // Expected [3,4,5,6,1,2]

            LongestWord("fun&!! time");
            LongestWord("I love dogs"); 

            Console.ReadKey();
        }


        #region []
        #region [?]
        /* 1.  */
        /*
 
        */
        #endregion
        static int[] xxx() // 
        {

            return null;
        }
        #endregion

        #region [ImplementArray]
        private static void ImplementArray()
        {
            int arraySize = 15;
            ArrayDS array = new ArrayDS(arraySize);
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

            IEnumerable<char> ss = str.Reverse();
            string s = string.Join(" ", ss);

            string s1 = string.Join("", str.Reverse()); // Ok -> "farhsA sI emaN yM iH" 
            string s2 = string.Join("", str.ToCharArray().Reverse()); // Ok -> "farhsA sI emaN yM iH" 
            string s3 = string.Join(" ", str.Split(' ').Reverse()); // x -> "Ashraf Is Name My Hi"

            return s;
        }
        #endregion

        #region [Reverse A String 4]
        /*

        */
        static string ReverseString4(string str = "Hi My Name Is Ashraf") // 
        {
            string s = "";
            char[] charArray = str.ToCharArray();
            //s = ArrayDS.Reverse(charArray); // Works fine in LeetCode !!

            return s;
        }
        #endregion

        #region [Reverse A String 5]
        /*

        */
        static string ReverseString5(string str = "Hi My Name Is Ashraf") // 
        {
            string s = "";
            char[] arr = str.ToCharArray();
            //s = ArrayDS.Reverse(charArray); // Works fine in LeetCode !!

            for (int i = 0, end = arr.Length -1; i < end; i++, end--) //O(n)
            {
                char temp = arr[i];
                arr[i] = arr[end];
                arr[end] = temp;
            }

            s = string.Join("", arr);

            return s;
        }
        #endregion

        #region [Reverse A String 6]
        /*

        */
        static string ReverseString6(string str = "Hi My Name Is Ashraf") // 
        {
            string s = "";
            char[] arr = str.ToCharArray();
            //s = ArrayDS.Reverse(charArray); // Works fine in LeetCode !!

            //Time Complexity = O(n / 2) ~= O(n)
            //Space Complexity = O(1)

            for (int i = 0; i < arr.Length / 2; i++) //O(n)
            {
                char temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }

            s = string.Join("", arr);

            return s;
        }
        #endregion


        #region [Merge Sorted Arrays]
        static int[] MergeSortedArrays(int[] array1, int[] array2) // Time complexity O(n)
        {
            if (array1.Length == 0)
            {
                return array2;
            }
            if (array2.Length == 0)
            {
                return array1;
            }

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

        #region [Merge Sorted Arrays 2]
        static int[] MergeSortedArrays2(int[] array1, int[] array2) // Time complexity O(n)
        {
            if (array1.Length == 0)
            {
                return array2;
            }
            if (array2.Length == 0)
            {
                return array1;
            }

            var newLength = array1.Length + array2.Length;
            var mergedArray = new int[newLength];
            //System.Collections.Generic.List<int> mergedArray = new System.Collections.Generic.List<int>();

            var array1Item = array1[0];
            var array2Item = array2[0];
            var index = 0;
            var i = 0;
            var j = 0;

            while (index < newLength)
            {
                //if(!array2Item || array1Item < array2Item){
                if (array1Item <= array2Item && i < array1.Length || j == array2.Length)
                {
                    mergedArray[index] = array1Item;
                    Console.WriteLine("array1Item[{0}] = {1} -------", i, array1Item);

                    i++;
                    if (i < array1.Length)
                    {
                        array1Item = array1[i];
                    }
                }
                else
                {
                    mergedArray[index] = array2Item;
                    Console.WriteLine("array2Item[{0}] = {1}", j, array2Item);

                    j++;
                    if (j < array2.Length)
                    {
                        array2Item = array2[j];
                    }
                }

                Console.WriteLine(mergedArray[index]);

                index++;
            }

            Console.WriteLine(string.Join(",", mergedArray));
            return mergedArray;
        }
        #endregion

        #region [Merge Sorted Arrays LeetCode]
        /*
            https://leetcode.com/problems/merge-sorted-array/
            //MergeSortedArraysLeetCode(new int[] { 0, 3, 4, 31, 37, 39, 43, 48, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, }, 8, new int[] { 4, 6, 30, 32, 33, 34, 35, 38, 40, 41, 44, 46, 47 }, 13);
            //MergeSortedArraysLeetCode(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3);
        */
        static void MergeSortedArraysLeetCode(int[] nums1, int m, int[] nums2, int n) // 
        {

            if (m == 0)
            {
                nums2.CopyTo(nums1, 0);
                return;
            }

            if (n == 0)
            {
                return;
            }

            //int j = 0;
            //for (int i = m; i < nums1.Length; i++)
            //{
            //    nums1[i] = nums2[j++];
            //}
            //Array.Sort(nums1);

            int end1 = m - 1, end2 = n - 1;

            for (int i = nums1.Length - 1; i >= 0; i--)
            {
                if (end2 < 0)
                {
                    break;
                }

                if (end1 >= 0 && nums1[end1] >= nums2[end2])
                {
                    nums1[i] = nums1[end1--];
                }
                else
                {
                    nums1[i] = nums2[end2--];
                }
            }


        }
        #endregion


        #region [1. Two Sum - Brute Force C# Solution]
        #region [?]
        /* 1. Two Sum: https://leetcode.com/problems/two-sum/description/ */
        /*
            1. Two Sum
                Easy

            Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
            You may assume that each input would have exactly one solution, and you may not use the same element twice.
            You can return the answer in any order.

            Example 1:
                Input: nums = [2,7,11,15], target = 9
                Output: [0,1]
                Output: Because nums[0] + nums[1] == 9, we return [0, 1].

            Example 2:
                Input: nums = [3,2,4], target = 6
                Output: [1,2]

            Example 3:
                Input: nums = [3,3], target = 6
                Output: [0,1]

            Constraints:
                2 <= nums.length <= 104
                -109 <= nums[i] <= 109
                -109 <= target <= 109
                Only one valid answer exists.

            Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?
        */
        #endregion
        public static int[] TwoSum(int[] nums, int target) // No Good! Nested Loops! Time complexity O(n^2)
        {
            if (nums == null || nums.Length < 2)
            {
                return new int[2];
            }

            int[] output = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                for(int j = 1 + i; j < nums.Length; j++)
                {
                    if(nums[i] + nums[j] == target)
                    {
                        output[0] = i;
                        output[1] = j;
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(",", output));
            return output;
        }
        #endregion

        #region [1. Two Sum 2 the best & the fastest]
        /*
            Complexity:
                Time: O(N) where N is the number of intergers in the input array.
                We basically just need to traverse the input array one time. Dictioary.Add() and Dictioanry.ContainsKey() are both O(1) operation.

                Space: O(N) where N is the number of intergers in the input array.
                Dictonary stores at most n number of key-value pairs.

            Note:
                There are two ways to initialize an empty array in C#:
                    new int[size];
                    new int[]{};
        */

        public static int[] TwoSum2(int[] nums, int target) // Good! Time complexity O(n)
        {
            if (nums == null || nums.Length < 2)
            {
                return new int[2];
            }

            int[] output = new int[2]; // Ok int[] output = new int[] { };
            Dictionary<int, int> complementDictionary = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++) 
            {
                if (complementDictionary.ContainsKey(target - nums[i])) // checks if compliment is in complementDictionary
                {
                    //return new int[] { complementDictionary[target - nums[i]], i }; // ok
                    output[0] = complementDictionary[target - nums[i]]; // Or complementDictionary.Where(x => x.Key == nums[i]).FirstOrDefault().Value; 
                    output[1] = i;
                    break;
                }
                else if (!complementDictionary.ContainsKey(nums[i])) // handles duplicates KEYS -> nums[i]  in complementDictionary
                //else //x wrong
                {
                    complementDictionary.Add(nums[i], i);
                }               
            }

            //Console.WriteLine(string.Join(",", output));
            return output;
        }
        #endregion

        #region [1. Two Sum 3 NOT the best & the fastest]
        #region [?]
        /* 1. Two Sum: https://leetcode.com/problems/two-sum/description/ */
        /*
            1. Two Sum
                Easy

            Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
            You may assume that each input would have exactly one solution, and you may not use the same element twice.
            You can return the answer in any order.

            Example 1:
                Input: nums = [2,7,11,15], target = 9
                Output: [0,1]
                Output: Because nums[0] + nums[1] == 9, we return [0, 1].

            Example 2:
                Input: nums = [3,2,4], target = 6
                Output: [1,2]

            Example 3:
                Input: nums = [3,3], target = 6
                Output: [0,1]

            Constraints:
                2 <= nums.length <= 104
                -109 <= nums[i] <= 109
                -109 <= target <= 109
                Only one valid answer exists.

            Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?
        */
        #endregion
        public static int[] TwoSum3(int[] nums, int target) // No Good! Nested Loops! Time complexity O(n^2)
        {
            if (nums == null || nums.Length < 2)
            {
                return new int[2];
            }

            int[] output = new int[2]; // Ok int[] output = new int[] { };

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if(dict.ContainsValue(target - nums[i]))
                {
                    //return new int[] { i, dict[target - nums[i]]}; // ok
                    output[0] = dict.Where(x => x.Value == target - nums[i]).FirstOrDefault().Key;
                    output[1] = i;
                    break;  
                }
                else
                {
                    dict.Add(i, nums[i]);
                }
            }

            //Console.WriteLine(string.Join(",", output));
            return output; 
        }
        #endregion


        #region [53. Maximum Subarray]
        /* 53. Maximum Subarray: https://leetcode.com/problems/maximum-subarray/description/ */
        /*
            53. Maximum Subarray
                Easy

            Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.
            A subarray is a contiguous part of an array.

            Example 1:
                Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
                Output: 6
                Explanation: [4,-1,2,1] has the largest sum = 6.

            Example 2:
                Input: nums = [1]
                Output: 1

            Example 3:
                Input: nums = [5,4,-1,7,8]
                Output: 23

            Constraints:
                1 <= nums.length <= 3 * 104
                -105 <= nums[i] <= 105

            Follow up: If you have figured out the O(n) solution, try coding another solution using the divide and conquer approach, which is more subtle.
        */

        /*
            The main idea is to take only "useful" subarrays.
            Useful for max sum means positive. So when I get the sum less than zero - I drop it.
        */
        static int MaxSubArray(int[] nums) // O(n)
        {
            int sum = 0;
            int maxSum = nums[0];

            for (int i = 0; i < nums.Length; i++) 
            {
                sum = sum + nums[i];

                if(nums[i] > sum)
                {
                    sum = nums[i];
                }

                if(sum > maxSum)
                {
                    maxSum = sum;
                }
            }

            return maxSum;
        }
        #endregion

        #region [53. Maximum Subarray 2]
        static int MaxSubArray2(int[] nums) // O(n)
        {
            int sum = nums[0];
            int maxSum = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                sum = Math.Max(nums[i], sum + nums[i]);
                maxSum = Math.Max(sum, maxSum);
            }

            return maxSum;
        }
        #endregion

        #region [53. Maximum Subarray 3]
        static public int MaxSubArray3(int[] nums, int i = 0, int sum = 0) // x
        {
            if (i >= nums.Length) { return sum; }
              
            sum = sum > 0 ? sum + nums[i] : nums[i];

            int maxSum = Math.Max(sum, MaxSubArray3(nums, ++i, sum));
            return maxSum;
        }
        #endregion


        #region [283. Move Zeroes]
        /*
            283. Move Zeroes
                Easy

            Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
            Note that you must do this in-place without making a copy of the array.

            Example 1:
                Input: nums = [0,1,0,3,12]
                Output: [1,3,12,0,0]

            Example 2:
                Input: nums = [0]
                Output: [0]

            Constraints:
                1 <= nums.length <= 104
                -231 <= nums[i] <= 231 - 1

            Follow up: Could you minimize the total number of operations done?
        */
        static void MoveZeroes(int[] nums) // O(n^2)
        {
            int temp = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i; j < nums.Length - 1 - i; j++)
                {
                    if(nums[j] == 0)
                    {
                        temp = nums[j + 1];
                        nums[j + 1] = nums[j];
                        nums[j] = temp;
                    }
                }
            }

            Console.WriteLine(string.Join(", ", nums));
        }
        #endregion

        #region [283. Move Zeroes 2]
        static void MoveZeroes2(int[] nums) // 
        {
            int j = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[j++] = nums[i];
                }
            }

            while (j < nums.Length)
            {
                nums[j++] = 0;
            }

            //ArrayDS.Fill(nums, 0, j, nums.Length - j);

            Console.WriteLine(string.Join(", ", nums));
        }
        #endregion

        #region [283. Move Zeroes 3]
        /* Super simple c# one pointer implementation. One Loop, One if, and a swap. */
        // Time: O(n) where n represents a number of nums
        // Space: O(1) in-place solution - for constant
        static void MoveZeroes3(int[] nums) // O(n) where n represents a number of nums
        {
            int j = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    int temp = nums[j];
                    nums[j++] = nums[i];
                    nums[i] = temp; // could not just assign 0 to the next one as there are test cases for int[1] so that have to assign value from temp

                    // xxx
                    //nums[j++] = nums[i];
                    //nums[i] = 0; 
                }
            }

            Console.WriteLine(string.Join(", ", nums));
        }
        #endregion


        #region [217. Contains Duplicate]
        /*
            Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

            Example 1:
                Input: nums = [1,2,3,1]
                Output: true

            Example 2:
                Input: nums = [1,2,3,4]
                Output: false

            Example 3:
                Input: nums = [1,1,1,3,3,4,3,2,4,2]
                Output: true
        */
        static bool ContainsDuplicate(int[] nums)
        {
            //List<int> hashSet = new List<int>(); // Error: Time Limit Exceeded
            HashSet<int> hashSet = new HashSet<int>();

            foreach (int num in nums)
            {
                if (hashSet.Contains(num))
                {
                    return true;
                }

                hashSet.Add(num);
            }
            return false;

            //bool containsDuplicate = nums.Distinct().Count() < nums.Length;
            //return containsDuplicate;
        }
        #endregion

        #region [217. Contains Duplicate 2]
        static bool ContainsDuplicate2(int[] nums)
        {
            bool containsDuplicate = nums.Distinct().Count() < nums.Length;
            return containsDuplicate;
        }
        #endregion

        #region [217. Contains Duplicate 3]
        static bool ContainsDuplicate3(int[] nums)
        {
            HashSet<int> hashSet = new HashSet<int>();

            return nums.Any(x => !hashSet.Add(x));
        }
        #endregion


        #region [189. Rotate Array]
        #region [?]
        /* 189. Rotate Array: https://leetcode.com/problems/rotate-array/description/ */
        /*
            189. Rotate Array
                Medium

            Given an array, rotate the array to the right by k steps, where k is non-negative.

            Example 1:
                Input: nums = [1,2,3,4,5,6,7], k = 3
                Output: [5,6,7,1,2,3,4]
                Explanation:
                rotate 1 steps to the right: [7,1,2,3,4,5,6]
                rotate 2 steps to the right: [6,7,1,2,3,4,5]
                rotate 3 steps to the right: [5,6,7,1,2,3,4]

            Example 2:
                Input: nums = [-1,-100,3,99], k = 2
                Output: [3,99,-1,-100]
                Explanation: 
                rotate 1 steps to the right: [99,-1,-100,3]
                rotate 2 steps to the right: [3,99,-1,-100]

            Constraints:
                1 <= nums.length <= 105
                -231 <= nums[i] <= 231 - 1
                0 <= k <= 105

            Follow up:
                Try to come up with as many solutions as you can. There are at least three different ways to solve this problem.
                Could you do it in-place with O(1) extra space?

        */
        #endregion
        public static void Rotate(int[] nums, int k) // Brute force - Not working
        {
            // % =>  x - (x / y) * y; or  y - (y / x) * x;
            int x = nums.Length;
            int y = k;
            decimal xy = 0, yx = 0;
            //xy = x - (x / y) * y;
            //yx = y - (y / x) * x;

            //Rotate(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3);
            k = k % nums.Length;

            for (int i = nums.Length - 1; i >= nums.Length - k; i--)
            {
                int temp = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j >= 1; j--)
                {
                    nums[j] = nums[j - 1];
                }
                nums[0] = temp;
            }
            //return null;
        }
        #endregion

        #region [189. Rotate Array - 2]
        #region [?]
        /* 189. Rotate Array: https://leetcode.com/problems/rotate-array/description/ */
        /* [C#] easy rotation solution: https://leetcode.com/problems/rotate-array/discuss/703699/C-easy-rotation-solution */
        /*
        */
        #endregion
        public static void Rotate2(int[] nums, int k) // 
        {
            k %= nums.Length;
            Array.Reverse(nums, 0, nums.Length);
            Array.Reverse(nums, 0, k);
            Array.Reverse(nums, k, nums.Length - k);
            //return null;
        }
        #endregion

        #region [189. Rotate Array - 3]
        #region [?]
        /* 189. Rotate Array: https://leetcode.com/problems/rotate-array/description/ */
        /* C# using 3 rotations: https://leetcode.com/problems/rotate-array/discuss/1269753/C-using-3-rotations */
        /*
        */
        #endregion
        public static void Rotate3(int[] nums, int k) // 
        {
            //Rotate(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3);
            k = k % nums.Length;

            RotatePart(nums, 0, nums.Length - 1);
            RotatePart(nums, 0, k - 1);
            RotatePart(nums, k, nums.Length - 1);
            //return null;
        }

        public static void RotatePart(int[] nums, int start, int end)
        {
            while (start <= end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }
        #endregion

        #region [189. Rotate Array - 4]
        #region [?]
        /* 189. Rotate Array: https://leetcode.com/problems/rotate-array/description/ */
        /* C# solutions: https://leetcode.com/problems/rotate-array/discuss/253052/C-Solution */
        /*
        */
        #endregion
        public static void Rotate4(int[] nums, int k) // 
        {
            //Rotate(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3);

            // Solution 1 -- Time: O(n), Space: O(n)
            int[] output = new int[nums.Length];
            int length = nums.Length;

            for (int i = 0; i < nums.Length; i++)
            {
                output[(i + k) % length] = nums[i];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = output[i];
            }

            //return null;
        }
        #endregion


        #region [Longest Word]
        #region [?]
        /* 1. https://coderbyte.com/editor/Longest%20Word:Csharp */
        /*
            Longest Word

            Have the function LongestWord(sen) take the sen parameter being passed and return the longest word in the 
            string. If there are two or more words that are the same length, return the first word from the string with 
            that length. Ignore punctuation and assume sen will not be empty. Words may also contain numbers, for 
            example "Hello world123 567"

            Examples
                Input: "fun&!! time"
                Output: time

                Input: "I love dogs"
                Output: love
        */
        #endregion
        static string LongestWord(string sen) // "fun&!! time"
        {
            //char[] chrArray = sen.ToCharArray();

            string punctuations = "`~!@#$%^&*()-_=+{}[]|\\:;\"'<,>.?/";

            foreach (char chr in sen)
            {
                if(punctuations.Contains(chr))
                {
                    sen = sen.Replace(chr, ' ');
                }
            }

            string[] s = sen.Split(' ');
            string longestStr = s[0];

            for (int i = 1; i < s.Length; i++)
            {
                if(s[i].Length > longestStr.Length)
                {
                    longestStr = s[i];
                }
            }

            return longestStr;
        }
        #endregion


        #region []
        #region [?]
        /* 1.  */
        /*
 
        */
        #endregion
        static int[] xxxxxx() // 
        {

            return null;
        }
        #endregion

        #region []
        #region [?]
        /* 1.  */
        /*
 
        */
        #endregion
        static int[] xxxxxdddx() // 
        {

            return null;
        }
        #endregion

        #region []
        #region [?]
        /* 1.  */
        /*
 
        */
        #endregion
        static int[] xxeeeefxxxx() // 
        {

            return null;
        }
        #endregion

        #region []
        #region [?]
        /* 1.  */
        /*
 
        */
        #endregion
        static int[] xdddxxxxx() // 
        {

            return null;
        }
        #endregion

        #region []
        #region [?]
        /* 1.  */
        /*
 
        */
        #endregion
        static int[] xxxxxssx() // 
        {

            return null;
        }
        #endregion

        #region []
        #region [?]
        /* 1.  */
        /*
 
        */
        #endregion
        static int[] xxxeexxx() // 
        {

            return null;
        }
        #endregion

        #region []
        #region [?]
        /* 1.  */
        /*
 
        */
        #endregion
        static int[] xxxxddx() // 
        {

            return null;
        }
        #endregion

        #region []
        #region [?]
        /* 1.  */
        /*
 
        */
        #endregion
        static int[] xxxxxxxx() // 
        {

            return null;
        }
        #endregion

        #region []
        #region [?]
        /* 1.  */
        /*
 
        */
        #endregion
        static int[] xxxsssxxx() // 
        {

            return null;
        }
        #endregion



    }

}
