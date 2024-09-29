using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpSession
{
    internal class Arrays
    {
        static void Main(string[] args)
        {
            /*int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 }; // static array
            Console.WriteLine(arr[arr.Length-1]+ " " +arr[0]); //last and first element
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("Enter the size of array :");
            int size = Convert.ToInt32(Console.ReadLine());
            int [] arr2 = new int[size];
            for (int i = 0;i < size; i++)
            {
                Console.WriteLine("Enter the elements of array :");
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }*/

            // find max element in array
            /*Console.WriteLine("Enter the size of array :");
            int size = Convert.ToInt32(Console.ReadLine());
            int [] arr = new int[size];
            int max = 0;
            for (int i = 0; i < size; i++) 
                arr[i] = Convert.ToInt32(Console.ReadLine());
            for (int i = 0;i < arr.Length; i++)
                if (arr[i] > max)
                    max = arr[i];
            Console.WriteLine("max element of array :"+max);*/

            // Triangle 

            /* Console.WriteLine("Enter the size of array");
             int size = Convert.ToInt32(Console.ReadLine());
             int[] angles = new int[size];
             int anglesum = 0;
             for (int i = 0; i < angles.Length; i++)
             { 
                 Console.WriteLine($"Enter the elements {i + 1}");
                 angles[i] = Convert.ToInt32(Console.ReadLine());
             }

             foreach (int angle in angles)
             {
                 anglesum += angle;

             }

             Console.WriteLine(anglesum == 180 ? "Valid" : "Invalid");*/

            /*if (anglesum == 180)
            {
                Console.WriteLine("Triangle");
            }
            else
            {
                Console.WriteLine("Not a Triangle");
            }*/

            // Multi-Dimensional array

            int[,] arr = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            for (int i = 0;i<arr.GetLength(0);i++)
            {
                for (int j = 0;j<arr.GetLength(1);j++)
                {
                    Console.Write(arr[i,j]);
                }
                Console.WriteLine(); // we neet to write this so we can get array in matrix form
            }

        }
    }
}
