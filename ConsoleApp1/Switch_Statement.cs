using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpSession
{
    internal class Switch_Statement
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 for C, 2 for C++, 3 for DSA");   
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice) { 
                case 1:
                    Console.WriteLine('C');
                    break;
                case 2:
                    Console.WriteLine("C++");
                    break;
                case 3:
                    Console.WriteLine("DSA");
                    break;
                default:
                    Console.WriteLine("Wrong Choice");
                    break;
            }
            Console.WriteLine("Enter the character");
            string ch = Console.ReadLine();
            switch (ch)
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    Console.WriteLine("vowel");
                    break;
                default:
                    Console.WriteLine("consonant");
                    break;
            }
        }
    }
}
