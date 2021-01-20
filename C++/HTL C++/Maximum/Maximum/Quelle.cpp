#include<iostream>
#include<conio.h>
#include<math.h>

using namespace std;


void main(){
	int n1 = 0;
	int n2 = 0;
	int n3 = 0;

	//input+Interface
	cout << "Number1:" << endl;
	cin >> n1;
	cout << "Number2:" << endl;
	cin >> n2;
	cout << "Number3:" << endl;
	cin >> n3; 

	int max = 0;
	int min = 0;
	
	//max 
	if ((n1 >= n2) && (n1 >= n3)){  //if n1 is bigger or equal to n2 and n1 is bigger or equal to n3 ..... n1 =max
		max = n1;
	}
	else if ((n2 >= n3) && (n2 >= n1)){ 
		max =  n2;
	}
	else if ((n3 >= n2) && (n3 >= n1)){ 
		max = n3;
	}

	//min
	if ((n1 <= n2) && (n1 <= n3)){
			min = n1;
	}
	else if ((n2 <= n3) && (n2 <= n1)){
			min = n2;
	}
	else if ((n3 <= n2) && (n3 <= n1)){
			min = n3;
		}

	//av
	int av = (n1 + n2 + n3) / 3;

	cout << max << endl;
	cout << min << endl;
	cout << av << endl;

	_getch();
	}