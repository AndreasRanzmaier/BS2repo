using System;

namespace _15OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Room
            {
                Room raum1 = new Room();
                //raum1.width = 9;
                //jajaj
                Room r2 = new Room(4, 3);
                Console.WriteLine(r2.width);
            }

            //Person
            string a = Console.ReadLine();
            int b = Convert.ToInt32(Console.ReadLine());
            Person p1 = new Person(a,b);

            Console.WriteLine(p1.VName);
            Console.WriteLine(p1.Alter);
        }

        class Room
        {
            //standardmäßig ist private 

            // im main sichtbar
            public int width = 0;

            //nicht im main sichtbar 
            public int height = 0;

            /* konstruktor 1
             * Default ÜBERSCHREIBEN 
             * die Schnittselle ist gleich (kein überladen)             
             */
            public Room()
            {
                width = 15;
                height = 20;
            }

            /*
              ÜBERLADEN 
             */
            public Room(int width, int height)
            {
                this.width = width;
                this.height = height;
            }
        }

        class Person
        {
            public string VName = "";
            public int Alter = 0;

            public Person()
            {
                VName = "Muster";
                Alter = 18;
            }

            public Person(string VName, int Alter)
            {
                this.VName = VName;
                this.Alter = Alter;

            }
        }
    }
}
