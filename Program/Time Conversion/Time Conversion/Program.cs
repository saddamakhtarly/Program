using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Conversion
{
    class Program
    {
        static string timeConversion(string time)
        {
            DateTime dateTime = DateTime.ParseExact(time, "hh:mm:sstt",
                            System.Globalization.CultureInfo.InvariantCulture);

            return dateTime.ToString("HH:mm:ss");
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string result = timeConversion(s);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
