// 29.01.2021 | Ranzmaier Andreas | Übung

#include <iostream>
#include <string>
using namespace std;

class Animal
{
public:
	// Constructor
	Animal()
	{
		cout << "An Animal is born!" << endl;
		Name = "Default";
		Age = 2;
		Limbs = 4;
	}

	// overloded
	Animal(string _Name, int _Age, int _Limbs)
	{

	}

	// Variables
	int Age;
	int Limbs;
	string Name;

	// Methodes 
	void Report()
	{
		cout << "Limbs:" << Limbs << endl;
		cout << "Name: " << Name << endl;
		cout << "Age:" << Age << endl;
	}
};

int main()
{
	Animal Bob;
	Bob.Report();

	system("pause");
}

