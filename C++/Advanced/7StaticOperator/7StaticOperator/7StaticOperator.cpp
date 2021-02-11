// 7StaticOperator.cpp : Diese Datei enthält die Funktion "main". Hier beginnt und endet die Ausführung des Programms.
//

#include <iostream>
#include <string>

using namespace std;

void update_count();
void update_count_static();

class Creature
{
public:
	// using it to unbind a variable from 1 object
	// static belongst to all and is same for all
	static int creature_count;
	Creature()
	{
		creature_count++;
	}

	// can be called without any objects of that class *2
	static void Speak() { cout << "hi" << endl; }


};

int main()
{
	for (int i = 0; i < 10; i++)
	{
		update_count_static();
	}
	
	for (int i = 0; i < 10; i++)
	{
		update_count();
	}

	//*2
	Creature::Speak();
}

//  using the static keyword in funktion variable so they can live past there scope
// same is true for class objects 
void update_count_static()
{
	static int count = 0;
	count++;
	cout << count << endl;
}

void update_count()
{
	int count = 0;
	count++;
	cout << count << endl;
}
