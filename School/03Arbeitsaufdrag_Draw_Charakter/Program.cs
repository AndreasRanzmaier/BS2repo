using System;
using System.Globalization;

namespace _03Arbeitsaufdrag_Draw_Charakter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Defining the length 
            int length0 = Int32.Parse(args[0]);
            int length1 = Int32.Parse(args[1]);
            //Sets Colour
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();


            //defines the curser position changeable 
            int cpl = length0;
            int cpt = length1;
            Console.SetCursorPosition(cpl, cpt);

            //sets the windowsize 
            int width = length0 * 3;
            int height = length1 * 3;
            Console.SetWindowSize(width, height);

            //Console Title 
            Console.Title = "Name Konsole";


            //checks if 3 args have been passed 
            if (args.Length > 2)
            {
                //defines the written letter 
                char Buchstabe = char.Parse(args[2]);

                //loops through rows 
                for (int i = 0; i <= length1; i++)
                {
                    //loops through 
                    for (int j = 0; j < length0 ; j++)
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
                Console.WriteLine("zu wenig Parameter!");
            }

            Console.ReadKey();
        }
    }
}
