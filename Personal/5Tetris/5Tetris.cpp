// 5Tetris.cpp
// Andreas Ranzmaier | 12.01.2021 | javidx9 followalong 
// Reason is relearning c++ syntax and hopefully a broader understanding of Structure 

#include <iostream>
using namespace std;
// ----------- Variables -------------
wstring tetromino[7];
int nFieldWidth = 12;
int nFieldHeight = 18;
unsigned char* pField = nullptr;

// ----------- Methodes --------------
int Rotate(int px, int py, int r);

int main()
{
	// create assets / fills the tetromino array
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

		tetromino[5].append(L"..X.");
		tetromino[5].append(L"..X.");
		tetromino[5].append(L".XX.");
		tetromino[5].append(L"....");

		tetromino[6].append(L".X..");
		tetromino[6].append(L".X..");
		tetromino[6].append(L".XX.");
		tetromino[6].append(L"....");
	}

	// initialises the playingfield as unsigned chars
	{
		pField = new unsigned char[nFieldWidth * nFieldHeight];
		for (int i = 0; i < nFieldWidth; i++)
		{
			for (int ii = 0; ii < nFieldHeight; ii++)
			{
				pField[ii * nFieldHeight + i] = (i == 0 || i == nFieldWidth);
			}
		}
	}
	int temp = Rotate(4, 4, 3);
	cout << temp;


}

int Rotate(int px, int py, int r)
{
	switch (r % 4)
	{
	case 0: return py * 4 + px;			// 0 deg
	case 1: return 12 + py - (px * 4);	// 90 deg
	case 2: return 15 - (py * 4) - px;	// 180 deg
	case 3: return 3 - py + (px * 4);	// 270 deg
	}
	return 0;
}

