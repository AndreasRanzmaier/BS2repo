using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Text.Unicode;

namespace _14ÜbungSublierung
{
    class Program
    {
        static void Main(string[] args)
        {
            //nur Dict3 beachtenb 1,2 sind andere kleine übungen
            Dict03();
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
            foreach (var TmpVal in tmpDict)
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
        
        //jetztige aufgabe
        static void Dict03()
        {
            {
                //txt file muss mit utf-8 BOM gespeichert sein 
                string datei = @"C:\Users\zmoad\Source\Repos\AndreasRanzmaier\BS_repo\School\14ÜbungSublierung\TextFile3.txt";

                if (File.Exists(datei))
                {
                    Console.WriteLine("Zeilen: " + CountLines(datei));
                    Console.WriteLine("Wörter: " + CountWords(datei, out Dictionary<string, int> SameWords));
                    Console.WriteLine("Buzchstaben: " + CountLetters(datei));
                    AusgabeBstrPunkte(datei);
                }
                else
                {
                    //error msg if missing 
                    Console.WriteLine("missing TextFile");
                }
            }

            static void AusgabeBstrPunkte (string path)
            {
                int[] tmparr = GetBeistrPunkte(path);

                Console.WriteLine("Punkte: " + tmparr[0]);
                Console.WriteLine("Beistriche: " + tmparr[1]);
            }

            static int CountLines(string path)
            {
                string st = GetTextFromFile(path);
                int numLines = GetTextFromFile(path).Split('\n').Length;

                return numLines;
            }

            //todo: not working 
            static int CountWords(string path, out Dictionary<string, int> SameWords)
            {
                static string[] GetWords(string input)
                {
                    MatchCollection matches = Regex.Matches(input, @"\b[\w']*\b");

                    var words = from m in matches.Cast<Match>()
                                where !string.IsNullOrEmpty(m.Value)
                                select TrimSuffix(m.Value);

                    return words.ToArray();
                }
             
                static string TrimSuffix(string word)
                {
                    int apostropheLocation = word.IndexOf('\'');
                    if (apostropheLocation != -1)
                    {
                        word = word.Substring(0, apostropheLocation);
                    }

                    return word;
                }

                //task 2 same words
                static Dictionary<string, int> CountSameWords(string path)
                {
                    Dictionary<string, int> tmpDict = new Dictionary<string, int>();
                    string[] tmp = GetWords(GetTextFromFile(path));
                    foreach (var tmpName in tmp)
                    {                     
                        if (!tmpDict.ContainsKey(tmpName))
                        {
                            //ist das wort nicht vorhanden wird es angelegt 
                            tmpDict.Add(tmpName, 1);
                        }
                        else
                        {
                            //ist es schon vorhanden wird er erhöht
                            tmpDict[tmpName]++;
                        }
                    }
                    return null;
                }
                SameWords = CountSameWords(path);


                //task 2.1 in wich lines of the txt can we find a certain word
                //string word = "die";
                CreateIndex(path);

                static Dictionary<string, List<int>> CreateIndex(string path)
                {
                    string[] tmpwords = GetWords(GetTextFromFile(path));                    
                    string[] tmpWorsWithoutSame = RemoveDuplicates(tmpwords);

                    static string[] RemoveDuplicates(string[] s)
                    {
                        HashSet<string> set = new HashSet<string>(s);
                        string[] result = new string[set.Count];
                        set.CopyTo(result);
                        return result;
                    }

                    //finds all index of a word in text 
                    static List<int> AllIndexesOfString(string gesText, string zuSuchenderString)
                    {                        
                        List<int> indexes = new List<int>();
                        for (int index = 0; ; index += zuSuchenderString.Length)
                        {
                            index = gesText.IndexOf(zuSuchenderString, index);
                            if (index == -1)
                                return indexes;
                            indexes.Add(index);
                        }
                    }
                    
                    int tmp = Regex.Matches(GetTextFromFile(path), "\n").Count;

                    //array mit den "end inexes" of the lines so we have to check form last to next,
                    int[] arrEndIndex = new int[tmp+1];
                    int i = 0;
                    for ( i = 0; i < tmp; i++)
                    {
                        if (i == 0)
                        {
                            arrEndIndex[i] = (GetTextFromFile(path).IndexOf("\n", arrEndIndex[i] + 1)) ;
                        }
                        else
                        {
                            arrEndIndex[i] = (GetTextFromFile(path).IndexOf("\n", arrEndIndex[i-1] + i)) - i;
                        }                        
                    }

                    //
                    if (arrEndIndex[i] == 0)
                    {
                        arrEndIndex[i] = GetTextFromFile(path).Length - i + 1;

                    }

                    Dictionary<string, List<int>> resultdict = new Dictionary<string, List<int>>();

                    //über alle wörter
                    for (int j = 0; j < tmpWorsWithoutSame.Length; j++)
                    {
                        List<int> tmpList = AllIndexesOfString(GetTextFromFile(path), tmpWorsWithoutSame[j] );
                        List<int> resultWordIndex = new List<int>();
                        //schaut alle indize durch
                        foreach (var x in tmpList)
                        {
                            for (int k = 0; k < arrEndIndex.Length; k++)
                            {
                                if (k <= arrEndIndex[k])
                                {
                                    resultWordIndex.Add(k);
                                    break;
                                }
                            }
                        }
                        resultdict.Add(tmpWorsWithoutSame[j], resultWordIndex);
                    }
                    //erstellen der List für die anzahl / zeilen des Wortes
                    List<int> tmpListZeilen = new List<int>();
                 
                    return resultdict;
                }
                               
                return GetWords(GetTextFromFile(path)).Length;
            }
                        
            static int CountLetters(string path)
            {
                
                string tmp = GetTextFromFile(path);

                string str =  RemoveSpecialChr(tmp);



                static string RemoveSpecialChr(string st1)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (char c in st1)
                    {
                        if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == 'ä'
                            || c == 'Ä' || c == 'ü' || c == 'Ü' || c == 'ö' || c == 'Ö' || c == 'ß')
                        {
                            sb.Append(c);
                        }
                    }
                    return sb.ToString();
                }

                int result = str.Length;
                return result;
            }
         
            static string GetTextFromFile(string path)
            {
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                ////ausnahmen für sonderzeichen 
                FileInfo f = new FileInfo(path);
                //StreamReader re = f.OpenText();
                StreamReader re = new StreamReader(f.OpenText().BaseStream, Encoding.GetEncoding(1252));

                return re.ReadToEnd();
            }

            static int[] GetBeistrPunkte (string path)
            {
                int[] tmpstringarr = new int[2];
                string tmp = GetTextFromFile(path);
                foreach (var item in tmp)
                {
                    if (item == '.')
                    {
                        tmpstringarr[0]++;
                    }
                    if (item == ',')
                    {
                        tmpstringarr[1]++;
                    }
                }
                return tmpstringarr;
            }            
        }
    }
}