// Ranzmaier Anderas 28.10.2020
using System;

namespace _16Methoden
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Bsp2();
            Bsp3();

        }

        static void Bsp2()
        {
            // Bsp 1)
            Person Person1 = new Person();
            Person1.AusgabeNamen();
            Person1.Nachname = "Zauner";
            Person1.AusgabeNamen();

            // Bsp 2)
            Person Person2 = new Person("Martha", "Huber", 3);
            Person2.AusgabeNamen();
        }

        static void Bsp3()
        {
            // Bsp 3) neues Protokoll
            //Array der Klasse Person
            Console.WriteLine("Wieviele Personen ?: ");
            int tmp_inp = Convert.ToInt32(Console.ReadLine());

            Person[] Person3 = new Person[tmp_inp];

            //wenn ungerade default einmal ausführen
            int i = 0;
            if (tmp_inp % 2 == 1)
            {
                Person3[1] = new Person();
                i++;
            }

            while (i < tmp_inp)
            {
                //Benutzereingabe
                Console.WriteLine("Vorname[" + i + "] = ");
                string tmp_vname = Console.ReadLine();

                Console.WriteLine("Nachname[" + i + "] = ");
                string tmp_nname = Console.ReadLine();

                Console.WriteLine("Alter[" + i + "] = ");
                int tmp_alter = Convert.ToInt32(Console.ReadLine());


                Person3[i] = new Person(tmp_vname, tmp_nname, tmp_alter);
                i++;
            }

            Console.WriteLine("Default " + Person3[i - 1].DefaultCount);
            Console.WriteLine("Ueberladen " + Person3[i - 1].UeberladenConst);
        }
    }

    class Person
    {
        // 1) Declaration
        private string vorname;
        private string nachname;
        private int alter;

        static private int defaultConst;
        static private int ueberladenConst;

        // 2) Default Konstruktor 
        public Person()
        {
            vorname = "<<leer>>";
            nachname = "<<leer>>";
            alter = 0;
            defaultConst++;
        }

        // 3) Überladener Konstruktor
        public Person (string vname, string nname, int alter)
        {
            this.vorname = vname;
            this.nachname = nname;
            this.alter = alter;
            ueberladenConst++;
        }

        // 4) Methode Ausgabe
        public void AusgabeNamen()
        {
            Console.WriteLine("VName = " + vorname);
            Console.WriteLine("NName = " + nachname);
            Console.WriteLine("Alter = " + alter);
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

        public int DefaultCount
        {
            get
            {
                return defaultConst;
            }
        }

        public int UeberladenConst
        {
            get
            {
                return ueberladenConst;
            }
        }

    }
}
