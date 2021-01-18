#include <iostream>
using namespace std;

#include "olcConsoleGameEngine.h"

class Example : public olcConsoleGameEngine
{
public:
	Example()
	{

	}

	virtual bool OnUserCreate()
	{
		return true;
	}

	virtual bool OnUserUpdate(float fElapsedtime)
	{

		return true;
	}
};
int main()
{
	Example demo;
	demo.ConstructConsole(160, 100, 8, 8);
	return 0;
}