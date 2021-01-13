#include<iostream>
#include<conio.h>
#include<math.h>

using namespace std;

void main(){
	int sec = 0;
	cout << "Input in seconds :" << endl;
	cin >> sec;	 

	int hour = sec / (3600);
	int min = (sec - (hour * 3600))/60;
	int sec2 = (sec - (hour * 3600)) % 60;

	cout << hour << endl;
	cout << min << endl;
	cout << sec2 << endl;

	_getch();
}