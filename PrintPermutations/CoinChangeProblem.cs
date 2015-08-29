using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class CoinChangeProblem
    {
        // m is size of coins array (number of different coins)
        public static int MinCoins(int[] coins, int m, int givenValue)
        {
            // base case
            if (givenValue == 0) return 0;

            // Initialize result
            int res = int.MaxValue;

            // Try every coin that has smaller value than V
            for (int i = 0; i < m; i++)
            {
                if (coins[i] <= givenValue)
                {
                    int sub_res = MinCoins(coins, m, givenValue - coins[i]);

                    // Check for INT_MAX to avoid overflow and see if
                    // result can minimized
                    if (sub_res != int.MaxValue && sub_res + 1 < res)
                    {
                        res = sub_res + 1;
                    }
                }
            }

            return res;
        }

    }
}
