using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {

            // var fileData = "wlfr2r09032!#$%^*())___+{}:?><~";

            var fileData = File.ReadAllText(@"C:\Ajay - Imp\test.txt");
            // var temp = Fix(fileData);
            byte[] bytes = Encoding.UTF8.GetBytes(fileData);
            var tt = bytes.Aggregate(string.Empty, (current, t) => current + (char)t);


            string[] strArray = new string[] { "xyz", "xyz", "sss", "pqr", "pqr", "abc", "def", "ooo" };
            //, "pqr", "xyz"};
            int dis = MinDistanceBetweenString.FindDis(strArray, "xyz", "pqr");

            // zig zag array 
            int[] arr = { 4, 3, 7, 8, 6, 2, 1 };
            ArrayIntoZigZag.ZigZag(arr);

            // 
            int[] coins = { 9, 6, 5, 1 };
            int m = coins.Length;
            int V = 11;
            var minCoin = CoinChangeProblem.MinCoins(coins, m, V);
            int tets  = solvePuzzle(640);
            Console.ReadKey();
        }

        static int solvePuzzle(int num)
        {
            // check input
            if (0 > num || num > Math.Pow(10, 9)) throw new ArgumentException("num");
            int countHole = 0;
            while(num > 0)
            {
                int rem = num%10;
                switch (rem)
                {
                    case 4:
                    case 6:
                    case 9:
                    case 0:
                        countHole++;
                        break;
                    case 8:
                        countHole += 2;
                        break;
                }

                num = num/10;
            }

            return countHole;
        }


    }
}
