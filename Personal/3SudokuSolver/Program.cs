using System;
using System.Runtime.Serialization.Formatters;

namespace _3SudokuSolver
{
    // https://www.sudokuwiki.org/sudoku.htm  
    class Program
    {

        static void Main(string[] args)
        {
            int row1 = 9;
            int collumn1 = 9;
            int[,] namenListe = new int[row1, collumn1];

            //making one 
            namenListe[0, 0] = 5;
            namenListe[0, 1] = 3;
            namenListe[0, 4] = 7;
            namenListe[1, 0] = 6;
            namenListe[1, 3] = 1;
            namenListe[1, 4] = 9;
            namenListe[1, 5] = 5;
            namenListe[2, 1] = 9;
            namenListe[2, 2] = 8;
            namenListe[2, 7] = 6;
            namenListe[3, 0] = 8;
            namenListe[3, 4] = 6;
            namenListe[3, 8] = 3;
            namenListe[4, 0] = 4;
            namenListe[4, 3] = 8;
            namenListe[4, 5] = 3;
            namenListe[4, 8] = 1;
            namenListe[5, 0] = 7;
            namenListe[5, 4] = 2;
            namenListe[5, 8] = 6;
            namenListe[6, 1] = 6;
            namenListe[6, 6] = 2;
            namenListe[6, 7] = 8;
            namenListe[7, 3] = 4;
            namenListe[7, 4] = 1;
            namenListe[7, 5] = 9;
            namenListe[7, 8] = 5;
            namenListe[8, 4] = 8;
            namenListe[8, 7] = 7;
            namenListe[8, 8] = 9;

            solve();

            Console.ReadKey();



            void solve()
            {
                row1--;
                collumn1--;
                for (int i = 0; i < row1; i++)
                {
                    for (int j = 0; j < collumn1; j++)
                    {
                        for (int n = 1; n < 10; n++)
                        {
                            if (Possible(row1, collumn1, n))
                            {
                                namenListe[row1, collumn1] = n;
                                solve();
                                namenListe[row1, collumn1] = 0;
                                return;
                            }
                        }
                    }
                }
            }            

            bool Possible(int Row, int Collumn, int tryNumber)
            {
                //cant put a number somwhere if there allready is one
                if (namenListe[Row, Collumn] == 0)
                {
                    //find all the row numbers
                    for (int i = 0; i < row1; i++)
                    {
                        if (namenListe[i, Row] == tryNumber)
                        {
                            return false;
                        }
                    }

                    //find all the collumn numbers
                    for (int i = 0; i < collumn1; i++)
                    {
                        if (namenListe[Collumn, i] == tryNumber)
                        {
                            return false;
                        }
                    }

                    //find all the numbers in same square 

                    int haus = determineHaus(Row, Collumn);
                    int minx = 0;
                    int miny = 0;

                    if (haus == 1)
                    {
                        minx = 0;
                        miny = 0;
                    }
                    else if (haus == 2)
                    {
                        minx = 3;
                        miny = 0;
                    }
                    else if (haus == 3)
                    {
                        minx = 6;
                        miny = 0;
                    }
                    else if (haus == 4)
                    {
                        minx = 0;
                        miny = 3;
                    }
                    else if (haus == 5)
                    {
                        minx = 3;
                        miny = 3;
                    }
                    else if (haus == 6)
                    {
                        minx = 6;
                        miny = 3;
                    }
                    else if (haus == 7)
                    {
                        minx = 0;
                        miny = 6;
                    }
                    else if (haus == 8)
                    {
                        minx = 3;
                        miny = 6;
                    }
                    else if (haus == 9)
                    {
                        minx = 6;
                        miny = 6;
                    }


                    for (int x = minx; x < minx + 3; x++)
                    {
                        for (int y = miny; y < miny + 3; y++)
                        {
                            if (namenListe[x, y] == tryNumber)
                            {
                                return false;
                            }
                        }
                    }

                }
                else
                {
                    Console.WriteLine("allready a number");
                    return false;
                }

                return true;
            }

            static int determineHaus(int Row, int Collumn)
            {
                //ausgabe 1-9 je nach "Haus" also 3x3 kasten
                //147
                if (Row <= 2)
                {
                    if (Collumn <= 2)
                    {
                        return 1;
                    }
                    else if (Collumn > 2 && Collumn <= 5)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
                //258
                else if (Row > 2 && Row <= 5)
                {
                    if (Collumn <= 2)
                    {
                        return 2;
                    }
                    else if (Collumn > 2 && Collumn <= 5)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
                //369
                else if (Row > 5 && Row <= 8)
                {
                    if (Collumn <= 2)
                    {
                        return 3;
                    }
                    else if (Collumn > 2 && Collumn <= 5)
                    {
                        return 6;
                    }
                    else
                    {
                        return 9;
                    }
                }
                else
                {
                    return 0;
                }
            }

        }
    }
}