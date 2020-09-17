//Ranzmaier Andreas 17.9.2020
using System;
using System.Diagnostics;
using System.Dynamic;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            //uncomment when snipping 
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.ForegroundColor = ConsoleColor.Black;
            //Console.Clear();
            Abfrage();

            Console.WriteLine("end");

        }

        //user input for Menu
        static void Abfrage()
        {
            Console.WriteLine("Auswahl");
            Console.WriteLine("[1=vertical, 2= horizontal, 3= Rechteck, 4 = Grid, 5 = beenden]");

            int ausw = Convert.ToInt32(Console.ReadLine());

            if (ausw != 5)
            {
                switch (ausw)
                {
                    case 1:
                        //Vertical
                        VLine();
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                        break;
                    case 2:
                        //Horizontal
                        HLine();
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                        break;
                    case 3:
                        //Rect
                        Rect();
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                        break;
                    case 4:
                        //grid
                        Grid();
                        System.Threading.Thread.Sleep(6000);
                        Console.Clear();
                        break;
                }
                Abfrage();
            }
            else
            {
                return;
            }
        }

        static void VLine()
        {
            //input 
            Console.WriteLine("top :");
            int top = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("left :");
            int left = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("height :");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            //Draw
            DrawVLine(top, left, height);
        }

        static void DrawVLine(int top, int left, int height)
        {
            //todo: buffer size fail if input grater than ~100
            Console.SetCursorPosition(left, top);


            for (int i = 0; i < height+1; i++)
            {
                Console.Write("*\n");
                Console.SetCursorPosition(left, top + i);
            }
        }

        static void HLine()
        {
            //input 
            Console.WriteLine("top :");
            int top = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("left :");
            int left = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("width :");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            DrawHLine(top, left, width);

        }

        static void DrawHLine(int top, int left, int width)
        {
            Console.SetCursorPosition(left, top);

            for (int i = 0; i < width; i++)
            {
                Console.Write("*");
            }
        }

        static void Rect()
        {
            //input 
            Console.WriteLine("top :");
            int top = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("left :");
            int left = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("height :");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("width :");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            DrawRect(top, left, height, width);

        }

        static void DrawRect(int top, int left, int height, int width)
        {
            //todo: buffer size fail if input grater than ~100
            Console.SetCursorPosition(top, left);

            DrawHLine(top, left, width);

            //hights -2cus 2 height from vertical  
            DrawVLine(top+1, left, height-2);
            DrawVLine(top+1, left+width-1, height-2);

            DrawHLine(top+height-1, left, width);

        }

        static void Grid()
        {
            //input 
            Console.WriteLine("top :");
            int top = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("left :");
            int left = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("cellsize :");
            int cellsize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nOfCols :");
            int nOfCols = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nOfRows :");
            int nOfRows = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            DrawGrid(top, left, cellsize, nOfCols, nOfRows);
        }

        static void DrawGrid (int top, int left, int cellsize, int nOfCols, int nOfRows)
        {

            for (int i = 0; i < nOfCols; i++)
            {
                for (int j = 0; j < nOfRows; j++)
                {
                    DrawRect(top + (i * cellsize) - (i*1), left + (j * cellsize) - (j*1), cellsize, cellsize);
                }
            }
        }
    }
}

