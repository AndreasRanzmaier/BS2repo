//11.09 Andreas Ranzmaier
using System;
using System.Dynamic;

namespace _04Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //1D
            Console.WriteLine("1D Array");
            int length1D_1 = 0;
            Console.WriteLine("länge:");
            length1D_1 = Convert.ToInt32(Console.ReadLine());

            int[] arr1D = new int[length1D_1];

            for (int i = 0; i < arr1D.Length; i++)
            {
                Console.WriteLine("Input arr1D an Stelle" + (i+1));
                arr1D[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var item in arr1D)
            {
                Console.Write(item + "-");
            }
            //2D
            //Console.WriteLine("2D Array");
            //int length2D_1 = 0;
            //int length2D_2 = 0;

            //length2D_1 = Convert.ToInt32(Console.ReadLine());
            //length2D_2 = Convert.ToInt32(Console.ReadLine());

            //int[,] arr2D = new int[length2D_1, length2D_2];


            
        }
    }
}
