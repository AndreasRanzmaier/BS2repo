// 3Pointers.cpp : Diese Datei enthält die Funktion "main". Hier beginnt und endet die Ausführung des Programms.
//

#include <iostream>
using namespace std;

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


	system("pause");
}
