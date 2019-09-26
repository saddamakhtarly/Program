using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Very_Big_Sum
{
    class Program
    {
        static long aVeryBigSum(int n, long[] ar)
        {
            Int64 total = 0;

            for (int i = 0; i < n; i++)
            {
                total += ar[i];
            }
            return total;


        }
        static void Main(string[] args)
        {
            int arCount = Convert.ToInt32(Console.ReadLine());

            long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp))
            ;
            long result = aVeryBigSum(arCount, ar);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
