using System;
using System.Dynamic;

namespace _05Arrays_und_Statische_Methoden
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            int ausw = Abfrage();
            while (ausw != 4)
            {
                switch (ausw)
                {
                    case 1:
                        Console.WriteLine("1");
                        array1D();
                        break;
                    case 2:
                        Console.WriteLine("2");
                        array2D();
                        break;
                    case 3:
                        Console.WriteLine("3");
                        array2D_ungleich();
                        break;
                }
                ausw = Abfrage();
            }
        }

        //user input for Menu
        static int Abfrage()
        {
            Console.WriteLine("Auswahl des Arrays");
            Console.WriteLine("[1=1D, 2= 2Dgleich, 3= 2D ungleich, 4 = Beenden]");
            return Convert.ToInt32(Console.ReadLine());
        }

        //all inputs
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

            //output
            outp_arr1D(arr1D);
        }

        static void array2D()
        {
            Console.WriteLine("2D Array");
            int length2D_1 = 0;
            int length2D_2 = 0;

            Console.WriteLine("spalten:");
            length2D_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("reihen:");
            length2D_1 = Convert.ToInt32(Console.ReadLine());

            int[,] arr2D = new int[length2D_1, length2D_2];

            for (int i = 0; i < length2D_1; i++)
            {
                for (int j = 0; j < length2D_2; j++)
                {
                    Console.WriteLine("wert an der stelle [" + i + "," + j + "]");
                    arr2D[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //topo nichtmehr übergeben sondern in der ausgabe die längen rechnen ???
            outp_arr2D(arr2D, length2D_1, length2D_2);

            testc(Int16 )
        }

        static void array2D_ungleich()
        {
            //um zu spezifizieren wieviele spalten eien reihe haben sollte ode umgekehrt
            //array mit fixer [x][] und variabler [][y]

            Console.WriteLine("mehrdimensionales dynamisches array");

            //eingabe der längen
            int[][] arr2D = new int[2][];
            for (int i = 0; i < arr2D.Length; i++)
            {
                Console.WriteLine("Elemente a3 [" + i + "]:");
                int länge = Convert.ToInt32(Console.ReadLine());
                arr2D[i] = new int[länge];
            }

            //allgm eingabe 
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < arr2D[i].Length; j++)
                {
                    Console.WriteLine("arr2D at [" + i + "," + j + "]");
                    arr2D[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            outp_arr2D_ungleich(arr2D);
        }


        //all the Outputs...
        static void outp_arr1D(int[] arr)
        {
            //todo outsourcing
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }

        static void outp_arr2D(int[,] arr, int l_D2_1, int L_D2_2)
        {
            for (int i = 0; i < l_D2_1; i++)
            {
                for (int j = 0; j < L_D2_2; j++)
                {

                    Console.Write(arr[i, j]);
                }
                //zeilenumbruch nach jeder fertigen spalte 
                Console.Write("\n");
            }
        }

        static void outp_arr2D_ungleich(int[][] arr)
        {
            //ausgabe 
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

