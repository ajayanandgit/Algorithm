using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class FindDistanceBetweenStringInArray
    {
        public int FindDis(String[] strArray, string a, string b)
        {
            if (strArray == null)
            {
                throw new ArgumentNullException("strArray");
            }

            if (strArray.Length <= 0)
            {
                throw new ArgumentException("strArray");
            }

            if (string.IsNullOrEmpty(a))
            {
                throw new ArgumentNullException("a");
            }

            if (string.IsNullOrEmpty(b))
            {
                throw new ArgumentNullException("b");
            }

            int minDis = int.MaxValue;
            int prev = -1;
            for (int index = 0; index < strArray.Length; index++)
            {
                if (strArray[index].Equals(a, StringComparison.OrdinalIgnoreCase) ||
                    strArray[index].Equals(b, StringComparison.OrdinalIgnoreCase))
                {
                    prev = index;
                    break;
                }
            }

            for (int index = prev; index < strArray.Length; index++)
            {
                if (strArray[index].Equals(a, StringComparison.OrdinalIgnoreCase) ||
                    strArray[index].Equals(b, StringComparison.OrdinalIgnoreCase))
                {
                    if (!strArray[prev].Equals(strArray[index], StringComparison.OrdinalIgnoreCase)
                        && (index - prev) < minDis)
                    {
                        minDis = index - prev;
                        prev = index;
                    }
                    else
                    {
                        prev = index;
                    }
                }

            }

            return minDis == int.MaxValue ? -1 : minDis;
        }
    }
}
