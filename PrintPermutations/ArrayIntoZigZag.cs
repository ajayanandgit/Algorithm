using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class ArrayIntoZigZag
    {

        public static void Swap(int[] array, int p, int q)
        {
            int temp = array[p];
            array[p] = array[q];
            array[q] = temp;
        }

        // Program for zig-zag conversion of array
        public static void ZigZag(int[] arr)
        {
            // Flag true indicates relation "<" is expected,
            // else ">" is expected.  The first expected relation
            // is "<"
            bool flag = true;

            for (int i = 0; i <= arr.Length - 2; i++)
            {
                if (flag) /* "<" relation expected */
                {
                    /* If we have a situation like A > B > C,
               we get A > B < C by swapping B and C */
                    if (arr[i] > arr[i + 1])
                        Swap(arr, i, i + 1);
                }
                else /* ">" relation expected */
                {
                    /* If we have a situation like A < B < C,
               we get A < C > B by swapping B and C */
                    if (arr[i] < arr[i + 1])
                        Swap(arr, i, i + 1);
                }

                flag = !flag; /* flip flag */
            }
        }

    }
}
