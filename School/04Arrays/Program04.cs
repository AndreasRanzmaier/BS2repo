//11.09 Andreas Ranzmaier
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace _04Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            array2D();

        }

        static void array2D()
        {
            Console.WriteLine("2D Array");
            int length2D_1 = 0;
            int length2D_2 = 0;

            Console.WriteLine("x:");
            length2D_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y:");
            length2D_2 = Convert.ToInt32(Console.ReadLine());

            int[,] arr2D = new int[length2D_1, length2D_2];

            for (int i = 0; i < length2D_1; i++)
            {
                for (int j = 0; j < length2D_2; j++)
                {
                    Console.WriteLine("wert an der stelle [" + i + "," + j + "]" );
                    arr2D[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            
            for (int i = 0; i < length2D_1; i++)
            {
                for (int j = 0; j < length2D_2; j++)
                {

                    Console.Write(arr2D[i,j]);
                }
                //zeilenumbruch nach jeder fertigen spalte 
                Console.Write("\n");
            }

        }

        static void array1D()
        {
            Console.WriteLine("1D Array");
            int length1D_1 = 0;
            Console.WriteLine("länge:");
            length1D_1 = Convert.ToInt32(Console.ReadLine());

            int[] arr1D = new int[length1D_1];

            for (int i = 0; i < arr1D.Length; i++)
            {
                Console.WriteLine("Input arr1D an Stelle" + (i + 1));
                arr1D[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var item in arr1D)
            {
                Console.Write(item + "-");
            }
        }

    }
}
