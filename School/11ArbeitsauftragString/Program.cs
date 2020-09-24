using System;

namespace _11ArbeitsauftragString
{
    class Program
    {
        static void Main(string[] args)
        {
            string xml = "Huber: APHM=5, Inf=2, PGTL=2;Schuster: APMH=3, INF=3, PGTL=3";

            //wieviele namen
            int j = 0;
            for (int i = 0; i < xml.Length; i++)
            {
                if (xml[i] == ':')
                {
                    j++;
                }
            }

            int[] arrNotenschnitt = new int[j];
            string[] arrNamen = new string[j];

            //füllen des Notenschnitt arrays
            j = -1;
            for (int i = 0; i < xml.Length; i++)
            {
                if (xml[i] == ':')
                {
                    j++;
                }
                if (xml[i] == '=')
                {
                    arrNotenschnitt[j] += xml[(i + 1)] & 0x0f;
                }
            }

            //suchen der Namen und kombinieren der arrays 
            j = 0;
            for (int i = 0; i < xml.Length; i++)
            {                
                if (xml[i] == ':')
                {
                    j++;
                    int temp = 0;
                    if (xml[i] == ';')
                    {
                        temp = i;
                    }
                  
                    if (j == 1)
                    {
                        arrNamen[j-1] = xml.Substring(0, i);
                    }
                    else
                    {
                        arrNamen[j-1] = xml.Substring((i-temp), i);
                    }
                }
            }

        }

    }
}
