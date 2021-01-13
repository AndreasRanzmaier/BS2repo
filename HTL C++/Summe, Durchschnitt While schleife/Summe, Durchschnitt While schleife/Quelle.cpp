#include<iostream>
#include<conio.h>
#include<math.h>

using namespace std;

void main() {
	cout << "Summe ermitteln.";
	cout << "Bitte Sechs Zahlen nacheinander eingeben " << endl;

	cout << "wie viele Zahlen ? : ";
	int amountOfNumbers;
	cin >> amountOfNumbers;

	int sum = 0;
	int i = 0;
	while (i<amountOfNumbers) {
		cout << "zahl" << i << "=";
		int num;
		cin >> num;
		sum = sum + num;
		i++;
	}
	cout << "Die Summe ist " << sum << endl;
	cout << "Der Durchschnitt ist" << (double)sum / amountOfNumbers;


	_getch();
}
