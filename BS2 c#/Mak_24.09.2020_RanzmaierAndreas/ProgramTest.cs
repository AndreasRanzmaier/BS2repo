//Ranzmaier Andreas Mak 
//24.09.2020 

using System;

namespace Mak_24._09._2020_RanzmaierAndreas
{
    class ProgramTest
    {
        static void Main(string[] args)
        {
            Menue();
        }

        static void Menue()
        {
            int ausw = 0;
            Console.WriteLine("1. 2DArray + Add");
            Console.WriteLine("2. IZeichnen");
            Console.WriteLine("3. LZeichnen");
            Console.WriteLine("4. Beenden");


            Console.Write("\nAuswahl: ");
            ausw = Convert.ToInt32(Console.ReadLine());
            if (ausw != 4)
            {
                switch (ausw)
                {
                    case 1:
                        GetArrayMemory();
                        break;
                    case 2:
                        PrintAndFillArray('I');
                        break;
                    case 3:
                        PrintAndFillArray('L');
                        break;
                }
                // spielt den selben song noch mal! alles klar den selben song und los 
                Menue();
            }
            else
            {
                // close application if input was 4
                Console.WriteLine("Auf Widersehen!");
                return;
            }
        }

        static void GetArrayMemory()
        {
            // eingabe zeilen 
            Console.Write("Zeilen: ");
            int d1 = Convert.ToInt32(Console.ReadLine());

            // eingabe spalten
            Console.Write("Spalten: ");
            int d2 = Convert.ToInt32(Console.ReadLine());

            // 
            int[,] arr = new int[d1, d2];
            FillArray(arr);
        }

        static void FillArray(int[,] a)
        {
            Random randNum = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = randNum.Next(0, 9);
                }
            }
            MakeArraySum(a);
        }

        static void MakeArraySum(int[,] a)
        {
            int[,] arrSumm = new int[a.GetLength(0), a.GetLength(1) + 1];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    arrSumm[i, j] = a[i, j];
                }
            }

            //für alle zeilen 
            for (int i = 0; i < arrSumm.GetLength(0); i++)
            {
                //arrSumm[i, a.GetLength(1)] = 9;
                for (int j = 0; j < (arrSumm.GetLength(1) - 1); j++)
                {
                    arrSumm[i, a.GetLength(1)] += arrSumm[i, j];
                }
            }

            PrintArray(arrSumm);
        }

        static void PrintArray(int[,] b)
        {
            for (int i = 0; i < b.GetLength(0); i++)
            {
                // bis max max 
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write(b[i, j] + " ");
                }

                Console.WriteLine("\n");
            }
        }

        static void PrintAndFillArray(char c)
        {

            if (c == 'I')
            {
                char[,] arrI = InputZeileSpalte();

                //alles Lehrzeichen
                for (int i = 0; i < arrI.GetLength(0); i++)
                {
                    for (int j = 0; j < arrI.GetLength(1); j++)
                    {
                        arrI[i, j] = ' ';
                    }
                }
                //linke seite befüllen
                for (int j = 0; j < arrI.GetLength(0); j++)
                {
                    //alles links 
                    arrI[j, 0] = '*';
                }
                drawArr2D(arrI);
            }
            else if (c == 'L')
            {
                char[,] arrL = InputZeileSpalte();

                //alles Lehrzeichen
                for (int i = 0; i < arrL.GetLength(0); i++)
                {
                    for (int j = 0; j < arrL.GetLength(1); j++)
                    {
                        arrL[i, j] = ' ';
                    }
                }

                //alles Links
                for (int j = 0; j < arrL.GetLength(0); j++)
                {
                    //alles links 
                    arrL[j, 0] = '*';
                }

                //alle unten 
                for (int i = 0; i < arrL.GetLength(1); i++)
                {
                    arrL[(arrL.GetLength(0) - 1), i] = '*';
                }

                drawArr2D(arrL);
            }

            static char[,] InputZeileSpalte()
            {
                //eingabe zeilen
                Console.Write("Zeilen: ");
                int d1 = Convert.ToInt32(Console.ReadLine());

                //eingabe spalten
                Console.Write("Spalten: ");
                int d2 = Convert.ToInt32(Console.ReadLine());

                char[,] arr = new char[d1, d2];
                return arr;
            }

            static void drawArr2D(char[,] arr2D)
            {
                //von 00 
                for (int i = 0; i < arr2D.GetLength(0); i++)
                {
                    // bis max max 
                    for (int j = 0; j < arr2D.GetLength(1); j++)
                    {
                        Console.Write(arr2D[i, j]);
                    }
                    Console.WriteLine("\n");
                }
            }
        }
    }
}
