using System;

public class Auto
{
	//Variablen 
	private bool motorAn;

	//Eingenschaften 
	public string Farbe { get; set; }
	public int PS { get; set; }
	public int Baujahr { get; set; }

	public void getInfo()
    {
        Console.WriteLine(Farbe + " Bmw " + PS + " PS (" + Baujahr +")");
    }
}
