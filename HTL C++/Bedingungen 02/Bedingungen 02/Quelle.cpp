#include<iostream>
#include<conio.h>
#include<math.h>

using namespace std;

void main(){
	cout << "Tag der Woche eingeben (0=onntag,6=Samstag;...)";
	int weekDay;
	cin >> weekDay;
	if (weekDay < 0 || weekDay>6){		// || == oder 
		cout << "ungültiger Wochentag!";
	}
	else if (weekDay == 0){
			cout << "Sonntag";
		}
		else if (weekDay == 1){
			cout << "Montag";
		}
		else if (weekDay == 2){
			cout << "Dienstag";
		}
		else if (weekDay == 3){
			cout << "Mittwoch";
		}
		else if (weekDay == 4){
			cout << "Donnerstag";
		}
		else if (weekDay == 5){
			cout << "Freitag";
		}
		else if (weekDay == 6){
			cout << "Samstag";
	}
	_getch();
}