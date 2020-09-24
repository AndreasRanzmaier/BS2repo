using System;

namespace _10string_methode
{
    class Program
    {
        static void Main(string[] args)
        {
            string xml = "<schule> <bs2> <2aITL> <schueler>Mayr Hans </schueler> <schueler>Andr Ranz </schueler> </2aITL> </bs2> </schule>";

            int startIndex = 0;
            int endIndex = 0;

            string startTag = "<schueler>";
            string endTag = "</schueler>";

            while (startIndex != -1)
            {
                startIndex = xml.IndexOf(startTag, endIndex);

                if (startIndex != -1)
                {
                    endIndex = xml.IndexOf(endTag, startIndex);



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
