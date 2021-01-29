// 3Pointers.cpp : Diese Datei enthält die Funktion "main". Hier beginnt und endet die Ausführung des Programms.
//

#include <iostream>
#include <string>
using namespace std;

struct Container
{
	string name;

	int x;
	int y;
	int z;
};

int main()
{
	// basics and syntax
	{
		int lol = 10;
		// ---------------refferencing a pointer ---------------
		// int* is a pointer to an integer variable and can only
		// be given the memory position of said integer
		// & assigns the position

		int* ptr = &lol;
		std::cout << ptr << std::endl;


		// --------------- de refferencing a pointer ---------------
		// getting the integer stuff in the pointer location

		std::cout << *ptr << std::endl;

	}
	
	int arr[] = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

	int* arrPtr = arr;
	cout << *arrPtr << endl; //pointing to 0
	arrPtr++;
	cout << *arrPtr << endl; //pointing to 1
	
	//pointer to struct 
	Container container_ = { "Sam", 5, 6, 7 };

	Container* PtrToCont = &container_; // carefull with the operater sequence

	cout << (*PtrToCont).name << endl;
	cout << PtrToCont->name << endl; // same thing (arrow are "POINTING" to things)


	system("pause");
}
