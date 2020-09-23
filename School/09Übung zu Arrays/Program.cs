using System;
using System.Runtime.Serialization;

namespace _09Übung_zu_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Aufgabe2();
        }

        static void Aufgabe1()
        {
            int l = Eingabe("Länge: ");
            int[] arr1 = new int[l];
            for (int i = 0; i < l; i++)
            {
                arr1[i] = Eingabe("Stelle[" + i + "]= ");
            }

            foreach (var item in arr1)
            {
                Console.Write(item);
            }


            static int Eingabe(string s)
            {
                Console.WriteLine(s);
                int l = Convert.ToInt32(Console.ReadLine());
                return l;
            }
        }

        static void Aufgabe2()
        {
            int l = Eingabe("Länge: ");
            int[] arr1 = new int[l];

            //todo: geht das auch einfacher?? 
            int i = 0;
            int foo = 0;
            while (i < l)
            {
                int goo = Eingabe("Stelle[" + i + "]= ");
                if (goo < foo)
                {
                    Console.WriteLine("zo klein... again: ");
                }
                else
                {
                    foo = goo;
                    arr1[i] = goo;
                    i++;
                }

            }

            foreach (var item in arr1)
            {
                Console.Write(item);
            }


            static int Eingabe(string s)
            {
                Console.WriteLine(s);
                int l = Convert.ToInt32(Console.ReadLine());
                return l;
            }
        }
    }
}
