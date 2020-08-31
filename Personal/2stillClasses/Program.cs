using System;

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
            
            BMW.getInfo();

        }
    }
}
