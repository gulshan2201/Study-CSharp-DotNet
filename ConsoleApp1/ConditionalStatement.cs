using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpSession
{
    internal class ConditionalStatement
    {
        static void Main(string[] args)
        {
            //WAP to increase the load amount on electricity bill
            //when consumption will be above 2500.load amount will be 5% of total bill?\
            // otherwise provide 50% discount on electricity bill.
            Console.WriteLine("Enter the Bill amount");
            float bill = int.Parse(Console.ReadLine());
            if (bill > 2500)
            {
                bill = bill + bill * 0.5f;
            }
            else {
                bill = bill / 2;
            }
            Console.WriteLine(bill);

            /*WAP to apply grace mark if entered mark is <33 and > 28.
otherwise print normal mark. and print also total applied grace mark in case of grace mark */
            Console.WriteLine("Enter the marks");
            int marks = int.Parse(Console.ReadLine()); ;
            if (marks >= 28 && marks < 33)
            { 
                Console.WriteLine("Grace marks",(33-marks));
                marks = marks+(33-marks);
            }
            Console.WriteLine(marks);
        }
    }
}
