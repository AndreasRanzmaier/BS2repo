#include<iostream>
#include<conio.h>
#include<math.h>

using namespace std;

void main() {
	cout << "GrundKapital?" << endl;
	float Grundkapital=0;
	cin >> Grundkapital; 

	cout << "Laufzeit?" << endl;
	int Laufzeit = 0; 
	cin >> Laufzeit;
	
	cout << "Zinssatz?" << endl;
	float Zinssatz = 0;
	cin >> Zinssatz;

	
	for (int Jahre = 0; Jahre < Laufzeit; Jahre++) {
		float Ausgabe = Grundkapital* (Zinssatz*0.01);
		
		cout << Jahre << Ausgabe << endl;
		Grundkapital = Ausgabe;
	}
	_getch();
} ///////////// NICHT FERTIG ///////////
