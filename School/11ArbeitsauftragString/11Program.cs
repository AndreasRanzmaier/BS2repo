using System;
using System.IO;

namespace _11ArbeitsauftragString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            string datei = "C:\\GIT_repo\\AndreasRanzmaier\\BS_repo\\School\\11ArbeitsauftragString\\Text.txt";

            get_NotenschnittNames(out float[] arrNotenschnitt, out string[] arrNamen, get_Text_from_file(datei));
            print_Table(arrNotenschnitt, arrNamen);
        }

        //reads each line from a file and converts it into one string
        static string get_Text_from_file(string path)
        {
            FileInfo f = new FileInfo(path);
            StreamReader r = f.OpenText();
            string zeile;
            string gesFile = "";
            do
            {
                zeile = r.ReadLine();
                gesFile += zeile;
            } while (zeile != null);

            return gesFile;
            r.Close();
        }

        //clacs the names and the grades 
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

        //adds both arrays and prits a third one 
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

