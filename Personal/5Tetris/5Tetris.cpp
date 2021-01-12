// 5Tetris.cpp
// Andreas Ranzmaier | 12.01.2021 | javidx9 followalong 
// Reason is relearning c++ syntax and hopefully a broader understanding of Structure 

#include <iostream>
using namespace std;

wstring tetromino[7];

int main()
{
   // create assets 
	{
		tetromino[0].append(L"..X.");
		tetromino[0].append(L"..X.");
		tetromino[0].append(L"..X.");
		tetromino[0].append(L"..X.");

		tetromino[1].append(L"..X.");
		tetromino[1].append(L".XX.");
		tetromino[1].append(L".X..");
		tetromino[1].append(L"....");

		tetromino[2].append(L".X..");
		tetromino[2].append(L".XX.");
		tetromino[2].append(L"..X.");
		tetromino[2].append(L"....");

		tetromino[3].append(L"....");
		tetromino[3].append(L".XX.");
		tetromino[3].append(L".XX.");
		tetromino[3].append(L"....");

		tetromino[4].append(L"..X.");
		tetromino[4].append(L".XX.");
		tetromino[4].append(L"..X.");
		tetromino[4].append(L"....");

		tetromino[5].append(L".X..");
		tetromino[5].append(L".XX.");
		tetromino[5].append(L".X..");
		tetromino[5].append(L"....");

		tetromino[6].append(L"..X.");
		tetromino[6].append(L"..X.");
		tetromino[6].append(L".XX.");
		tetromino[6].append(L"....");

		tetromino[7].append(L".X..");
		tetromino[7].append(L".X..");
		tetromino[7].append(L".XX.");
		tetromino[7].append(L"....");
	}

}


