// Ranzmaier Anderas 28.10.2020
using System;
using System.Drawing;

namespace _16Methoden
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            //Bsp2();
            string tmp_jn;
            do
            {
                Bsp3();
                Console.WriteLine("den selben song nochmal? j | n");
                tmp_jn = Console.ReadLine();
            } while (tmp_jn == "j" || tmp_jn == "J");            
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
            // Array der Klasse Person
            Console.WriteLine("Wieviele Personen ?: ");
            int tmp_inp = Convert.ToInt32(Console.ReadLine());

            Person[] Person3 = new Person[tmp_inp];

            // wenn ungerade default einmal ausführen
            int i = 0;
            if (tmp_inp % 2 == 1)
            {
                Person3[0] = new Person();

                // nach dem default erzeugen mit der setMembers Methode auffüllen

                BenuzerEingabe(out string tmp_vname, out string tmp_nname, out int tmp_alter);
                Person3[0].setMembers(tmp_vname, tmp_nname, tmp_alter);
                i++;
            }

            // danach / wenn gerade alle werte mit benutzereingeben befüllen 
            while (i < tmp_inp)
            {
                BenuzerEingabe(out string tmp_vname, out string tmp_nname, out int tmp_alter);

                Person3[i] = new Person(tmp_vname, tmp_nname, tmp_alter);
                i++;
            }

            // c) AUSGABE
            Console.WriteLine("Default " + Person3[i - 1].DefaultCount);
            Console.WriteLine("Ueberladen " + Person3[i - 1].UeberladenConst +"\n");
            Console.WriteLine("Person " + Person3.Length);
            for (int j = 0; j < Person3.Length; j++)
            {                
                Console.WriteLine("Vorname " + Person3[j].Vorname);
                Console.WriteLine("Nachname " + Person3[j].Nachname);
                Console.WriteLine("Alter " + Person3[j].Alter + "\n");
            }

            //void Ausgabe()
            void BenuzerEingabe (out string tmp_vname, out string tmp_nname, out int tmp_alter)
            {
                //Benutzereingabe
                Console.WriteLine("Vorname[" + i + "] = ");
                tmp_vname = Console.ReadLine();

                Console.WriteLine("Nachname[" + i + "] = ");
                tmp_nname = Console.ReadLine();

                Console.WriteLine("Alter[" + i + "] = ");
                tmp_alter = Convert.ToInt32(Console.ReadLine());
            }
        }
    }

    class Person
    {
        //DECLARATION
        private string vorname;
        private string nachname;
        private int alter;

        static private int defaultConst;
        static private int ueberladenConst;

        //KONSTRUKTOR
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

      
        //GETTER UND SETTER

        // b) Getter und Setter Methode
        public string Vorname
        {
            get
            {
                return this.vorname;
            }
            set
            {
                this.vorname = value;
            }
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

        // b) Getter und Setter Methode 
        public int Alter
        {
            get
            {
                return this.alter;
            }
            set
            {
                if (value > 0)
                {
                    this.alter = value;
                }
                else
                {
                    this.alter = 1;
                }
                
            }
        }


        //METHODEN        
        // get Default
        public int DefaultCount
        {
            get
            {
                return defaultConst;
            }
        }

        // get Ueberladen
        public int UeberladenConst
        {
            get
            {
                return ueberladenConst;
            }
        }

        // 4) Methode Ausgabe
        public void AusgabeNamen()
        {
            Console.WriteLine("VName = " + vorname);
            Console.WriteLine("NName = " + nachname);
            Console.WriteLine("Alter = " + alter);
        }

        // b) Methode SetMembers 
        public void setMembers(string vorname, string nachname, int alter)
        {
            this.vorname = vorname;
            this.nachname = nachname;
            if (alter > 0)
            {
                this.alter = alter;
            }
            else
            {
                this.alter = 1;
            }
        }
    }
}
