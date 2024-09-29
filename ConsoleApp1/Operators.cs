using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpSession
{
    internal class Operators
    {
        static void Main(string[] args)
        {
            int a = 10; int b;
            b = a++;
            Console.WriteLine("a={0} and b={1}",a,b);
            int c = 20;
            int d;
            d = ++c;
            Console.WriteLine("c={0} and d={1}",c,d);
        }
    }
}
