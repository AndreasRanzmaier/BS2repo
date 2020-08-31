using System;

public class Auto
{
	//Variablen immer klein schreiben
	private bool motorAn;

	//Eingenschaften immer groß schreiben 
	public string Farbe { get; set; }
	public int PS { get; set; }
	public int Baujahr { get; set; }


	//selber get und set zugriff machen also private variable zu einer Eigenschaft machen  
	public bool MotorAn
    {
        get
        {
            Console.WriteLine("WertGelesen");
            return motorAn;
        }
        set
        {
            Console.WriteLine("WertÜberschrieben");
            motorAn = value;
        }
    }

	public void getInfo()
    {
        Console.WriteLine(Farbe + " Bmw " + PS + " PS (" + Baujahr +")");
    }
}
