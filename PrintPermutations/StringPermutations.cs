using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class StringPermutations
    {

        // Algorithm Paradigm: Backtracking
        // Time Complexity: O(n*n!)
        public StringPermutations()
        {
             // start program
            char[] str = "ABC".ToCharArray();
            int n = str.Length;
            permute(str, 0, n - 1);
        }

        public static void swap(char[] str, int x, int y)
        {
            char temp;
            temp = str[x];
            str[x] = str[y];
            str[y] = temp;
        }

        /* Function to print permutations of string
   This function takes three parameters:
   1. String
   2. Starting index of the string
   3. Ending index of the string. */
        public static void permute(char[] str, int s, int e)
        {
            int i;

            if (s == e)
            {
                Console.WriteLine("{0}", new string(str));
            }
            else
            {
                for (i = s; i <= e; i++)
                {
                    swap(str, s, i);
                    permute(str, s + 1, e);
                    swap(str, s, i);
                }
            }
        }
    }
}
