#include<iostream>
#include<conio.h>
#include<math.h>

using namespace std;

void main() {
	int Fahrenheit=0;
	for (Fahrenheit;Fahrenheit <= 300; Fahrenheit =Fahrenheit+ 20) {
	
	int Celsius = 0.55555555555555555555555*(Fahrenheit-32); // FEHLER EIGENTLICH SOLLTE 5/9 VERWENDET WERDEN
	cout << Fahrenheit << "              " << Celsius << endl;
	}
	
	_getch();




}
