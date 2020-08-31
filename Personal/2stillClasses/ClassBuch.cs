using System;
using System.Threading;

public class Buch
{
    public string Titel { get; set; }
    public int Seiten { get; set; }

    //Konstruktor
    //Konstruktor Parameter MÜSSEN mittgegeben werden !
    //somit kann man den aufruf also zwingen übergabe werte zu haben 
    public Buch (string _titel, int _seiten)
    {
        Titel = _titel;
        Seiten = _seiten;
    }
}

static class Math
{
    //static brauchen keine variablen da kein Objekt instanziert wird 
    public static float div (float number1, float number2)
    {
        float result = number1 / number2;
        return result;
    }
}



