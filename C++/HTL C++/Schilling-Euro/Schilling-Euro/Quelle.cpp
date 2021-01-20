#include<iostream>
#include<conio.h>
#include<math.h>

using namespace std;

void main(){
	char se;

	const float COURSE = 13.7063;//constant number chourse of SChlling to Euro 

	//interface and input of se 
	cout << "Gib den Namen der Währung (s,S,e,E) ein weleche du umwandeln willst: " << endl;
	cin >> se; 


	if ((se == 's') || (se == 'S')){// if se equals s or S calculate Schilling to Euro
		float sc = 0;
		cout << "Wieviel Schilling möchtest du umrechnen? :" << endl;
		cin >> sc;
		float eu = sc / COURSE;
		cout << sc << " Schilling sind:  " << eu << "Euro" << endl;
	}
	else if ((se == 'e') || (se == 'E')){ //if se equals E or e calculate Euros to Schilling 
		float eu = 0;
		cout << "Wieviel Euro möchtest du umrechnen? :" << endl;
		cin >> eu;
		float sc = eu*COURSE;
		cout << eu << " Euro sind:  " << sc << "Schiling" << endl;
	}
	else { // if the input is neither S,s,e,E 
		cout << "BITTE VERSUCH NACHZUDENKEN";
	}
	_getch();

}