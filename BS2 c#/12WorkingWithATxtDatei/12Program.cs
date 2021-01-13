using System;
using System.IO;

namespace _12WorkingWithATxtDatei
{
    class Program
    {
        static void Main(string[] args)
        {
            string datei = @"text.txt";
            FileInfo f = new FileInfo(datei);

            if (f.Exists)
            {
                //todo: read the dokument
                //reading each line of the doc
                StreamReader r = f.OpenText();
                string zeile;
                do
                {
                    zeile = r.ReadLine();
                    Console.WriteLine(zeile);
                } while (zeile != null);

                r.Close();

                //adding text to the file 
                StreamWriter w = f.AppendText();
                w.WriteLine("goo");
                w.Close();
                //f.Delete();
            }
            else
            {
                Console.WriteLine("Datei " + datei + " existiert nicht");
            }            
        }
    }
}
