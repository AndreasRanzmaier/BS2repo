#include<iostream>
#include<conio.h>
#include<math.h>

using namespace std;

void main(){
	double S1 = 0;
	double S2 = 0;
	double S3 = 0;

	cout << "S1:" <<  endl;
	cin >> S1;
	cout << "S2:" << endl;
	cin >> S2;
	cout << "S3:" << endl;
	cin >> S3;
	 
	double S = (S1 + S2 + S3) / 2;

	double A = sqrt(S*(S - S1)*(S - S2)*(S - S3));
	cout << "A=" << endl;

	double Scope = S1 + S2 + S3;
	cout << "Scope=" << Scope << endl;


	_getch();
}