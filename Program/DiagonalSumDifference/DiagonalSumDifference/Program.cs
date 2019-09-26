using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalSumDifference
{
    class Program
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            int ok1 = 0;
            int ok2 = 0;

            int j = arr[0].Count - 1;

            for (int i = 0; i < arr[0].Count; i++)
            {
                ok1 += arr[i][i];
                ok2 += arr[i][j];
                j--;
            }
            int ans = Math.Abs(ok1 - ok2);
            return ans;

        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = diagonalDifference(arr);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}

