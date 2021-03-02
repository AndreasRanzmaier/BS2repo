// 9Polymorphism.cpp : Diese Datei enthält die Funktion "main". Hier beginnt und endet die Ausführung des Programms.
//

#include <iostream>
using namespace std;

class Object
{
public:
	virtual void BeginPlay()
	{
		cout << "Object BeginPlay() called /n/n";
	}
};

class Actor : public Object
{
public:
	virtual void BeginPlay() override
	{
	}
};



int main()
{
}



