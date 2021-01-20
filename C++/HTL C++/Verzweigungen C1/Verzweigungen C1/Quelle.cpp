#include<iostream>
#include<conio.h>
#include<math.h>

using namespace std;

void main(){
	cout << "bitte eine Zahl eingeben wir checken ob sie durch 4 teilbar ist oder nicht :)";
	int zahl;
	cin >> zahl;

	bool x = (zahl % 4==0);
	if (x == true){
		cout << zahl << "ist durch 4 teilbar";
	}
	else{
		cout << zahl << "ist nicht durch 4 teilbar";
	}
	_getch();
}