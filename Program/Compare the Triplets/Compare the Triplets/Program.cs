using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_the_Triplets
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();
            List<int> result = compareTriplets(a, b);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int aTotalScore = 0;
            int bTotalScore = 0;
            for (int i = 0; i < 3; i++)
            {
                int aScore = a[i];
                int bScore = b[i];
                if (aScore != bScore)
                {
                    int temp = aScore > bScore ? aTotalScore++ : bTotalScore++;
                }
            }
            List<int> result = new List<int>();
            result.Add(aTotalScore);
            result.Add(bTotalScore);
            return result;
        }
    }
}
