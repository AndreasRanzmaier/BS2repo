// 3Pointers.cpp : Diese Datei enthält die Funktion "main". Hier beginnt und endet die Ausführung des Programms.
//

#include <iostream>

int main()
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


	system("pause");
}
