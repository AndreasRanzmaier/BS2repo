// Ranzmaier Anderas 28.10.2020
using System;

namespace _16Methoden
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bsp 1)
            Person Person1 = new Person();
            Person1.AusgabeNamen();
            Person1.Nachname = "Zauner";
            Person1.AusgabeNamen();

            // Bsp 2)
            Person Person2 = new Person("Martha", "Huber");
            Person2.AusgabeNamen();
        }
    }

    class Person
    {
        // 1) Declaration
        private string vorname;
        private string nachname;

        // 2) Default Konstruktor 
        public Person()
        {
            vorname = "<<leer>>";
            nachname = "<<leer>>";
        }

        // 3) Überladener Konstruktor
        public Person (string vname, string nname)
        {
            this.vorname = vname;
            this.nachname = nname;
        }

        // 4) Methode Ausgabe
        public void AusgabeNamen ()
        {
            Console.WriteLine("VName = " + vorname);
            Console.WriteLine("NName = " + nachname);
        }

        // 5) Getter und Setter Methode 
        public string Nachname
        {
            get
            {
                return this.nachname;
            }
            set
            {
                this.nachname = value;
            }
        }

    }
}
