using System;
using System.Globalization;

namespace _03Arbeitsaufdrag_Draw_Charakter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sets Colour
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();


            //defines the curser position changeable 
            int cpl = 5;
            int cpt = 5;
            Console.SetCursorPosition(cpl, cpt);

            //sets the windowsize 
            int width = Int32.Parse(args[0]) * 3;
            int height = Int32.Parse(args[1]) * 2;
            Console.SetWindowSize(width, height);

            //Console Title //todo: fehler wird nicht angezeigt
            Console.Title = "String";

            //checks if 3 args have been passed 
            if (args.Length > 2)
            {
                //defines the written letter 
                char Buchstabe = char.Parse(args[2]);

                //loops through rows 
                for (int i = 0; i <= Int32.Parse(args[1]); i++)
                {
                    //loops through 
                    for (int j = 0; j < Int32.Parse(args[0]); j++)
                    {
                        Console.Write(Buchstabe);
                    }

                    //makes the backslash and sets the cursor to the right position
                    Console.Write("\n");
                    Console.SetCursorPosition(cpl,cpt+i);
                }
            }
            else
            {
                //excepion message
                Console.WriteLine("zu wenig parameter!");
            }

            Console.ReadKey();
        }
    }
}
