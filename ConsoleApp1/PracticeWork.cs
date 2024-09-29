using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*calculate simple interest
 calculate compound interest
 calculate area of triangle and circle
 convert celcius to forienghight*/
namespace MyCSharpSession
{
    internal class PracticeWork
    {
        static void Main(string[] args)
        {
            double p = Convert.ToDouble(Console.ReadLine());
            int t = Convert.ToInt32(Console.ReadLine());
            double r = Convert.ToDouble(Console.ReadLine());
            double si = p*t*r/100;
            double totalAmount = si + p;
            Console.WriteLine($"Simple Interest : {si}");
            Console.WriteLine($"Total Amounts :{ totalAmount}");
            Console.ReadLine();

        }
    }
}
