using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpSession
{
    internal class Loops
    {
        static void Main(string[] args)
        {
            //Write a program to calculate a table of any number using a complete expression?
            int num, i;
            Console.WriteLine("Enter the number to print table");
            num = int.Parse(Console.ReadLine());
            i=1;
            while(i <=10)
            {
                int temp = num * i;
                Console.WriteLine(temp);
                i++;
            }

        }
    }
}
