//Ranzmaier Andreas 23.09.2020
using System;
using System.Diagnostics;
using System.Security.Cryptography;

namespace _08Datentypen
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "";
            Einlesen(ref s1);

            Console.WriteLine(s1);
        }

        static void Einlesen(ref string s1)
        {
            bool goo = true;
            do
            {
                Console.WriteLine("Eingabe:");

                s1 += Console.ReadLine();

                if (s1.Contains('.'))
                {
                    goo = false;
                }
            } while (goo);
        }

    }
}
