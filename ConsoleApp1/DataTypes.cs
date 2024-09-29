using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpSession
{
    class DataTypes
    {
        static void Main(string[] args)
        {
            int a = 10;
            float b = 20.34F;
            double d = 2655456.78;
            char ch = 'a';
            string s = "Gulshan";
            String s1 = "123";
            object o = 12;

            Console.WriteLine("a={0}, b={1}, d={2}, ch={3}, s={4},s1={5},o={6}",a,b,d,ch,s,s1,o);

            Console.WriteLine(s + a);
            Console.WriteLine(Convert.ToInt32(s1) + a);

            object obj;
            int num = 1234;
            obj = num; //implicit conversion
            Console.WriteLine(obj);

            int num1;
            num1 = (int) obj; // explicit conversion

            Console.WriteLine(num1);
        }
        
    }
}
