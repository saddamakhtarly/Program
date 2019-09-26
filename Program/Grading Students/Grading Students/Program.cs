using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grading_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Length of Array");
            int inp = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[inp];
            int i = 0;
            for (; i < arr.Length; i++)
            {
                Console.WriteLine($"Enter Value {i}");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            var outarr=gradingStudents(arr);
            foreach (var item in outarr)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
        static int[] gradingStudents(int[] grades)
        {
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i]>=38)
                {
                    int remainder = grades[i] % 5;
                    int least_multiple = grades[i] - remainder;
                    int upper_multiple = least_multiple+5;
                    int difference = upper_multiple - grades[i];
                    if (difference<3)
                    {
                        grades[i] = upper_multiple;
                    }
                }
            }
            return grades;
        }
    }
}
