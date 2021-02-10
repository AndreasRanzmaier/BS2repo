// 6HeapAndStack.cpp : Diese Datei enthält die Funktion "main". Hier beginnt und endet die Ausführung des Programms.
//

#include <iostream>
#include <string>

using namespace std;

struct Character
{
	// constructor 
	Character()
	{
		cout << "a char is created" << endl;
		Name = new string("Default Name");
		Health = new float(12.0);
	}
	// destructor
	~Character()
	{
		cout << "a char is deleted" << endl;
		delete Name;
		delete Health;
	}
	
	// Variables
	string* Name;
	float* Health;
};

int main()
{
	for (int i = 0; i < 10; i++)
	{
		Character* PtrToChar = new Character(); //new Keyword dynamically creates (Heap) a new Object 
												//wich then can be accesed with the pointer
												//pointer is still in the stack 

		cout << *(PtrToChar->Name) << endl; 

		cout << PtrToChar->Name << endl;

		delete PtrToChar; //calls the destructor of said Object wich delets it from the Heap
	}
	

	   

	system("pause");
}
