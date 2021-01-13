#include<iostream>
#include<conio.h>
#include<math.h>

using namespace std;

void main(){
	int h1 = 0;
	int m1 = 0;
	int s1 = 0;
	int h2 = 0;
	int m2 = 0;
	int s2 = 0;

	cout << "Input 2 different Times :" << endl;

	//input t1
	cout << "h1 :";
	cin >> h1;
	cout << endl; 

	cout << "m1 :";
	cin >> m1;
	cout << endl;

	cout << "s1 :";
	cin >> s1;
	cout << endl;
	//input t2
	cout << "h2 :";
	cin >> h2;
	cout << endl;

	cout << "m2 :";
	cin >> m2;
	cout << endl;

	cout << "s2 :";
	cin >> s2;
	cout << endl;


	//definition t1 and t2 in seconds 
	int t1 = (h1 * 3600)+(m1*60)+s1;
	int t2 = (h2 * 3600) + (m2 * 60) + s2;
	//t3 in seconds 
	int t3sec = t1 - t2;
	 //t3 in from sec to h/m/s

	int hour = t3sec / (3600);
	int min = (t3sec - (hour * 3600)) / 60;
	int sec2 = (t3sec - (hour * 3600)) % 60;

	cout << hour << endl;
	cout << min << endl;
	cout << sec2 << endl;


	_getch();
}