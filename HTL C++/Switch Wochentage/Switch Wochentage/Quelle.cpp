#include<iostream>
#include<conio.h>
#include<math.h>

using namespace std;

void main(){
	cout << "Tag der Woche eingeben (0=sonntag,6=Samstag;...)"; 
	 short weekday;
	cin >> weekday;						    //user input from 0-6

	switch (weekday){					   //switch beginnig checking the wekkday input ( wich is a number)
	case 1:								   //checking each number and asigning a Weekday ( string)
		cout << "Montag"; break;		   //telling the assigned weekday (string) BREAK so it dosen run throught all 
	case 2: 
		cout << "Dienstag"; break;
	case 3:
		cout << "Mittwoch"; break;
	case 4:
		cout << "Donnerstag"; break;
	case 5:
		cout << "Freitag"; break;
	case 6:
		cout << "Samstag"; break;
	case 0:
		cout << "Sontag"; break;
	default:
		cout << "LoL wtf 0-6!!!!!!!!!!";   //if its not a defined case tell the customer 

	}
	_getch();
}