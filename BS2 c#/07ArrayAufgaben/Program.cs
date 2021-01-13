using System;
using System.Data;
using System.Security.Cryptography;

namespace _07ArrayAufgaben
{
    class Program
    {
        static void Main(string[] args)
        {
            UI();
        }

        static void UI()
        {
            Console.WriteLine("Auswahl");
            Console.WriteLine("[a=Array einlesen, b= Rahmen, c= beenden]");

            char ausw = Convert.ToChar(Console.ReadLine());

            if (ausw != 'c')
            {
                switch (ausw)
                {
                    case 'a':
                        Console.WriteLine("a");
                        HandleMenueA(out int[] arr1, out int[] arr2);
                        Outputs(arr1, arr2);
                        break;
                    case 'b':
                        Console.WriteLine("b");
                        HandleMenuB(out int _lD1, out int _lD2);
                        createBorder(_lD1, _lD2, out char[,] arr2D);
                        drawArr2D(_lD1, _lD2, arr2D);
                        break;
                }
                // spielt den selben song noch mal! alles klar den selben song und los 
                UI();
            }
            else
            {
                //close application if input was 5
                return;
            }
        }

        //gen of 2 arrays with user input lenght
        static void HandleMenueA(out int[] arr1, out int[] arr2)
        {
            static void input(out int _l1)
            {
                Console.WriteLine("länge der arrays: ");
                _l1 = Convert.ToInt32(Console.ReadLine());            
            }

            input(out int _l1);

            arr1 = new int[_l1];
            arr2 = new int[_l1];

            Random randNum = new Random();
            for (int i = 0; i < _l1; i++)
            {
                arr1[i] = randNum.Next(0, 9);
                arr2[i] = randNum.Next(0, 9);
            }
        }
        
        static void PrintArrSecondValue(int[] arr, int j)
        {
            Console.WriteLine("Array" + j + ": ");
            for (int i = 0; i < arr.Length; i += 2)
            {
                Console.WriteLine(arr[i]);
            }
        }

        static void Outputs(int[] arr1, int[] arr2)
        {
            PrintArrSecondValue(arr1, 1);
            PrintArrSecondValue(arr2, 2);
            PrintArrSecondValue(SummArr(arr1, arr2), 3);
        }

        //int[] SummArr = arr1 + arr2  
        static int[] SummArr(int[] arr1, int[] arr2)
        {
            int[] arr3 = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr3[i] = arr1[i] + arr2[i];
            }
            return arr3;
        }

        static void HandleMenuB(out int _lD1, out int _lD2)
        {
            _lD1 = input_length(1);
            _lD2 = input_length(2);


            //einlesen eines 2D array
            int input_length(int n1)
            {
                Console.WriteLine("länge der" + n1 + ". Dimension");
                return Convert.ToInt32(Console.ReadLine());
            }
        }   
        
        static void createBorder(int lD1, int lD2, out char[,] arr2D)
        {
            arr2D = new char[lD1, lD2];

            //alle mit o 
            for (int i = 0; i < lD1; i++)
            {
                for (int j = 0; j < lD2; j++)
                {
                    arr2D[i, j] = ' ';
                }
            }

            //alle ränder 
            for (int i = 0; i < lD2; i++)
            {
                //alles oben 
                arr2D[0, i] = '*';
                //alle unten 
                arr2D[(lD1 - 1), i] = '*';
            }

            for (int j = 0; j < lD1; j++)
            {
                //alles links 
                arr2D[j, 0] = '*';
                //alles rechts 
                arr2D[j, (lD2 - 1)] = '*';
            }

            //todo: fehler mit ungleichen arrays prob loop problem 
        }

        static void drawArr2D (int lD1, int lD2, char[,] arr2D)
        {
            //von 00 
            for (int i = 0; i < lD1; i++)
            {
                // bis max max 
                for (int j = 0; j < lD2; j++)
                {
                    Console.Write(arr2D[i,j]);                  
                }               
                Console.WriteLine("\n");                
            }
        }

    }
}
