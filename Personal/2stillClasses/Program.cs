using System;
using System.Security.Cryptography.X509Certificates;

namespace _2stillClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto BMW = new Auto();
            BMW.Baujahr = 1997;
            BMW.PS = 200;
            BMW.Farbe = "Schwarzer";
            BMW.MotorAn = true;
            
            //BMW.getInfo();


            Buch lotr = new Buch("lotr", 400);
            //Console.WriteLine(lotr.Seiten);

            float ergebniss = Math.div((float)400.0, 4);
            // Console.WriteLine(ergebniss);

            Hund Bello = new Hund();

            Bello.bellen();

        }
    }
}
