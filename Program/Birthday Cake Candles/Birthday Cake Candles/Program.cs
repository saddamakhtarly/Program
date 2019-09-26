using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday_Cake_Candles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Years");
            int inp =Convert.ToInt32( Console.ReadLine());

            int[] arr = new int[inp];
            int i = 0;
            for (; i < arr.Length; i++)
            {
                Console.WriteLine($"Enter Value {i}");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            int count = 0;
            int max = arr.Max();
            foreach (var item in arr)
            {
                if (item == max)
                    count++;
            }
            Console.WriteLine(count);
            Console.ReadLine();

        }
    }
}
