using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMinus
{
    class Program
    {
        static void plusMinus(int[] arr)
        {
            float positiveCounter = 0, negativeCounter = 0, zeroCounter = 0;
            float arrayLength = arr.Count();

            foreach (int num in arr)
            {
                if (num > 0)
                    positiveCounter++;
                else if (num < 0)
                    negativeCounter++;
                else
                    zeroCounter++;
            }

            Console.WriteLine(positiveCounter / arrayLength);
            Console.WriteLine(negativeCounter / arrayLength);
            Console.WriteLine(zeroCounter / arrayLength);
        }
        static void Main(string[] args)
        {
            #region Qasim Code
            //Console.WriteLine("Enter array length..");
            //int arrayLength = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter array..");
            //int[] array = new int[arrayLength];
            //decimal negative = 0;
            //decimal positive = 0;
            //decimal zero = 0;
            //for (int i = 0; i < arrayLength; i++)
            //{
            //    array[i] = Convert.ToInt32(Console.ReadLine());
            //    if (array[i] < 0)
            //    {
            //        negative = negative + 1;
            //    }
            //    else if (array[i] > 0)
            //    {
            //        positive = positive + 1;
            //    }
            //    else if (array[i] == 0)
            //    {
            //        zero = zero + 1;
            //    }
            //}
            //positive = Math.Round(positive / arrayLength, 5);
            //negative = Math.Round(negative / arrayLength, 5);
            //zero = Math.Round(zero / arrayLength, 5);
            //Console.WriteLine("A Decimal representing of the fraction of positive numbers : " + positive);
            //Console.WriteLine("A Decimal representing of the fraction of negative numbers : " + negative);
            //Console.WriteLine("A Decimal representing of the fraction of zero numbers : " + zero); 
            #endregion

            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            plusMinus(ar);
            Console.ReadKey();
        }
    }
}
