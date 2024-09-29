using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpSession
{
    class Person
    {
        //field
        public string Name;
        public int Age; 

        //Method
        public void DisplayInfo()
        {
            Console.WriteLine($"Person's Name: {Name}, Person's Age: {Age}");
        }
    }

    // we can also define both class and object in diffrent file
    class OOPs
    {
        static void Main(string[] args)
        {
            //creating object of the person class
            Person person1 = new Person();

            //setting properties
            person1.Name = "Test";
            person1.Age = 10;

            //calling Method
            person1.DisplayInfo();

        }
    }
}
