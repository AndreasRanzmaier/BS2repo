using System;

namespace _11ArbeitsauftragString
{
    class Program
    {
        static void Main(string[] args)
        {
            string xml = "Huber: APHM=5, Inf=5, PGTL=2, Atm=2 ;Schuster: APMH=3, INF=1, PGTL=1, Atm=3, a=5";

            get_NotenschnittNames(out float[] arrNotenschnitt, out string[] arrNamen, xml);
            print_Table(arrNotenschnitt, arrNamen);

        }

        static void get_NotenschnittNames(out float[] Noten, out string[] Namen, string xml)
        {
            //wieviele namen
            int j = 0;
            for (int i = 0; i < xml.Length; i++)
            {
                if (xml[i] == ':')
                {
                    j++;
                }
            }

            Noten = new float[j];
            Namen = new string[j];

            //füllen des Notenschnitt arrays
            j = -1;
            int temp = 0;
            for (int i = 0; i < xml.Length; i++)
            {
                if (xml[i] == ':')
                {
                    j++;
                }
                if (xml[i] == '=')
                {
                    temp++;
                    Noten[j] += xml[(i + 1)] & 0x0f;
                }
            }
            //notensumme / anzahl der = 
            //todo: es wird dafon ausgegangen das alle schüler gleich viele fächer haben 
            for (int i = 0; i < Noten.Length; i++)
            {
                Noten[i] = Noten[i] / (temp / Noten.Length);
            }

            //suchen der Namen
            j = 0;
            temp = 0;
            for (int i = 0; i < xml.Length; i++)
            {
                if (xml[i] == ';')
                {
                    temp = i;
                }

                if (xml[i] == ':')
                {
                    j++;


                    if (j == 1)
                    {
                        Namen[j - 1] = xml.Substring(0, i);
                    }
                    else
                    {
                        Namen[j - 1] = xml.Substring(temp + 1, (i - temp - 1));
                    }
                }
            }
        }

        static void print_Table(float[] Noten, string[] Namen)
        {
            //erzeugen eines ges. string arr 
            string[,] ges = new string[Noten.Length, Namen.Length];
            for (int j = 0; j < Namen.Length; j++)
            {
                ges[0, j] = Namen[j];
            }
            for (int i = 0; i < Noten.Length; i++)
            {

                ges[1, i] = Convert.ToString(Noten[i]);
            }

            //printing it 
            for (int j = 0; j < Namen.Length; j++)
            {
                Console.Write(ges[0, j] + ": ");
                Console.WriteLine(ges[1, j]);
            }
        }
    }
}

