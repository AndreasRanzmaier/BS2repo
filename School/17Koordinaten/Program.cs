using System;

namespace _17Koordinaten
{
    class Program
    {
        static void Main(string[] args)
        {
            Aufruf();
        }

        
        static void Aufruf()
        {
            // do ja nein abfrage 
            string tmp_jn;
            do
            {
                Console.WriteLine("Wieviele Punkte wollen sie einlesen?: ");
                int tmp_length = Convert.ToInt32(Console.ReadLine());
                Punkt[] punkt1 = new Punkt[tmp_length];

                // EINLESEN for über alle array stellen 
                for (int i = 0; i < tmp_length; i++)
                {
                    punkt1[i] = new Punkt();
                    punkt1[i].EinlesenKoordinaten();                    
                }          
                                   
                // AUSGABE 
                for (int j = 0; j < tmp_length; j++)
                {
                    punkt1[j].AusgabeKoordinaten();
                }

                Console.WriteLine("den selben song nochmal? j | n");
                tmp_jn = Console.ReadLine();
            } while (tmp_jn == "j" || tmp_jn == "J");
        }
    }

    class Punkt
    {
        // VARIABLEN 
        private double _x;
        private double _y;
        static private int _durchlauf;

        // KONSTRUKTOREN
        // default
        public Punkt()
        {
             _x = 0;
             _y = 0;
            _durchlauf = 1;
        }

        // überladener
        public Punkt(double x, double y)
        {
            _x = x;
            _y = y;

            // ausnahme bei grenzüberschreitung 
            Grenzwerte(ref x, ref y);
        }

        // METHODEN
        public void EinlesenKoordinaten()
        {
            UI(out double x, out double y);
            Grenzwerte(ref x, ref y);
            _x = x;
            _y = y;

            void UI(out double x, out double y)
            {
                Console.WriteLine("x: ");
                x = Convert.ToDouble(Console.ReadLine());      
                Console.WriteLine("y: ");
                y = Convert.ToDouble(Console.ReadLine());
            }
        }

        public void AusgabeKoordinaten()
        {
            Console.WriteLine("Koordinate" + _durchlauf +" [" + _x + ", " + _y + "]");
            _durchlauf++;
        }

        public void Grenzwerte (ref double x, ref double y)
        {
            if (x < 0 || x > 400)
            {
                x = 0;
            }
            if (y < 0 || y > 400)
            {
                _y = 0;
            }
        }
    }
}
