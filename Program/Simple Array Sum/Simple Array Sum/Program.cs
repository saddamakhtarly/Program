using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Array_Sum
{
    class Program
    {
        static int simpleArraySum(int[] ar)
        {
            int temp = 0;
            foreach (var item in ar)
            {
                temp += item;
            }
            return temp;
        }
        static void Main(string[] args)
        {
            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = simpleArraySum(ar);
           
            
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
