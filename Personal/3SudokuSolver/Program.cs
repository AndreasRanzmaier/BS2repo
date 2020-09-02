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
            int[,] SudokuFeld = new int[row1, collumn1];

            //making one 
            SudokuFeld[0, 0] = 5;
            SudokuFeld[0, 1] = 3;
            SudokuFeld[0, 4] = 7;
            SudokuFeld[1, 0] = 6;
            SudokuFeld[1, 3] = 1;
            SudokuFeld[1, 4] = 9;
            SudokuFeld[1, 5] = 5;
            SudokuFeld[2, 1] = 9;
            SudokuFeld[2, 2] = 8;
            SudokuFeld[2, 7] = 6;
            SudokuFeld[3, 0] = 8;
            SudokuFeld[3, 4] = 6;
            SudokuFeld[3, 8] = 3;
            SudokuFeld[4, 0] = 4;
            SudokuFeld[4, 3] = 8;
            SudokuFeld[4, 5] = 3;
            SudokuFeld[4, 8] = 1;
            SudokuFeld[5, 0] = 7;
            SudokuFeld[5, 4] = 2;
            SudokuFeld[5, 8] = 6;
            SudokuFeld[6, 1] = 6;
            SudokuFeld[6, 6] = 2;
            SudokuFeld[6, 7] = 8;
            SudokuFeld[7, 3] = 4;
            SudokuFeld[7, 4] = 1;
            SudokuFeld[7, 5] = 9;
            SudokuFeld[7, 8] = 5;
            SudokuFeld[8, 4] = 8;
            SudokuFeld[8, 7] = 7;
            SudokuFeld[8, 8] = 9;
         

            solve();


            display(SudokuFeld);


            Console.ReadKey();

            //reccursive backtracking to solve 
            void solve()
            {
                //von [0,0] 
                for (int i = 0; i < row1; i++)
                {                   
                    //bis [8,8]
                    for (int j = 0; j < collumn1; j++)
                    {
                        if (SudokuFeld[i, j] == 0)
                        {
                            //für alle möglichen zahlen 1-9
                            for (int n = 1; n < 10; n++)
                            {
                                if (Possible(i, j, n)) 
                                {
                                    // ist möglich kann aber falsch sein 
                                    SudokuFeld[i, j] = n; //one free square less

                                    solve();

                                    //ausrechnen ob alle felder richtig belegt sind                                     
                                    int full = 0;
                                    for (int x = 0; x < row1; x++)
                                    {
                                        for (int y = 0; y < collumn1; y++)
                                        {
                                            full = full + SudokuFeld[x, y];
                                        }
                                    }                             
                                    if (full == 405)
                                    {
                                        return;
                                    }

                                    SudokuFeld[i, j] = 0;
                                }                          
                            }
                            return;
                        }                        
                    }                    
                }
            }

            //disply the grid
            void display(int[,] Feld)
            {
                int t = 1;

                for (int i = 0; i < row1; i++)
                {
                    for (int j = 0; j < collumn1; j++)
                    {
                        if (((t - 1) % 3 == 0))
                        {
                            Console.Write(" | ");
                        }
                        Console.Write(Feld[i, j]);
                        if (t % 9 == 0)
                        {

                            Console.Write("\n");
                        }
                        if (t % 27 == 0)
                        {
                            Console.Write("------------------\n");
                        }
                        t++;
                    }
                }
            }

            //just to check if field would be posible
            bool Possible(int Row, int Collumn, int tryNumber)
            {
                //cant put a number somewhere if there already is one

                //find all the row numbers
                for (int i = 0; i < row1; i++)
                {
                    if (SudokuFeld[Row, i] == tryNumber)
                    {
                        return false;
                    }
                }

                //find all the collumn numbers
                for (int i = 0; i < collumn1; i++)
                {
                    if (SudokuFeld[i, Collumn] == tryNumber)
                    {
                        return false;
                    }
                }

                //find all the numbers in same square 

                int haus = determineHaus(Row, Collumn);
                int minx = 0;
                int miny = 0;

                minxy(haus, out minx, out miny);

                for (int x = minx; x < minx + 3; x++)
                {
                    for (int y = miny; y < miny + 3; y++)
                    {
                        if (SudokuFeld[x, y] == tryNumber)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }

            //determinesthe 3x3 Field in wich the field to check is 
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

            //checks the haus and sends back its top left corner 
            static void minxy(int haus, out int minx, out int miny)
            {
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
                else  //haus = 9
                {
                    minx = 6;
                    miny = 6;
                }
            }
        }
    }
}