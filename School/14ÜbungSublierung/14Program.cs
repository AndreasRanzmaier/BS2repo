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
            string[] arr = { "Hugo Schuster", "Hugo Mayr", "Hugo Test", "Anton Muster", "Anton AAter" };

            //Sorted Dict sorts the Key 
            SortedDictionary<string, List<string>> tmpDict = new SortedDictionary<string, List<string>>();

            foreach (var tmpNames in arr)
            {
                string[] tmpVals = tmpNames.Split(' ');

                string tmpFirstname = tmpVals[0];
                string tmpLastName = tmpVals[1];

                if (!tmpDict.ContainsKey(tmpFirstname))
                {
                    tmpDict.Add(tmpFirstname, new List<string>());                    
                }
                tmpDict[tmpFirstname].Add(tmpLastName);               
            }

            

            //ausgabe
            foreach (var tmpVal in tmpDict)
            {
                tmpVal.Value.Sort();

                Console.Write($"{tmpVal.Key}: ");
                foreach (var tmpName in tmpVal.Value)
                {
                    Console.Write($"{tmpName},");
                }
                Console.WriteLine("\n");
            }
        }

        static void Dict03()
        {
            

            static void 

            static Dictionary<string, int> CountSameWords(string path)
            {



                return ;
            }
        }
    }
}