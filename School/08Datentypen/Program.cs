//Ranzmaier Andreas 23.09.2020
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Linq;

namespace _08Datentypen
{
    class Program
    {
        static void Main(string[] args)
        {
            //            string s1 = "";
            //           Einlesen(ref s1);
            //            Console.WriteLine(s1);
            Einlesen2();

        }

        //call by refference 
        static void Einlesen(ref string s)
        {
            bool goo = true;
            do
            {
                Console.WriteLine("Eingabe:");

                s += Console.ReadLine();

                if (s.Contains('.'))
                {
                    goo = false;
                }
            } while (goo);
        }

        static void Einlesen2()
        {
            //dekl . , ! ? : ;
            string s = "";
            char[] arrayChars = new char[6] { '.', ',', '!', '?', ':', ';' };
            int[] array = new int[6];
             
            do
            {
                Console.WriteLine("Eingabe");
                s = Console.ReadLine();

                //alles nach einem * soll ignoriert werden 
                if (s.Contains('*'))
                {
                    string[] s1 = s.Split('*');
                    s = s1[0];
                    break;
                }
                for (int i = 0; i < arrayChars.Length; i++)
                {
                    array[i] += zaehlen(s, arrayChars[i]);
                }

            } while (!s.Contains('*'));

            ausgabe(arrayChars, array);

            static int zaehlen(string s, char a)
            {
                int count = s.Count(x => x == a);
                return count;
            }

            static void ausgabe(char[] chararray, int[] numarray)
            {
                for (int i = 0; i < numarray.Length; i++)
                {
                    Console.WriteLine(chararray[i] + " : " + numarray[i]);
                }
            }
        }
    }
}
