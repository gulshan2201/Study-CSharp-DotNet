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
        // Learning github
        public string Name;
        public int Age;
        public long Salary;

        //Method
        public void DisplayInfo()
        {
            Console.WriteLine($"Person's Name: {Name}, Person's Age: {Age}, Person's Salary: {Salary}");
            
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
            person1.Salary = 200000;

            //calling Method
            person1.DisplayInfo();

        }
    }
}
