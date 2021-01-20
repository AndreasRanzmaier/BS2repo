#include<iostream>
#include<conio.h>

using namespace std;

void main() {
	cout << "Rechnen und Benutzereingaben" << endl;
	cout << 3.2 + 4.3 << endl;

	float result = 3.2 + 4.3;
	cout << result << endl;
	result++;
	cout << result << endl;

	//Let the user enter twom values and then add them
	int number1 = 0;
	int number2 = 0;
	cout << "Bitte Zahl 1 eingeben" << endl;
	cin >> number1;
	cout << "Bitte Zahl 2 eingeben" << endl;
	cin >> number2;

	cout << number1 << "+" << number2 << "=" << number1 + number2 << endl;

	//== ->Vergleich
	cout << "Sind die Zahlen gleich?" << endl;
	bool areNumbersEqual = (number1 == number2);
	bool areNumbersNotequal = (number1 != number2);
	
	cout << "Sind die beiden zahlen unggleich?"<< endl;
	

	if (areNumbersEqual){

	}


	areNumbersNotequal != areNumbersEqual; //Not Operator

	//comment abou Bool 
	/*bool a b Vergleiche

	a b && || !a  (a||b)&&!a      ^
	0 0 0  0  1	   0       1=0	  0
	1 0 0  1  0    1       0=0    1
	0 1 0  1  1    1       1=1    1
	1 1 1  1  0    1       0=0    0

	a==true &&b==true 
	a&&b und
	a||b oder
	c==2||c==3


	*/
	//leap year logic
	/*
	int y=... y%4==0&&y%100!=0||y%400==0
	condition whether a leap year or not
	for instance 2016
	true %% true || false 
	insgesamt true 

	*/

	_getch();
}