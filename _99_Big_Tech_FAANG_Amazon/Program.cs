using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.IO;

namespace _99_Big_Tech_FAANG_Amazon
{
    class Program
    {
        static void Main(string[] args)
        {
            //SuggestedProducts(new string[] { "mobile", "mouse", "moneypot", "monitor", "mousepad" }, "mouse");
            //SuggestedProducts(new string[] { "bags", "baggage", "banner", "box", "cloths" }, "bags");
            //SuggestedProducts(new string[] { "havana" }, "havana");
            //SuggestedProducts(new string[] { "havana" }, "tatiana");

            //SuggestedProducts2(new string[] { "mobile", "mouse", "moneypot", "monitor", "mousepad" }, "mouse");
            //SuggestedProducts2(new string[] { "bags", "baggage", "banner", "box", "cloths" }, "bags");
            //SuggestedProducts2(new string[] { "havana" }, "havana");
            //SuggestedProducts2(new string[] { "havana" }, "tatiana");

            //SuggestedProducts3(new string[] { "mobile", "mouse", "moneypot", "monitor", "mousepad" }, "mouse");
            //SuggestedProducts3(new string[] { "bags", "baggage", "banner", "box", "cloths" }, "bags");
            //SuggestedProducts3(new string[] { "havana" }, "havana");
            //SuggestedProducts3(new string[] { "havana" }, "tatiana");

            //AmazonCustomerReviews(args);

            //AmazonFreshPromo(new List<string> { "apple apple", "banana anything banana" }, new List<string> { "orange", "apple", "apple", "banana", "orange", "banana" }); // -> 1
            //AmazonFreshPromo(new List<string> { "apple apple", "banana anything banana" }, new List<string> { "banana", "orange", "banana", "apple", "apple" }); // -> 0
            //AmazonFreshPromo(new List<string> { "apple apple", "banana anything banana" }, new List<string> { "apple", "banana", "apple", "banana", "orange", "banana" }); // -> 0
            //AmazonFreshPromo(new List<string> { "apple apple", "apple apple banana" }, new List<string> { "apple", "apple", "apple", "banana" }); // -> 0

            //AmazonFreshPromo2(new List<string> { "apple apple", "banana anything banana" }, new List<string> { "orange", "apple", "apple", "banana", "orange", "banana" }); // -> 1
            //AmazonFreshPromo2(new List<string> { "apple apple", "banana anything banana" }, new List<string> { "banana", "orange", "banana", "apple", "apple" }); // -> 0
            //AmazonFreshPromo2(new List<string> { "apple apple", "banana anything banana" }, new List<string> { "apple", "banana", "apple", "banana", "orange", "banana" }); // -> 0
            //AmazonFreshPromo2(new List<string> { "apple apple", "apple apple banana" }, new List<string> { "apple", "apple", "apple", "banana" }); // -> 0

            /* Amazon KClosest */
            //KClosest(new int[][] { new int[] { 1, 3 }, new int[] { -2, 2 } }, 1);
            //KClosest(new int[][] { new int[] { 3, 3 }, new int[] { 5, -1 }, new int[] { -2, 4 } }, 2);

            /* Amazon OptimalUtilizationSum */
            //OptimalUtilizationSum(
            //      new List<int[]> { new int[] { 1, 2 }, new int[] { 2, 4 }, new int[] { 3, 6 } }
            //    , new List<int[]> { new int[] { 1, 2 } }
            //    , 7);

            //OptimalUtilizationSum(
            //      new List<int[]> { new int[] { 1, 3 }, new int[] { 2, 5 }, new int[] { 3, 7 }, new int[] { 4, 10 } }
            //    , new List<int[]> { new int[] { 1, 2 }, new int[] { 2, 3 }, new int[] { 3, 4 }, new int[] { 4, 5 } }
            //    , 10);

            //OptimalUtilizationSum(
            //      new List<int[]> { new int[] { 1, 8 }, new int[] { 2, 7 }, new int[] { 3, 14 } }
            //    , new List<int[]> { new int[] { 1, 5 }, new int[] { 2, 10 }, new int[] { 3, 14 } }
            //    , 20);

            //OptimalUtilizationSum(
            //     new List<int[]> { new int[] { 1, 8 }, new int[] { 2, 15 }, new int[] { 3, 9 } }
            //   , new List<int[]> { new int[] { 1, 8 }, new int[] { 2, 11 }, new int[] { 3, 12 } }
            //   , 20);


            //SplitIntoTwo(new List<int> { 10, 4, -8, 7 }); // Output 2 
            //SplitIntoTwo(new List<int> { 10, -5, 6 }); // Output 1 

            //SplitIntoTwo2(new List<int> { 10, 4, -8, 7 }); // Output 2 
            //SplitIntoTwo2(new List<int> { 10, -5, 6 }); // Output 1 

            //SplitArrayIntoTwoEqualSumSubarrays(new int[] { 1, 2, 3, 4, 5, 5 }, 6); // Output : { 1 2 3 4 } - { 5 , 5 }
            //SplitArrayIntoTwoEqualSumSubarrays(new int[] { 4, 1, 2, 3 }, 4); // Output : {4 1} - { 2 3}
            //SplitArrayIntoTwoEqualSumSubarrays(new int[] { 4, 3, 2, 1 }, 4); // Output : Not Possible

            //DecodeString(2, "hlowrd_el_ol"); // Output: hello world
            //DecodeString(3, "mnes__ya_____mi"); // Output: my name is
            //DecodeString(3, "mnesi___ya__k____mime"); // Output: my name is mike

            NearestValidPoint(3, 4, new int[][] { new int[] { 1, 2 }, new int[] { 3, 1 }, new int[] { 2, 4 }, new int[] { 2, 3 }, new int[] { 4, 4 } }); // Output: 2
            NearestValidPoint(3, 4, new int[][] { new int[] { 3, 4 } }); // Output: 0
            NearestValidPoint(3, 4, new int[][] { new int[] { 2, 3 } }); // Output: -1

        }


        #region [1. ]
        #region [?]
        /* 1. Two Sum: https://leetcode.com/problems/two-sum/description/ */
        /*
           
        */
        #endregion
        #region [C#]
        /*

         */
        #endregion

        public static int[] ddxxddseeeexx(int[] nums, int target) // No Good! Nested Loops! Time complexity O(n^2)
        {

            return null;
        }
        #endregion


        #region [1. Search Suggestions System - LeetCode ]
        #region [?]
        /* 1268. Search Suggestions System - LeetCode: https://leetcode.com/problems/search-suggestions-system/ */
        /* Very Easy using Linq on C#: https://leetcode.com/problems/search-suggestions-system/discuss/436119/Very-Easy-using-Linq-on-C */
        /*
            1268. Search Suggestions System
            Medium

            Given an array of strings products and a string searchWord. We want to design a system that suggests at 
            most three product names from products after each character of searchWord is typed. Suggested products 
            should have common prefix with the searchWord. If there are more than three products with a common prefix 
            return the three lexicographically minimums products.

            Return list of lists of the suggested products after each character of searchWord is typed. 

            Example 1:
                Input: products = ["mobile","mouse","moneypot","monitor","mousepad"], searchWord = "mouse"
                Output: [
                ["mobile","moneypot","monitor"],
                ["mobile","moneypot","monitor"],
                ["mouse","mousepad"],
                ["mouse","mousepad"],
                ["mouse","mousepad"]
                ]
                Explanation: products sorted lexicographically = ["mobile","moneypot","monitor","mouse","mousepad"]
                After typing m and mo all products match and we show user ["mobile","moneypot","monitor"]
                After typing mou, mous and mouse the system suggests ["mouse","mousepad"]

            Example 2:
                Input: products = ["havana"], searchWord = "havana"
                Output: [["havana"],["havana"],["havana"],["havana"],["havana"],["havana"]]

            Example 3:
                Input: products = ["bags","baggage","banner","box","cloths"], searchWord = "bags"
                Output: [["baggage","bags","banner"],["baggage","bags","banner"],["baggage","bags"],["bags"]]

            Example 4:
                Input: products = ["havana"], searchWord = "tatiana"
                Output: [[],[],[],[],[],[],[]]

            Constraints:
                1 <= products.length <= 1000
                There are no repeated elements in products.
                1 <= Σ products[i].length <= 2 * 10^4
                All characters of products[i] are lower-case English letters.
                1 <= searchWord.length <= 1000
                All characters of searchWord are lower-case English letters.
        */
        #endregion
        public static IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
        {
            IList<IList<string>> searchSuggestionsList = new List<IList<string>>();

            // Sort Products
            Array.Sort(products);
            string searchByChar = "";

            foreach (char chr in searchWord)
            {
                searchByChar = searchByChar + chr;

                // For each letter, remove anything that doesn't still match from matches.
                // Each time will be O(matches.Length) first is products.Length and it will get smaller every time.
                products = products.Where(x => x.StartsWith(searchByChar)).ToArray();

                searchSuggestionsList.Add(products.Take(3).ToList());
            }

            return searchSuggestionsList;
        }
        #endregion

        #region [2. Search Suggestions System - LeetCode ]
        #region [?]
        /* 1268. Search Suggestions System - LeetCode: https://leetcode.com/problems/search-suggestions-system/ */
        /* Simple Sort and check string starts with increasing prefix of search term: https://leetcode.com/problems/search-suggestions-system/discuss/436290/Simple-Sort-and-check-string-starts-with-increasing-prefix-of-search-term */
        /*
            1268. Search Suggestions System
            Medium

            Given an array of strings products and a string searchWord. We want to design a system that suggests at 
            most three product names from products after each character of searchWord is typed. Suggested products 
            should have common prefix with the searchWord. If there are more than three products with a common prefix 
            return the three lexicographically minimums products.

            Return list of lists of the suggested products after each character of searchWord is typed. 

            Example 1:
                Input: products = ["mobile","mouse","moneypot","monitor","mousepad"], searchWord = "mouse"
                Output: [
                ["mobile","moneypot","monitor"],
                ["mobile","moneypot","monitor"],
                ["mouse","mousepad"],
                ["mouse","mousepad"],
                ["mouse","mousepad"]
                ]
                Explanation: products sorted lexicographically = ["mobile","moneypot","monitor","mouse","mousepad"]
                After typing m and mo all products match and we show user ["mobile","moneypot","monitor"]
                After typing mou, mous and mouse the system suggests ["mouse","mousepad"]

            Example 2:
                Input: products = ["havana"], searchWord = "havana"
                Output: [["havana"],["havana"],["havana"],["havana"],["havana"],["havana"]]

            Example 3:
                Input: products = ["bags","baggage","banner","box","cloths"], searchWord = "bags"
                Output: [["baggage","bags","banner"],["baggage","bags","banner"],["baggage","bags"],["bags"]]

            Example 4:
                Input: products = ["havana"], searchWord = "tatiana"
                Output: [[],[],[],[],[],[],[]]

            Constraints:
                1 <= products.length <= 1000
                There are no repeated elements in products.
                1 <= Σ products[i].length <= 2 * 10^4
                All characters of products[i] are lower-case English letters.
                1 <= searchWord.length <= 1000
                All characters of searchWord are lower-case English letters.
        */
        #endregion
        public static IList<IList<string>> SuggestedProducts2(string[] products, string searchWord)
        {
            IList<IList<string>> searchSuggestionsList = new List<IList<string>>();
            Array.Sort(products, StringComparer.Ordinal);  // Sort Products
            string searchByChar = "";

            foreach (char chr in searchWord)
            {
                searchByChar = searchByChar + chr;
                int count = 0;
                List<string> subResult = new List<string>();
                foreach (string p in products)
                {
                    if (p.StartsWith(searchByChar, StringComparison.Ordinal))
                    {
                        count++;
                        subResult.Add(p);
                    }

                    if (count == 3)
                    {
                        break;
                    }
                }

                searchSuggestionsList.Add(subResult);
            }

            return searchSuggestionsList;
        }
        #endregion

        #region [3. Search Suggestions System - LeetCode ]
        #region [?]
        /* 1268. Search Suggestions System - LeetCode: https://leetcode.com/problems/search-suggestions-system/ */
        /* C# solution - filter set: https://leetcode.com/problems/search-suggestions-system/discuss/556175/C-solution-filter-set */
        /*
            I'm surprised I didn't see a solution like this in the discussion even in other languages but I maybe didn't 
            look hard enough?

            A lot of people have solutions using binary search which does seem smart, and probably good for the first 
            search...
            But in all of these solutions, I see people doing the binary search at every new character without ever 
            reducing the input size... why?

            If you look at the problem, we aren't talking about pressing backspace or changing the search team entirely, 
            we are talking about adding characters one by one.
            This clearly means that in if the searchWord is mouse, first pass we look for matches where the first c
            haracter is "m".

            Second pass we look for matches where the first character is "m" and second is "o", but wait, we already 
            found all matches where the first character was "m" in the first pass. So why not remove everything that 
            didn't match from the possible matches at that time? Now we can simplify the problem in the second pass 
            to just be looking for words where the second character is "o"... removing all where its not... and so on, 
            the space of possible matches gets smaller every time.

            After the first pass, the advantage of binary search gets much smaller, or at least if we are talking huge 
            data sets and we are going to binary search, shouldn't we still eliminate the non-matches at each phase?
        */
        /*
            1268. Search Suggestions System
            Medium

            Given an array of strings products and a string searchWord. We want to design a system that suggests at 
            most three product names from products after each character of searchWord is typed. Suggested products 
            should have common prefix with the searchWord. If there are more than three products with a common prefix 
            return the three lexicographically minimums products.

            Return list of lists of the suggested products after each character of searchWord is typed. 

            Example 1:
                Input: products = ["mobile","mouse","moneypot","monitor","mousepad"], searchWord = "mouse"
                Output: [
                ["mobile","moneypot","monitor"],
                ["mobile","moneypot","monitor"],
                ["mouse","mousepad"],
                ["mouse","mousepad"],
                ["mouse","mousepad"]
                ]
                Explanation: products sorted lexicographically = ["mobile","moneypot","monitor","mouse","mousepad"]
                After typing m and mo all products match and we show user ["mobile","moneypot","monitor"]
                After typing mou, mous and mouse the system suggests ["mouse","mousepad"]

            Example 2:
                Input: products = ["havana"], searchWord = "havana"
                Output: [["havana"],["havana"],["havana"],["havana"],["havana"],["havana"]]

            Example 3:
                Input: products = ["bags","baggage","banner","box","cloths"], searchWord = "bags"
                Output: [["baggage","bags","banner"],["baggage","bags","banner"],["baggage","bags"],["bags"]]

            Example 4:
                Input: products = ["havana"], searchWord = "tatiana"
                Output: [[],[],[],[],[],[],[]]

            Constraints:
                1 <= products.length <= 1000
                There are no repeated elements in products.
                1 <= Σ products[i].length <= 2 * 10^4
                All characters of products[i] are lower-case English letters.
                1 <= searchWord.length <= 1000
                All characters of searchWord are lower-case English letters.
        */
        #endregion
        public static IList<IList<string>> SuggestedProducts3(string[] products, string searchWord)
        {
            // Sort Products
            Array.Sort(products);

            IList<IList<string>> searchSuggestionsList = new List<IList<string>>();

            // Copy matches into list, easier to maintain
            List<string> matches = products.ToList();

            for (int i = 0; i < searchWord.Length; i++)
            {
                // For each letter, remove anything that doesn't still match from matches.
                // Each time will be O(matches.Length) first is products.Length and it will get smaller every time.
                filterProducts(i, searchWord[i], matches);

                List<string> topMatches = new List<string>();
                for (int j = 0; j < 3 && j < matches.Count; j++)
                {
                    topMatches.Add(matches[j]);
                }

                searchSuggestionsList.Add(topMatches);
            }

            return searchSuggestionsList;
        }

        private static void filterProducts(int index, char c, List<string> products)
        {
            // Iterate backwards to remove
            for (int i = products.Count - 1; i >= 0; i--)
            {
                if (products[i].Length < (index + 1) || products[i][index] != c)
                {
                    products.RemoveAt(i);
                }
            }
        }
        #endregion


        #region [1. Amazon Customer Reviews (example question) - Ashraf  --> Search Suggestions System - LeetCode ]
        #region [?]
        /* 1. Amazon Customer Reviews (example question): https://leetcode.com/discuss/interview-question/850261/amazon-customer-reviews-question */
        /* Amazon Customer Reviews Question - LeetCode: https://leetcode.com/discuss/interview-question/850261/amazon-customer-reviews-question */
        /* 1268. Search Suggestions System - LeetCode:  https://leetcode.com/problems/search-suggestions-system/ */
        /*
            1. Amazon Customer Reviews (example question)
            Amazon is building a way to help customers search reviews quicker by providing real-time suggestions to search 
            terms when the customer starts typing. When given a minimum of two characters into the search field the system 
            will suggest at most three keywords from the review word repository. As the customer continues to type in the 
            reviews search bar the relevant keyword suggestions will update automatically.
 
            Write an algorithm that will output a maximum of three keyword suggestions after each character is typed by the 
            customer in the search field.
 
            If there are more than three acceptable keywords, return the keywords that are first in alphabetical order.
            Only return keyword suggestions after the customer has entered two characters.
            Keyword suggestions must start with the characters already typed
            Both the repository and the customerQuery should be compared in a case-insensitive way.
 
            Input
            The input to the method/function consists of two arguments:
            repository, a list of unique strings representing the various keywords from the Amazon review comment section;
            customerQuery, a string representing the full search query of the customer.
 
            Output
            Return a list of a list of strings in lower case, where each list represents the keyword suggestions made by the 
            system as the customer types each character of the customerQuery. Assume the customer types characters in order 
            without deleting or removing any characters. If an output is not possible, return an empty array ([]).
 
            Example
            Input:
            repository = [ "mobile", "mouse", "moneypot", "monitor", "mousepad" ]
            customerQuery = "mouse"
 
            Output:
            ["mobile", "moneypot", "monitor"]
            ["mouse", "mousepad"]
            ["mouse", "mousepad"]
            ["mouse", "mousepad"]
 
            Explanation:
            The chain of words that will generate in the search box will be
            mo, mou, mous, mouse
            and each line from output shows the suggestion of "mo", "mou", "mous", "mouse", respectively in each line.
            For the keyword suggestions made by the system that are generated for 'mo', the matches that will be generated are:["mobile", "mouse", "moneypot", "monitor", "mousepad"]
            Alphabetically, they will be to [ "mobile", "moneypot", "monitor", "mouse", "mousepad" ].
            Thus the by are [ "mobile", "moneypot", "monitor"].

            Input (stdin) 
            •	5
            •	bags
            •	baggage
            •	banner
            •	box
            •	cloths
            •	bags
            Your Output (stdout) 
            •	
            Expected Output 
            •	baggage bags banner
            •	baggage bags
            •	bags
        */
        #endregion
        #region [C#]
        /*
            using System.CodeDom.Compiler;
            using System.Collections.Generic;
            using System.Collections;
            using System.ComponentModel;
            using System.Diagnostics.CodeAnalysis;
            using System.Globalization;
            using System.IO;
            using System.Linq;
            using System.Reflection;
            using System.Runtime.Serialization;
            using System.Text.RegularExpressions;
            using System.Text;
            using System;

            class Result
            {
                * Complete the 'searchSuggestions' function below.
                *
                * The function is expected to return a 2D_STRING_ARRAY.
                * The function accepts following parameters:
                *  1. STRING_ARRAY repository
                *  2. STRING customerQuery
     
                public static List<List<string>> searchSuggestions(List<string> repository, string customerQuery)
                {
                    List<List<string>> searchSuggestions_ = new List<List<string>>();
                    return searchSuggestions_;
                }
            }

            class Solution
            {
                public static void Main(string[] args)
                {
                    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

                    int repositoryCount = Convert.ToInt32(Console.ReadLine().Trim());

                    List<string> repository = new List<string>();

                    for (int i = 0; i < repositoryCount; i++)
                    {
                        string repositoryItem = Console.ReadLine();
                        repository.Add(repositoryItem);
                    }

                    string customerQuery = Console.ReadLine();

                    List<List<string>> result = Result.searchSuggestions(repository, customerQuery);

                    textWriter.WriteLine(String.Join("\n", result.Select(x => String.Join(" ", x))));

                    textWriter.Flush();
                    textWriter.Close();
                }
            }

         */
        #endregion

        class Result
        {
            //* Complete the 'searchSuggestions' function below.
            //*
            //* The function is expected to return a 2D_STRING_ARRAY.
            //* The function accepts following parameters:
            //*  1. STRING_ARRAY repository
            //*  2. STRING customerQuery

            public static List<List<string>> searchSuggestions(List<string> repository, string customerQuery) //Amazon
            {
                List<string> products = repository; // amazon
                string searchWord = customerQuery; // amazon

                List<List<string>> searchSuggestionsList = new List<List<string>>();

                // Sort Products
                //Array.Sort(products);
                string searchByChar = "";

                foreach (char chr in searchWord)
                {
                    searchByChar = searchByChar + chr;

                    // For each letter, remove anything that doesn't still match from matches.
                    // Each time will be O(matches.Length) first is products.Length and it will get smaller every time.
                    products = products.Where(x => x.StartsWith(searchByChar)).ToList();

                    searchSuggestionsList.Add(products.Take(3).ToList());
                }

                return searchSuggestionsList;
            }
        }

        //public static void Main(string[] args)
        public static void AmazonCustomerReviews(string[] args) // Ash
        {
            //TextWriter textWriter = new StreamWriter("D:\\OUTPUT_PATH.txt"); Ash
            Environment.SetEnvironmentVariable("OUTPUT_PATH", "D:\\OUTPUT_PATH.txt"); // Ash
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int repositoryCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> repository = new List<string>();
            repository.AddRange(new string[] { "mobile", "mouse", "moneypot", "monitor", "mousepad" }); //Ash
            //repository.AddRange(new string[] { "bags", "baggage", "banner", "box", "cloths" }); //Ash
            //repository.AddRange(new string[] { "havana" }); //Ash

            //for (int i = 0; i < repositoryCount; i++)
            //{
            //    string repositoryItem = Console.ReadLine();
            //    repository.Add(repositoryItem);
            //}

            //string customerQuery = Console.ReadLine();
            string customerQuery =  // Console.ReadLine(); //Ash
            "mouse";
            //"bags";
            //"havana";
            //"tatiana";

            List<List<string>> result = Result.searchSuggestions(repository, customerQuery);

            textWriter.WriteLine(String.Join("\n", result.Select(x => String.Join(" ", x))));

            textWriter.Flush();
            textWriter.Close();

            //return null;
        }
        #endregion


        #region [2. Amazon Fresh Promo (example question) - Ashraf -->  - LeetCode ]
        #region [?]
        /* 1. Amazon Customer Reviews (example question): https://leetcode.com/discuss/interview-question/850261/amazon-customer-reviews-question */
        /* Amazon | OA 2021 | Fresh Promotion- LeetCode: https://leetcode.com/discuss/interview-question/1002811/Amazon-or-OA-20201-or-Fresh-Promotion */
        /*  - LeetCode:  */
        /*
            3. Amazon Fresh Promo (example question)
            Amazon Fresh is running a promotion in which customers receive prizes for purchasing a secret combination of 
            fruits. The combination will change each day, and the team running the promotion wants to use a code list to 
            make it easy to change the combination. The code list contains groups of fruits. Both the order of the groups 
            within the code list and the order of the fruits within the groups matter. However, between the groups of 
            fruits, any number, and type of fruit is allowable. The term “anything” is used to allow for any type of 
            fruit to appear in that location within the group.
 
            Consider the following secret code list: [[apple, apple], [banana, anything, banana]]

            Based on the above secret code list, a customer who made either of the following purchases would win the prize: 
            orange, apple, apple, banana, orange, banana
            apple, apple, orange, orange, banana, apple, banana, banana
 
            Write an algorithm to output 1 if the customer is a winner else output 0.
 
            Input
            The input to the function/method consists of two arguments:
            codeList, a string array of space-separated values representing the order and grouping of specific fruits that 
            must be purchased in order to win the prize for the day.
            shoppingCart, a list representing the order in which a customer purchases fruit.
 
            Output
            Return an integer 1 if the customer is a winner else return 0.
 
            Note
            ‘anything’ in the codeList represents that any fruit can be ordered in place of ‘anything’ in the group.
            ‘anything’ has to be something, it cannot be “nothing.”
            ‘anything’ must represent one and only one fruit.
            If secret code list is empty then it is assumed that the customer is a winner.
 
            Examples
            Example 1:

            Input:
            codeList =
            [[apple, apple],
             [banana, anything, banana]]
            shoppingCart =
            [orange, apple, apple, banana, orange, banana]
 
            Output: 
            1
 
            Explanation:
            codeList contains two groups - [apple, apple] and [banana, anything, banana].
            The second group contains ‘anything’ so any fruit can be ordered in place of ‘anything’ in the shoppingCart.
            The customer is a winner as the customer has added fruits in the order of fruits in the groups and the order 
            of groups in the codeList is also maintained in the shoppingCart.
 
            Example 2:
            Input:
            codeList =
            [[apple, apple],
             [banana, anything, banana]]
            shoppingCart =
            [banana, orange, banana, apple, apple]
 
            Output: 
            0
 
            Explanation:
            The customer is not a winner as the customer has added the fruits in order of groups but 
            group [banana, orange, banana] is not following the group [apple, apple] in the codeList.
 
            Example3:
            Input:
            codeList = 
            [[apple, apple],
            [banana, anything, banana]]
            shoppingCart= 
            [apple, banana, apple, banana, orange, banana]
 
            Output: 
            0
 
            Explanation:
            The customer is not a winner as the customer has added the fruits in an order which is not following the 
            order of fruit names in the first group.

            Example4:
            Input:
            codeList = 
            [[apple, apple],
            [apple, apple, banana]]
            shoppingCart= 
            [apple, apple, apple, banana]
 
            Output:
            0
 
            Explanation:
            The customer is not a winner as the first 2 fruits form group 1, all three fruits would form group 2, but 
            can't because it would contain all fruits of group 1.

            Input (stdin) 
            •	4
            •	orange
            •	apple apple
            •	banana orange apple
            •	banana
            •	7
            •	orange
            •	apple
            •	apple
            •	banana
            •	orange
            •	apple
            •	banana
            Your Output (stdout) 
            •	1
            Expected Output 
            •	1

        */
        #endregion
        #region [C#]
        /*
            using System.CodeDom.Compiler;
            using System.Collections.Generic;
            using System.Collections;
            using System.ComponentModel;
            using System.Diagnostics.CodeAnalysis;
            using System.Globalization;
            using System.IO;
            using System.Linq;
            using System.Reflection;
            using System.Runtime.Serialization;
            using System.Text.RegularExpressions;
            using System.Text;
            using System;

            class Result
            {
                // * Complete the 'foo' function below.
                // *
                // * The function is expected to return an INTEGER.
                // * The function accepts following parameters:
                // *  1. STRING_ARRAY codeList
                // *  2. STRING_ARRAY shoppingCart

                public static int foo(List<string> codeList, List<string> shoppingCart)
                {
                    return 1;
                }
            }

            class Solution
            {
                public static void Main(string[] args)
                {
                    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

                    int codeListCount = Convert.ToInt32(Console.ReadLine().Trim());

                    List<string> codeList = new List<string>();

                    for (int i = 0; i < codeListCount; i++)
                    {
                        string codeListItem = Console.ReadLine();
                        codeList.Add(codeListItem);
                    }

                    int shoppingCartCount = Convert.ToInt32(Console.ReadLine().Trim());

                    List<string> shoppingCart = new List<string>();

                    for (int i = 0; i < shoppingCartCount; i++)
                    {
                        string shoppingCartItem = Console.ReadLine();
                        shoppingCart.Add(shoppingCartItem);
                    }

                    int result = Result.foo(codeList, shoppingCart);

                    textWriter.WriteLine(result);

                    textWriter.Flush();
                    textWriter.Close();
                }
            }
        */
        #endregion

        //* Complete the 'searchSuggestions' function below.
        //*
        //* The function is expected to return a 2D_STRING_ARRAY.
        //* The function accepts following parameters:
        //*  1. STRING_ARRAY repository
        //*  2. STRING customerQuery

        //( { "apple apple", "banana anything banana" }, { "orange", "apple", "apple", "banana", "orange", "banana" });
        public static int AmazonFreshPromo(List<string> codeList, List<string> shoppingCart)
        {
            if (shoppingCart == null || shoppingCart.Count == 0) return 0;
            if (codeList == null || codeList.Count == 0) return 1;

            string totalSubList = "";
            string subList1 = "";
            string subList2 = "";

            List<string> subList = new List<string>();

            foreach (string code in codeList)
            {
                if (code.Contains("anything"))
                {
                    //foreach (string item in code.Split(' '))
                    //{
                    //    if(item != "anything")
                    //    {
                    //        subList.Add(item.Trim());
                    //    }
                    //}

                    subList1 = code.Substring(0, code.IndexOf("anything")).Trim();
                    subList2 = code.Substring(code.IndexOf("anything"), code.Length - 7).Replace("anything", " ").Trim();

                    totalSubList = totalSubList + " " + subList1;
                }
                else
                {
                    totalSubList = totalSubList + " " + code;
                }
            }

            string shoppingCartStr = string.Join(" ", shoppingCart);

            if (shoppingCartStr.Contains(totalSubList.Trim()))
            {
                string[] shoppingCartArray = shoppingCartStr.Replace(totalSubList.Trim(), "_found_").Trim().Split(' ');

                for (int i = 0; i < shoppingCartArray.Length; i++)
                {
                    if (i + 2 < shoppingCartArray.Length && shoppingCartArray[i] == "_found_" && shoppingCartArray[i + 2] == subList2)
                    {
                        return 1;
                    }
                }

            }

            return 0;
        }
        #endregion

        #region [2. Amazon Fresh Promo (example question) - Ashraf 2 -->  - LeetCode ]
        #region [?]
        /* 1. Amazon Customer Reviews (example question): https://leetcode.com/discuss/interview-question/850261/amazon-customer-reviews-question */
        /* Amazon | OA 2021 | Fresh Promotion- LeetCode: https://leetcode.com/discuss/interview-question/1002811/Amazon-or-OA-20201-or-Fresh-Promotion */
        /*  - LeetCode:  */
        /*
         
        */
        #endregion
        #region [C#]
        /*
           
        */
        #endregion

        //( { "apple apple", "banana anything banana" }, { "orange", "apple", "apple", "banana", "orange", "banana" });
        public static int AmazonFreshPromo2(List<string> codeList_, List<string> shoppingCart_)
        {

            return 0;
        }
        #endregion


        #region [973. K Closest Points to Origin - Amazon  ]
        #region [?]
        /* 973. K Closest Points to Origin: https://leetcode.com/problems/k-closest-points-to-origin/ */
        /*
            973. K Closest Points to Origin
            Medium

            Given an array of points where points[i] = [xi, yi] represents a point on the X-Y plane and an integer k, 
            return the k closest points to the origin (0, 0).

            The distance between two points on the X-Y plane is the Euclidean distance (i.e., √(x1 - x2)2 + (y1 - y2)2).

            You may return the answer in any order. The answer is guaranteed to be unique (except for the order that it 
            is in).

            Example 1:
                Input: points = [[1,3],[-2,2]], k = 1
                Output: [[-2,2]]
                Explanation:
                The distance between (1, 3) and the origin is sqrt(10).
                The distance between (-2, 2) and the origin is sqrt(8).
                Since sqrt(8) < sqrt(10), (-2, 2) is closer to the origin.
                We only want the closest k = 1 points from the origin, so the answer is just [[-2,2]].

            Example 2:
                Input: points = [[3,3],[5,-1],[-2,4]], k = 2
                Output: [[3,3],[-2,4]]
                Explanation: The answer [[-2,4],[3,3]] would also be accepted.

            Constraints:
                1 <= k <= points.length <= 104
                -104 < xi, yi < 104
        */
        #endregion
        // vector<vector<int>> kClosest(vector<vector<int>> points, int k) // C++
        //public static List<List<int>> kClosest(List<List<int>> points, int k)
        public static int[][] KClosest(int[][] points, int k)  // Time complexity 
        {
            // Time Complexity : O(NLogN) // Maybe not sure
            // Space Compelxity : O(N)  // Maybe

            int[][] kClosestArraies = new int[k][];
            int x0 = 0, y0 = 0;
            Dictionary<int, double> dict = new Dictionary<int, double>();

            for (int i = 0; i < points.Length; i++)
            {
                int x = points[i][0];
                int y = points[i][1];

                //Math.Sqrt((x1 - x2)^2 + (y1 - y2)^2);
                double sqrt = Math.Sqrt(Math.Pow((x - x0), 2) + Math.Pow((y - y0), 2));
                //double dd = Math.Pow((x - x0), 2) + Math.Pow((y - y0), 2);
                //double sqrt1 = Math.Sqrt(10);
                //double sqrt2 = Math.Sqrt(8);
                dict.Add(i, sqrt);
            }

            List<KeyValuePair<int, double>> dictList = dict.OrderBy(x => x.Value).Take(k).ToList();

            for (int i = 0; i < dictList.Count; i++)
            {
                kClosestArraies[i] = points[dictList[i].Key];
            }

            return kClosestArraies; // Runtime: 767 ms, faster than 15.06% of C# online submissions for K Closest Points to Origin.

            // => points.OrderBy(p => p[0] * p[0] + p[1] * p[1]).Take(K).ToArray(); // no return;
            //return kClosestArraies = points.OrderBy(p => p[0] * p[0] + p[1] * p[1]).Take(k).ToArray(); // Runtime: 424 ms, faster than 85.07% of C# online submissions for K Closest Points to Origin.
            return kClosestArraies = points.OrderBy(point => Math.Sqrt(Math.Pow((point[0] - x0), 2) + Math.Pow((point[1] - y0), 2))).Take(k).ToArray();

            #region [Very simple one liner, explaination: ]
            /*
                https://leetcode.com/problems/k-closest-points-to-origin/discuss/723446/C-one-liner-with-comments
                Very simple one liner, explaination:

                OrderBy(x => ((x[0] * x[0]) + (x[1] * x[1]))):

                A simple formula ot get an approximation of the distance is Square root of: X ^ 2 + Y ^ 2, for this example we don't need the square root, just the result do the sum of the squares, these ones will result in a distance, like this:
                    (2, -2) => 2 * 2 + -2 * -2 => 4 * 4 => 8
    
                    This result will be used by the lambda function to sort the array, the result is the original array as an ISortedEnumerable.If the further points were required a simple.OrderByDescending will do.

                  Take(K)
  

                  This will take the requested amount of items out of the list.

                  ToArray()

                We have an ISortedIEnumerable, we need an array, so we make it an array.

                public class Solution
                {
                    public int[][] KClosest(int[][] points, int K) => points.OrderBy(x => ((x[0] * x[0]) + (x[1] * x[1]))).Take(K).ToArray();
                }

                That's it, this solution was better than 80% in speed and better than 7X% in storage.
                c#

                //====
                I found it was notably faster (~440ms vs ~680ms) to use a method for the distance calculation. It is no pivot sort, but it is always fun to get LINQ involved.

                public class Solution {
                    public int[][] KClosest(int[][] points, int K) 
                    {
                        return points.OrderBy(Distance).Take(K).ToArray();
                    }
    
                    private int Distance(int[] point)
                    {
                        return point[0] * point[0] + point[1] * point[1];
                    }
                }
                //==
                  
            //==  
                // public int[][] KClosest(int[][] points, int K)=> points.OrderBy(i=>i.Select(i=>i *i).Sum()).Take(K).ToArray();                     
            //==

            //==
                https://leetcode.com/problems/k-closest-points-to-origin/discuss/710226/C-solution-using-priority-queue
                For this task passes tests simple one-liner:

                public int[][] KClosest(int[][] points, int K) =>
                        points.OrderBy(p => p[0] * p[0] + p[1] * p[1]).Take(K).ToArray();

                It's time complexity is O(N Log N)
                where N is poins.Length.

                But this task is actually about Heap / PriorityQue which is not implemented in C#.

                Using Heap time complexity is O(N Log K).
                So it Is better if we need only 10 points from millions as we run through array only once.

                    public int[][] KClosest(int[][] points, int K) {
                        var pq = new Heap<int[]>(
			                (one, two) => Distance(one).CompareTo(Distance(two)),
			                K + 1
		                );

		                foreach (var point in points) {
                            pq.Add(point);
                            if (pq.Count > K) pq.DeleteMax();
                        }
                        return pq.ToArray();
                    }
	
                    private static int Distance(int[] p) => p[0] * p[0] + p[1] * p[1];

                Heap implementation is something like this:

                public class Heap<T> : IEnumerable<T> {
                    private readonly Func<T,T,int> comparer;
                    private readonly List<T> list;

                    public Heap(Func<T,T,int> comparer, int capacity = -1) {
                        this.comparer = comparer;
                        list = new List<T>(capacity + 1) {default};
                    }

                    private int Last => list.Count - 1;
                    public int Count => list.Count - 1;

                    public IEnumerator<T> GetEnumerator() => list.Skip(1).GetEnumerator();
                    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

                    public void Add(T value) {
                        list.Add(value);
                        Swim(Last);
                    }

                    public T DeleteMax() {
                        var max = list[1];
                        Swap(1, Last);
                        list.RemoveAt(Last);
                        Sink(1);
                        return max;
                    }

                    private void Swim(int node) {
                        while (node > 1 && Less(Parent(node), node)) {
                            Swap(Parent(node), node);
                            node = Parent(node);
                        }
                    }

                    private void Sink(int root) {
                        while (Left(root) <= Last) {
                            var child = Left(root);
                            if (child < Last && Less(child, child + 1)) child++;
                            if (!Less(root, child)) break;
            
                            Swap(root, child);
                            root = child;
                        }
                    }

                    private static int Parent(int index) => index >> 1;
                    private int Left(int index) => index << 1;
                    private bool Less(int one, int two) => comparer(list[one], list[two]) < 0;

                    private void Swap(int one, int two) {
                        var acc = list[one];
                        list[one] = list[two];
                        list[two] = acc;
                    }
                }

                // based on Java heap implementation from Robert Sedgewick's Algorithms course.
                heapc#
            //==


            */
            #endregion

        }
        #endregion


        #region [1779. Find Nearest Point That Has the Same X or Y Coordinate - Viagogo - LeetCode ]
        #region [?]
        /* 1779. Find Nearest Point That Has the Same X or Y Coordinate: https://leetcode.com/problems/find-nearest-point-that-has-the-same-x-or-y-coordinate/ */
        /*
            1779. Find Nearest Point That Has the Same X or Y Coordinate
                Easy

            You are given two integers, x and y, which represent your current location on a Cartesian grid: (x, y). You 
            are also given an array points where each points[i] = [ai, bi] represents that a point exists at (ai, bi). 
            A point is valid if it shares the same x-coordinate or the same y-coordinate as your location.

            Return the index (0-indexed) of the valid point with the smallest Manhattan distance from your current location. 
            If there are multiple, return the valid point with the smallest index. If there are no valid points, return -1.

            The Manhattan distance between two points (x1, y1) and (x2, y2) is abs(x1 - x2) + abs(y1 - y2).

            Example 1:
                Input: x = 3, y = 4, points = [[1,2],[3,1],[2,4],[2,3],[4,4]]
                Output: 2
                Explanation: Of all the points, only [3,1], [2,4] and [4,4] are valid. Of the valid points, [2,4] and [4,4] have the smallest Manhattan distance from your current location, with a distance of 1. [2,4] has the smallest index, so return 2.

            Example 2:
                Input: x = 3, y = 4, points = [[3,4]]
                Output: 0
                Explanation: The answer is allowed to be on the same location as your current location.

            Example 3:
                Input: x = 3, y = 4, points = [[2,3]]
                Output: -1
                Explanation: There are no valid points.

            Constraints:
                1 <= points.length <= 104
                points[i].length == 2
                1 <= x, y, ai, bi <= 104
        */
        #endregion

        // Input: x = 3, y = 4, points = [[1,2],[3,1],[2,4],[2,3],[4,4]] // 2
        public static int NearestValidPoint(int x, int y, int[][] points) // Time complexity 
        {
            int nearestValidPoint = -1;

            int nearest = int.MaxValue;
            for (int i = 0; i < points.Length; i++)
            {
                if(points[i][0] == x || points[i][1] == y)
                {
                    int current = (Math.Abs(x - points[i][0]) + Math.Abs(y - points[i][1]));

                    if(current < nearest)
                    {
                        nearest = current;
                        nearestValidPoint = i;
                        break;
                    }
                }
            }

            return nearestValidPoint;

            //int[][] pointArr = (from p in points
            //                    where p[0] == x || p[1] == y
            //                    orderby (Math.Abs(x - p[0]) + Math.Abs(y - p[1]))
            //                    select p).ToArray();

            //if (pointArr != null && pointArr.Length > 0)
            //{
            //    for (int i = 0; i < points.Length; i++)
            //    {
            //        if(points[i][0] == pointArr[0][0] && points[i][1] == pointArr[0][1])
            //        {
            //            NearestValidPoint = i;
            //            break;
            //        }
            //    }
            //}

            //return nearestValidPoint;
        }
        #endregion

        
        #region [OptimalSum: Amazon | OA 2019 | Optimal Utilization]
        #region [?]
        /* Amazon | OA 2019 | Optimal Utilization: https://leetcode.com/discuss/interview-question/373202 */
        /* derive from simpler problem: https://leetcode.com/problems/two-sum-less-than-k/ The difference is with OA we use 2 pointers technique for 2 sorted array */
        /*
            Given 2 lists a and b. Each element is a pair of integers where the first integer represents 
            the unique id and the second integer represents a value. Your task is to find an element 
            from a and an element form b such that the sum of their values is less or equal to target 
            and as close to target as possible. Return a list of ids of selected elements. If no pair 
            is possible, return an empty list.

            Example 1:
                Input:
                a = [[1, 2], [2, 4], [3, 6]]
                b = [[1, 2]]
                target = 7

                Output: [[2, 1]]

            Explanation:
                There are only three combinations [1, 1], [2, 1], and [3, 1], which have a total sum 
                of 4, 6 and 8, respectively.
                Since 6 is the largest sum that does not exceed 7, [2, 1] is the optimal pair.

            Example 2:
                Input:
                a = [[1, 3], [2, 5], [3, 7], [4, 10]]
                b = [[1, 2], [2, 3], [3, 4], [4, 5]]
                target = 10

                Output: [[2, 4], [3, 2]]

            Explanation:
                There are two pairs possible. Element with id = 2 from the list `a` has a value 5, and 
                element with id = 4 from the list `b` also has a value 5.
                Combined, they add up to 10. Similarily, element with id = 3 from `a` has a value 7, and 
                element with id = 2 from `b` has a value 3.
                These also add up to 10. Therefore, the optimal pairs are [2, 4] and [3, 2].

            Example 3:
                Input:
                a = [[1, 8], [2, 7], [3, 14]]
                b = [[1, 5], [2, 10], [3, 14]]
                target = 20

                Output: [[3, 1]]

            Example 4:
                Input:
                a = [[1, 8], [2, 15], [3, 9]]
                b = [[1, 8], [2, 11], [3, 12]]
                target = 20

                Output: [[1, 3], [3, 2]]

        */
        #endregion
        // public static int[][] OptimalSum(int[][] points, int k) // Arrays of Arrays
        // vector<vector<int>> optimalSum(vector<vector<int>> V1, vector<vector<int>> V2, int k) // C++
        //public static List<List<int>> OptimalSum(List<List<int>> V1, List<List<int>> V2, int k)
        public static List<int[]> OptimalUtilizationSum(List<int[]> a, List<int[]> b, int target)
        {
            List<int[]> OptimaSumList = new List<int[]>();

            if (a == null || a.Count == 0 || b == null || b.Count == 0)
            {
                return OptimaSumList;
            }

            OptimaSumList = (from aa in a
                                from bb in b
                                where aa[1] + bb[1] == target // || aa[1] + bb[1] < target
                             orderby (aa[1] + bb[1]) descending
                             select new int[] { aa[0], bb[0] }).ToList();

            if(OptimaSumList.Count == 0)
            {
                OptimaSumList = (from aa in a
                                    from bb in b
                                    where  aa[1] + bb[1] < target // aa[1] + bb[1] == target // ||
                                 orderby (aa[1] + bb[1]) descending
                                 select new int[] { aa[0], bb[0] }).Take(1).ToList();
            }

            return OptimaSumList;
        }

        #region[sort + binary search ? assuming no duplicates:]
        // https://leetcode.com/discuss/interview-question/373202
        public List<Tuple<int, int>> Closest(List<Tuple<int, int>> l1, List<Tuple<int, int>> l2, int target)
        {
            if (l1 == null || l2 == null || l1.Count == 0 || l2.Count == 0)
            {
                return new List<Tuple<int, int>>();
            }

            l1.Sort((x, y) => x.Item2.CompareTo(y.Item2));
            l2.Sort((x, y) => x.Item2.CompareTo(y.Item2));

            List<Tuple<int, int>> result = new List<Tuple<int, int>>();
            int diff = Int32.MaxValue;

            foreach (var pair in l1)
            {
                int find = this.Find(l2, target - pair.Item2);
                if (find != -1)
                {
                    int newDiff = target - pair.Item2 - l2[find].Item2;
                    if (diff == newDiff)
                    {
                        result.Add(new Tuple<int, int>(pair.Item1, l2[find].Item1));
                    }
                    else if (diff > newDiff)
                    {
                        diff = newDiff;
                        result = new List<Tuple<int, int>>();
                        result.Add(new Tuple<int, int>(pair.Item1, l2[find].Item1));
                    }
                }
            }

            return result;
        }

        // find index whose value is smaller cloest to target
        private int Find(List<Tuple<int, int>> l2, int target)
        {
            int low = 0, high = l2.Count - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (l2[mid].Item2 > target)
                {
                    high = mid - 1;
                }
                else if (l2[mid].Item2 == target)
                {
                    return mid;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return high;
        }
        #endregion

        #endregion


        #region [1. Split Array Into Two (Amazon Real Test) - Ashraf]
        #region [?]
        /* Split Array Into Two: https://leetcode.com/discuss/interview-experience/1316685/Amazon-OA-SDE1-(new-questions) */
        /*
            1. Code Question 1
            You recently inherited a new dataset and have been asked, by one of your Amazon colleagues, to split the data 
            in various ways. Here is your task: Given an array of integers, determine the number of ways the entire array 
            be split into two non-empty subarrays, left and right, such that the sum of elements in the left subarray is 
            greater than the sum of elements in the right subarray.
 
            Example
                arr =  [10, 4, -8, 7]
 
            There are three ways to split it into two non-empty subarrays:
                1.	[10] and [4, -8, 7], left sum = 10, right sum = 3 
                2.	[10, 4] and [-8, 7], left sum = 10 + 4 = 14, right sum = -8 + 7 = -1 
                3.	[10, 4, -8] and [7], left sum = 6, right sum = 7 
 
                The first two satisfy the condition that left sum > right sum, so the return value should be 2.
 
            Function Description 
                Complete the function splitIntoTwo in the editor below. The function must return a single integer.
 
            splitIntoTwo has the following parameter(s):
                int arr[n]: integer array
   
            Constraints
                •	2 ≤ n ≤ 105
                •	-104 ≤ arr[i] ≤ 104
 
            Input Format Format for Custom Testing Sample Case 0 
            Sample Input
                STDIN    Function
                -----    --------
                3     →  arr[] size n = 3
                10    →  arr = [10, -5, 6]
                -5
                6
 
            Sample Output
                1
 
            Explanation
                There are two ways to split the array: [10], [-5,6] with sums 10 and 1, sum left > sum right, a
                nd [10, -5], [6] with sums 5 and 6, sum left < sum right.
 
            Sample Case 1
        */
        #endregion
        #region [C#]
        /*
            using System.CodeDom.Compiler;
            using System.Collections.Generic;
            using System.Collections;
            using System.ComponentModel;
            using System.Diagnostics.CodeAnalysis;
            using System.Globalization;
            using System.IO;
            using System.Linq;
            using System.Reflection;
            using System.Runtime.Serialization;
            using System.Text.RegularExpressions;
            using System.Text;
            using System;

            class Result
            {
                * Complete the 'splitIntoTwo' function below.
                *
                * The function is expected to return an INTEGER.
                * The function accepts INTEGER_ARRAY arr as parameter.
     
                public static int splitIntoTwo(List<int> arr)
                {

                }

            }

            class Solution
            {
                public static void Main(string[] args)
                {
                    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

                    int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

                    List<int> arr = new List<int>();

                    for (int i = 0; i < arrCount; i++)
                    {
                        int arrItem = Convert.ToInt32(Console.ReadLine().Trim());
                        arr.Add(arrItem);
                    }

                    int result = Result.splitIntoTwo(arr);

                    textWriter.WriteLine(result);

                    textWriter.Flush();
                    textWriter.Close();
                }
            }
         */
        #endregion

        public static int SplitIntoTwo(List<int> arr)
        {
            int leftSum = 0;
            int rightSum = 0;
            int[] arr2 = arr.ToArray();
            int count = 0;

            for (int i = 0; i < arr2.Length -1 ; i++)
            {
                leftSum = leftSum + arr2[i];

                for (int j = arr2.Length - 1; j > 1 + i; j--)
                {
                    rightSum = rightSum + arr2[j];
                }

                if (leftSum > rightSum)
                {
                    count++;
                }
            }

            return count;
        }
        #endregion

        #region [1. Split Array Into Two (Amazon Real Test) - Ashraf - 2]
        #region [?]
        /* Split Array Into Two: https://leetcode.com/discuss/interview-experience/1316685/Amazon-OA-SDE1-(new-questions) */
        /*
            1. Code Question 1
            You recently inherited a new dataset and have been asked, by one of your Amazon colleagues, to split the data 
            in various ways. Here is your task: Given an array of integers, determine the number of ways the entire array 
            be split into two non-empty subarrays, left and right, such that the sum of elements in the left subarray is 
            greater than the sum of elements in the right subarray.
 
            Example
                arr =  [10, 4, -8, 7]
 
            There are three ways to split it into two non-empty subarrays:
                1.	[10] and [4, -8, 7], left sum = 10, right sum = 3 
                2.	[10, 4] and [-8, 7], left sum = 10 + 4 = 14, right sum = -8 + 7 = -1 
                3.	[10, 4, -8] and [7], left sum = 6, right sum = 7 
 
                The first two satisfy the condition that left sum > right sum, so the return value should be 2.
 
            Function Description 
                Complete the function splitIntoTwo in the editor below. The function must return a single integer.
 
            splitIntoTwo has the following parameter(s):
                int arr[n]: integer array
   
            Constraints
                •	2 ≤ n ≤ 105
                •	-104 ≤ arr[i] ≤ 104
 
            Input Format Format for Custom Testing Sample Case 0 
            Sample Input
                STDIN    Function
                -----    --------
                3     →  arr[] size n = 3
                10    →  arr = [10, -5, 6]
                -5
                6
 
            Sample Output
                1
 
            Explanation
                There are two ways to split the array: [10], [-5,6] with sums 10 and 1, sum left > sum right, a
                nd [10, -5], [6] with sums 5 and 6, sum left < sum right.
 
            Sample Case 1
        */
        #endregion
        #region [C#]
        /*
            using System.CodeDom.Compiler;
            using System.Collections.Generic;
            using System.Collections;
            using System.ComponentModel;
            using System.Diagnostics.CodeAnalysis;
            using System.Globalization;
            using System.IO;
            using System.Linq;
            using System.Reflection;
            using System.Runtime.Serialization;
            using System.Text.RegularExpressions;
            using System.Text;
            using System;

            class Result
            {
                * Complete the 'splitIntoTwo' function below.
                *
                * The function is expected to return an INTEGER.
                * The function accepts INTEGER_ARRAY arr as parameter.
     
                public static int splitIntoTwo(List<int> arr)
                {

                }

            }

            class Solution
            {
                public static void Main(string[] args)
                {
                    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

                    int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

                    List<int> arr = new List<int>();

                    for (int i = 0; i < arrCount; i++)
                    {
                        int arrItem = Convert.ToInt32(Console.ReadLine().Trim());
                        arr.Add(arrItem);
                    }

                    int result = Result.splitIntoTwo(arr);

                    textWriter.WriteLine(result);

                    textWriter.Flush();
                    textWriter.Close();
                }
            }
         */
        #endregion

        public static int SplitIntoTwo2(List<int> arr)
        {
            if (arr.Count == 0) return 0;

            int leftSum = 0;
            int rightSum = 0;
            int[] arr2 = arr.ToArray();
            int count = 0;

            for (int i = 0; i < arr2.Length; i++)
            {
                leftSum = leftSum + arr2[i];
            }

            for (int j = arr2.Length - 1; j > 0; j--)
            {
                rightSum = rightSum + arr2[j];
                leftSum = leftSum - rightSum;

                if (rightSum < leftSum && (rightSum != 0 && leftSum != 0))
                {
                    count++;
                }
            }

            return count;
        }
        #endregion


        #region [1. Split an array into two equal Sum subarrays (Facebook Real Test) - GeeksforGeeks]
        #region [?]
        /* 1. Split an array into two equal Sum subarrays: https://www.geeksforgeeks.org/split-array-two-equal-sum-subarrays/ */
        /*
           Split an array into two equal Sum subarrays

                Difficulty Level : Easy
                Last Updated : 20 May, 2021

            Given an array of integers greater than zero, find if it is possible to split it in two subarrays (without 
            reordering the elements), such that the sum of the two subarrays is the same. Print the two subarrays.
            
            Examples : 
                 Input : Arr[] = { 1 , 2 , 3 , 4 , 5 , 5  }
                Output :  { 1 2 3 4 } 
                          { 5 , 5 }

                Input : Arr[] = { 4, 1, 2, 3 }
                Output : {4 1}
                         {2 3}

                Input : Arr[] = { 4, 3, 2, 1}
                Output : Not Possible

            Asked In : Facebook interview 
 
            Recommended: Please try your approach on {IDE} first, before moving on to the solution. 
            https://ide.geeksforgeeks.org/

            A Simple solution is to run two loop to split array and check it is possible to split array into two parts such that sum of first_part equal to sum of second_part. 
            Below is the implementation of above idea. 
        */
        #endregion
        #region [C#]
        /*

         */
        #endregion

        // Returns split point. If
        // not possible, then return -1.
        public static int SplitArrayIntoTwoEqualSumSubarrays(int[] arr, int n) // Asked In : Facebook interview
        {
            if (arr.Length == 0) return 0;

            int leftSum = 0;
            int rightSum = 0;
            int[] arr2 = arr.ToArray();
            int splitPoint = -1;

            for (int i = 0; i < arr2.Length; i++)
            {
                leftSum = leftSum + arr2[i];
            }

            for (int j = arr2.Length - 1; j > 0; j--)
            {
                rightSum = rightSum + arr2[j]; // add current element to right_sum
                leftSum = leftSum - arr2[j]; // exclude current element to the left_sum

                if (leftSum == rightSum && (rightSum != 0 && leftSum != 0))
                {
                    splitPoint = j;
                    PrintOut(arr2, splitPoint);
                    break;
                }
            }

           
            if(splitPoint == -1)
            {
                Console.WriteLine("Not Possible");
            }

            return splitPoint;
        }

        static void PrintOut(int[] arr2, int splitPoint)
        {
            int[] leftOutPut = new int[splitPoint];
            int i = 0;
            while (i < leftOutPut.Length)
            {
                leftOutPut[i] = arr2[i];
                i++;
            }

            Console.WriteLine("{{ {0} }}", string.Join(", ", leftOutPut));

            int[] rightOutPut = new int[arr2.Length - splitPoint];
            int j = 0;
            while (j < rightOutPut.Length)
            {
                rightOutPut[j] = arr2[splitPoint];
                j++;
                splitPoint++;
            }

            Console.WriteLine("{{ {0} }}", string.Join(", ", rightOutPut));
        }
        #endregion


        #region [2. Decode the input string into original string (Amazon Real Test) - Ashraf]
        #region [?]
        /* Decode the input string into original string: https://leetcode.com/discuss/interview-question/1317796/amazon-oa-2021-hackerrank*/
        /* 
           3. Code Question 2
            Amazon Web Services is looking to create a simple encoding system to be used as part of an onboarding 
            orientation challenge. They have asked for your help in testing out the encoder. A string is to be encoded 
            using a slanted transposition cipher that uses the integer numberOfRows in the encoding process. Decode the 
            string and return the decoded string.
 
            Example
                a string = ''my name is'
                numberOfRows = 3
 
            To encode the string, start at the top left and fill in on the diagonal toward the right until reaching 
            specified number of rows. After reaching the bottom row, begin again at the next position in the top row. 
            Repeat until the entire string has been encoded, then concatenate the rows, replacing all blanks with 
            underscores, '_'. Decoding is the reverse.

            In the image, the given string my name is is encoded as 'mnes__ya_____mi'. Implement the decoding algorithm and return the decoded string.
 
            Given the number of rows used and the encoded string, find and return the required output string.
 
            Notes: 
                1. The number of rows is always less than the length of the original encoded string. Any trailing spaces 
                can be ignored. The final output is read row-wise. 
                2. Spaces are converted to underscored during encoding. Your code should handle the reverse operation 
                during decoding.
  
            Function Description
            Complete the decodeString function in the editor below.
 
            decodeString has the following parameter(s):
                int numberOfRows: the number of rows used in the encoding process
                string encodedString: the encoded string
 
            Returns:
                string: the decoded string
 
            Constraints
            •	1 ≤ numberOfRows ≤ 2 × 103
            •	1 ≤ size of encodedString ≤ 2 × 106 
            •	'a' ≤ encodedString[i] ≤ 'z' or encodedString[i] = '_' , where 0 ≤ i < size of encodedString  
            •	The length of the encoded string is always a multiple of the number of rows.
            Input Format For Custom Testing 
            Input from stdin will be processed as follows and passed to the function.
 
            The first line contains an integer, numberOfRows.
            The next line contains a string, encodedString.

            Sample Case 0 
                Sample Input
                    STDIN          Function
                    -----          -----
                    2            → numberOfRows = 2
                    hlowrd_el_ol → encodedString = 'hlowrd_el_ol'
 
                Sample Output
                    hello world
 
            Explanation
                After decoding the given encodedString, return the decoded string, 'hello world'.
 
            Sample Case 1 
                Sample Input
                    STDIN             Function
                    -----             -----
                    3               → numberOfRows = 3
                    mnes__ya_____mi → encodedString = 'mnes__ya_____mi'
 
                Sample Output
                    my name is
 
            Explanation
                Refer the image given in the problem statement. After decoding the given encodedString, return the decoded 
                string 'my name is'. 
        */

        /*
            Decode the input string into original string.

             You are given an encoded string  and number of rows, Convert it to original string
  
             Input: mnesi___ya__k____mime  N = 3
  
             Output : my name is mike

             Explanation : Read the matrix in a diagonal way starting from [0][0] index until the end of row and start from the top
             again to decode it. _ are treated as space.
 
             m n e s i _ _
             _ y a _ _ k _
             _ _ _ m i m e

        */
        #endregion
        #region [C#]
        /*
            using System.CodeDom.Compiler;
            using System.Collections.Generic;
            using System.Collections;
            using System.ComponentModel;
            using System.Diagnostics.CodeAnalysis;
            using System.Globalization;
            using System.IO;
            using System.Linq;
            using System.Reflection;
            using System.Runtime.Serialization;
            using System.Text.RegularExpressions;
            using System.Text;
            using System;

            class Result
            {
                 * Complete the 'decodeString' function below.
                 *
                 * The function is expected to return a STRING.
                 * The function accepts following parameters:
                 *  1. INTEGER numberOfRows
                 *  2. STRING encodedString

                public static string decodeString(int numberOfRows, string encodedString)
                {

                }
            }

            class Solution
            {
                public static void Main(string[] args)
                {
                    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

                    int numberOfRows = Convert.ToInt32(Console.ReadLine().Trim());

                    string encodedString = Console.ReadLine();

                    string result = Result.decodeString(numberOfRows, encodedString);

                    textWriter.WriteLine(result);

                    textWriter.Flush();
                    textWriter.Close();
                }
            }
         */
        #endregion

        // "mnesi___ya__k____mime"); // Output: my name is mike
        public static string DecodeString(int numberOfRows, string encodedString)
        {
            string dcodedString = "";
            char[] charArr = encodedString.Replace('_', ' ').ToCharArray();
            char[][] matrix = new char[numberOfRows][];

            int n = 0;
            for (int i = 0; i < numberOfRows; i++)
            {
                matrix[i] = new char[charArr.Length / numberOfRows];
                for (int j = 0 ; j < charArr.Length / numberOfRows; j++)
                {
                    matrix[i][j] = charArr[j + n];
                }

                n = n + charArr.Length / numberOfRows;
            }

            for (int i = 0; i < charArr.Length / numberOfRows; i++)
            {
                for (int j = 0; j < numberOfRows; j++)
                {
                    if (j + i < charArr.Length / numberOfRows)
                    {
                        dcodedString = dcodedString + matrix[j][j + i];
                    }
                }
            }

            return dcodedString.Trim(); ;
        }
        #endregion


        #region [1. Find the minimum length of the roof that covers K cars.]
        #region [?]
        /* 1. Find the minimum length of the roof that covers K cars: https://leetcode.com/discuss/interview-question/1317796/amazon-oa-2021-hackerrank */
        /*
           
        */
        #endregion
        #region [C#]
        /*

         */
        #endregion

        public static int[] xxeeeeeexx(int[] nums, int target) // No Good! Nested Loops! Time complexity O(n^2)
        {

            return null;
        }
        #endregion


        #region [1. ]
        #region [?]
        /* 1. Two Sum: https://leetcode.com/problems/two-sum/description/ */
        /*
           
        */
        #endregion
        #region [C#]
        /*

         */
        #endregion

        public static int[] xxsseeeexx(int[] nums, int target) // No Good! Nested Loops! Time complexity O(n^2)
        {

            return null;
        }
        #endregion

        #region [1. ]
        #region [?]
        /* 1. Two Sum: https://leetcode.com/problems/two-sum/description/ */
        /*
           
        */
        #endregion
        #region [C#]
        /*

         */
        #endregion

        public static int[] ddxxeeeexx(int[] nums, int target) // No Good! Nested Loops! Time complexity O(n^2)
        {

            return null;
        }
        #endregion

        #region [1. ]
        #region [?]
        /* 1. Two Sum: https://leetcode.com/problems/two-sum/description/ */
        /*
           
        */
        #endregion
        #region [C#]
        /*

         */
        #endregion

        public static int[] ddxasqsxeeeexx(int[] nums, int target) // No Good! Nested Loops! Time complexity O(n^2)
        {

            return null;
        }
        #endregion

        #region [1. ]
        #region [?]
        /* 1. Two Sum: https://leetcode.com/problems/two-sum/description/ */
        /*
           
        */
        #endregion
        #region [C#]
        /*

         */
        #endregion

        public static int[] ddxxeeasaseexx(int[] nums, int target) // No Good! Nested Loops! Time complexity O(n^2)
        {

            return null;
        }
        #endregion

        #region [1. ]
        #region [?]
        /* 1. Two Sum: https://leetcode.com/problems/two-sum/description/ */
        /*
           
        */
        #endregion
        #region [C#]
        /*

         */
        #endregion

        public static int[] ddxxeqsdeeexx(int[] nums, int target) // No Good! Nested Loops! Time complexity O(n^2)
        {

            return null;
        }
        #endregion

        #region [1. ]
        #region [?]
        /* 1. Two Sum: https://leetcode.com/problems/two-sum/description/ */
        /*
           
        */
        #endregion
        #region [C#]
        /*

         */
        #endregion

        public static int[] ddxcsdxeeeexx(int[] nums, int target) // No Good! Nested Loops! Time complexity O(n^2)
        {

            return null;
        }
        #endregion

        #region [1. ]
        #region [?]
        /* 1. Two Sum: https://leetcode.com/problems/two-sum/description/ */
        /*
           
        */
        #endregion
        #region [C#]
        /*

         */
        #endregion

        public static int[] ddxxeeaxsxaseexx(int[] nums, int target) // No Good! Nested Loops! Time complexity O(n^2)
        {

            return null;
        }
        #endregion

        #region [1. ]
        #region [?]
        /* 1. Two Sum: https://leetcode.com/problems/two-sum/description/ */
        /*
           
        */
        #endregion
        #region [C#]
        /*

         */
        #endregion

        public static int[] ddxscscxeeeexx(int[] nums, int target) // No Good! Nested Loops! Time complexity O(n^2)
        {

            return null;
        }
        #endregion

    }
}