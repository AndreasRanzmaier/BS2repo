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

                Room raum2 = new Room(4, 3);

                raum2.RoomMultiply(out int erg);
                Console.WriteLine("m^2 = " + erg);

                //Array einer Klasse 
                Room[] r3 = new Room[3];
                for (int i = 0; i < 3; i++)
                {
                    r3[i] = new Room();
                }
                Console.WriteLine("DefaultKonstruktor wurde: " + Room.countRoom + "");
            }

            //Person
            {
                //Person
                string a = Console.ReadLine();
                int b = Convert.ToInt32(Console.ReadLine());
                Person p1 = new Person(a, b);

                Console.WriteLine(p1.VName);
                Console.WriteLine(p1.Alter);
            }

        }

        
    }
    class Room
    {
        // Im main sichtbar
        public int width = 0;

        // Nicht im main sichtbar 
        public int height = 0;

        // Wird nur 1. Initialisiert egal wieviele instanzen es gibt
        public static int countRoom = 0; 
      
        // Default
        public Room()
        {
            width = 0;
            height = 0;
            countRoom ++;
        }
        
        // Overload
        public Room(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        // Getter und Setter Methoden
        public int Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value < 50)
                {

                }
                else
                {
                    this.height = value;    // setzt den wert auch im Public 
                                            // wie ref in einer funktion       
                }


            }
        }

        // Methode 
        public void PrintMembers()
        {
            Console.WriteLine("Raum: " + this.width + ", " + this.height);
        }

        //
        public void RoomMultiply (out int erg)
        {
            erg = this.width * this.height;
        }
    }

    class Person
    {
        public string VName = "";
        public int Alter = 0;

        //
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
