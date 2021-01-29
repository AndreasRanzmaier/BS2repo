// Classes_Inheritance.cpp : Diese Datei enthält die Funktion "main". Hier beginnt und endet die Ausführung des Programms.
//

#include <iostream>
#include <string>

using namespace std;

class Creature
{
public:
	int eyes;
	string type;

	//Constructor Creature 
	Creature()
	{
		cout << "Creature is born" << endl;

	}


};

class Spider: public Creature
{
public:
	//Constructor Spider 
	Spider():Creature()
	{
		cout << "A Spider is Born" << endl;
		eyes = 8;
		type = "achnophobe";
	}
	
};

int main()
{
	Spider Bob;

	system("pause");
}

