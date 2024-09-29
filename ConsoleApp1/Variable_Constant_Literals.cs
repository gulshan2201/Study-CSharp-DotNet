using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpSession
{
    internal class Variable_Constant_Literals
    {
        static int a = 300; //Memory allocation in stack, because this variable is static. 
        int b = 400; // dynamic variable, memory allocation in heap memory,
                     // because to access this variable we need to declare reference type that is object.
        static void Main(string[] args)
        {
            int x = 10;
            x = 20;
            Console.WriteLine(x);
            const int y = 30;
           // y = 20; cannot change value of y as this variable is constant.
            Console.WriteLine(y);
            Console.WriteLine(Variable_Constant_Literals.a);
            Variable_Constant_Literals obj = new Variable_Constant_Literals();
            Console.WriteLine(obj.b);

        }
    }
}
