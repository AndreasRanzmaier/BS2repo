#include<iostream>
#include<conio.h>
#include<math.h>

using namespace std;
void main(){
	double height = 0;
	double whight = 0;
	
	cout << "height[cm]:" <<  endl;
	cin >> height;
	
	double heightMeter = height / 100;
	
	cout << "whight[kg]:" <<  endl;
	cin >> whight;
	
	cout << "Your BMI is :" << endl;
	
	cout << whight / pow(heightMeter,2) <<"  kg/m^2"<< endl;
	_getch();
}