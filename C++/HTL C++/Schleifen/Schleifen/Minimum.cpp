#include<iostream>
#include<conio.h>
#include<math.h>

using namespace std;

void main() {
	//for (int i = 1; i <= 3; i++) {
		//cout << i << ' ';
	//}
	cout << "Minimum ermitteln.";
	cout << "Bitte Sechs Zahlen nacheinander eingeben "<< endl;
	int min = INT_MAX;
	for (int i = 0; i < 6; i++) {
		cout << "zahl" << i << ": ";
		int num;
		cin >> num;
		if (num < min) {
			min = num;
		}

	}
	cout << "Das minnimum ist " << min;
	_getch();
}