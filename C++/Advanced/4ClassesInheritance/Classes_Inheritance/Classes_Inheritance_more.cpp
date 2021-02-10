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

	// overloded Constructor
	Animal(string _Name, int _Age, int _Limbs) : Name(_Name), Age(_Age), Limbs(_Limbs) { Report(); }

	//same as the Notation Above
	//Name = _Name;
	//Age = _Age;
	//Limbs = _Limbs;

	// Variables
	int Age;
	int Limbs;
	string Name;

	// Methodes 
	void Report()
	{
		cout << endl;
		cout << "Limbs:" << Limbs << endl;
		cout << "Name: " << Name << endl;
		cout << "Age:" << Age << endl;
		cout << endl;
	}
};

class Dog : public Animal
{
	// even tough the Animal class is all public 
	// Dog is private by default 
public:
	Dog() { cout << "it's a dog named: " << Name <<endl; };
	
	//calling the allready existing overloadeded constructor from parent 
	Dog(string _Name, int _Age, int _Limbs) 
	{ 
		// calling the allready existing one 
		//Animal(_Name, _Age, _Limbs);

		// or creating a new one 
		Name = _Name;
		Age = _Age;
		Limbs = _Limbs;

		Report();
	}

	void speak()
	{
		cout << "wuff" << endl;
	}
};

int main() 
{
	Dog Bello("Bello", 4, 5);
	Bello.speak();

	system("pause");
 }

