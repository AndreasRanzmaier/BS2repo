using System;
using System.Security.Cryptography.X509Certificates;

namespace _15OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Room raum1 = new Room();
            raum1.width = 9;
            raum1.height = 6;
        }

        class Room
        {
            public int width = 10;
            public int height = 5;

        }
    }
}
