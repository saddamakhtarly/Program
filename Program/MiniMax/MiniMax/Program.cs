using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMax
{
    class Program
    {
        static void miniMaxSum(int[] arr)
        {
            long result1 = 0;
            long result2 = 0;
            long max = arr.Max();
            long min = arr.Min();
            for (int i = 0; i < arr.Length; i++)
            {
                result1 += arr[i];
                result2 += arr[i];
            }
            Console.WriteLine("{0} {1}", result1 - max, result2 - min);

        }
        static void Main(string[] args)
        {

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
     ;
            miniMaxSum(arr);
            Console.ReadKey();
            
        }
    }
}
