using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpSession
{
    internal class Swap
    {
        static void Main()
        { 
            int a = 10; int b = 20; int temp = 0;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Swaaped number is a={0} and b={1}", a, b);
        }
    }
}
