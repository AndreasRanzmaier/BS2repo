using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace _14ÜbungSublierung
{
    class Program
    {
        static void Main(string[] args)
        {
            Dict02();
        }

        static void Dict01()
        {
            string[] arr = { "Hugo", "Franz", "Paul", "Hugo", "Mavin", "Peter", "Franz" };

            Dictionary<string, int> tmpDict = new Dictionary<string, int>();

            //erstellt das dict mit den namen aus arr
            foreach (var tmpName in arr)
            {
                //var ist für schreibfaule 
                // T ist ein generischer Datentyp
                // bei der list sind die Items verteilt im Speicher und zeigen aufeinander 
                // Dictionary <TKey,TValue>

                if (!tmpDict.ContainsKey(tmpName))
                {
                    //ist der name nicht vorhanden wird er angelegt 
                    tmpDict.Add(tmpName, 1);
                }
                else
                {
                    //ist er schon vorhanden wird er erhöht
                    tmpDict[tmpName]++;
                }
            }

            //ausgabe des dicts'
            foreach (/*KeyValuePair<string, int>*/var TmpVal in tmpDict)
            {
                Console.WriteLine($"Name={TmpVal.Key}, Anzahl={TmpVal.Value}");
            }

        }

        static void Dict02()
        {
            string[] arr = { "Hugo Schuster", "Hugo Mayr", "Hugo Test", "Max Muster" };

            Dictionary<string, List<string>> tempDict = new Dictionary<string, List<string>>();

            foreach (var tmp in arr)
            {

            }
        }
    }
}
