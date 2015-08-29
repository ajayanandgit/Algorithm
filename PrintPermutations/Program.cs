using System;
using System.Collections.Generic;
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
            var temp = Fix(fileData);
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

            Console.ReadKey();
        }


    }
}
