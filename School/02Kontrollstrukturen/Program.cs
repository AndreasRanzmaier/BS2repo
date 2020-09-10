//Andreas Ranzmaier 10.09
using System;

namespace _02Kontrollstrukturen
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }

            //same with while 
            int j = 0;
            while (j < args.Length)
            {
                Console.WriteLine(args[j]);
                j++;
            }

            //same with dowhile
            int u = 0;
            do
            {
                Console.WriteLine(args[u]);
                u++;
            } while (u < args.Length);


            Console.ReadKey();
        }
    }
}
