#include<iostream>
#include<conio.h>
#include<math.h>

using namespace std;
/*Bedingungen 
if (something with YES or NO *bool)
"then" 
else 
"then"
*/

void main(){
	cout << "Division duch 0";
	cout << "Bitte Zahl 1 eingeben:";
	double num1;
	cin >> num1;

	cout << "Bitte zahl 2 eingeben:";
	double num2;
	cin >> num2;

	bool isZero = num2 == 0;

	if (isZero==true){
		cout << "Keine Loesungsmenge" << endl;
	}
	else {
		double result = num1 / num2;
		cout << "Das Ergebnis der Division von " << num1 << " und " << num2 << " ist: " << result << endl;
	}
	

	_getch();
}