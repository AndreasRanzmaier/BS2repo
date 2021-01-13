#include<iostream>
#include<conio.h>
#include<math.h>

using namespace std;

void main() {
	//for (int i = 1; i <= 3; i++) {
	//cout << i << ' ';
	//}
	cout << "Summe ermitteln.";
	cout << "Bitte Sechs Zahlen nacheinander eingeben " << endl;
	
	cout << "wie viele Zahlen ? : ";
	int amountOfNumbers;
	cin >> amountOfNumbers;
	
	int sum = 0;
	for (int i = 0; i <amountOfNumbers; i++) {
		cout << "zahl" << i << ": ";
		int num;
		cin >> num;
		sum = sum + num; //sum = num +sum

	}
	cout << "Die Summe ist " << sum<< endl;
	cout << "Der Durchschnitt ist" << (double)sum / amountOfNumbers;
	_getch();
}