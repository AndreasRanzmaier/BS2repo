// 8VirtualMethodes.cpp : Diese Datei enthält die Funktion "main". Hier beginnt und endet die Ausführung des Programms.
//

#include <iostream>
#include <string>

using namespace std;

class Object
{
public:
	virtual void BeginPlay()
	{
		cout << "Object Being Played Called" << endl;
	}
};

class Actor : public Object
{
public:
	virtual void BeginPlay() override // "virtual" and "override" do not need to be written but its good practice
	{
		cout << "Actor Being Played Called" << endl;
		Object::BeginPlay(); // and you can use the parent version
		// 2012
	}
};

class Pawn : public Actor
{
public:
	virtual void BeginPlay() override
	{
		cout << "Pawn Being Played Called" << endl;
	}
};

int main()
{
	Object* obj = new Object;
	obj->BeginPlay();

	Actor* act = new Actor;
	act->BeginPlay();

	Pawn* pwn = new Pawn;
	pwn->BeginPlay();

	delete pwn;
	delete act;
	delete obj;
	system("pause");
}

