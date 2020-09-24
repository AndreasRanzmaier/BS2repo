using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace _10string_methode
{
    class Program
    {
        static void Main(string[] args)
        {
            string xml = "<schule> <bs2> <2aITL> <schueler>Mayr Hans </schueler> <schueler>Andr Ranz </schueler> </2aITL> </bs2> </schule>";

            string startTag = "<schueler>";
            getNames(startTag, xml);
            
        }

        static void getNames (string startTag, string xml)
        {
            int startIndex = 0;
            int endIndex = 0;

            static string endTag(string startTag)
            {
                return startTag.Insert(1, "/");
            }

            while (startIndex != -1)
            {
                startIndex = xml.IndexOf(startTag, endIndex);

                if (startIndex != -1)
                {
                    endIndex = xml.IndexOf(endTag(startTag), startIndex);



                    string temp = xml.Substring(startIndex + startTag.Length, endIndex - startIndex - startTag.Length);

                    temp = temp.Trim();
                    string[] name = temp.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if (name.Length >= 2)
                    {
                        Console.WriteLine("Nachnahme: " + name[0] + "Vornahme: " + name[1]);
                    }
                }
            }
        }
    }
}
