// 5Tetris.cpp
// Andreas Ranzmaier | 12.01.2021 | javidx9 followalong 
// Reason is relearning c++ syntax and hopefully a broader understanding of Structure 

#include <iostream>
#include <Windows.h>


using namespace std;

// ----------- Variables -------------
wstring tetromino[7];
int nFieldWidth = 12;
int nFieldHeight = 18;
unsigned char* pField = nullptr;

int nScreenWidth = 80;		// console Screensize X
int nScreenHeight = 30;		// console Screensize Y

// ----------- Methodes --------------
int Rotate(int px, int py, int r);

int main()
{
	// create assets / fills the tetromino array

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


	// initialises the playingfield as unsigned chars

	pField = new unsigned char[nFieldWidth * nFieldHeight]; // initialising
	for (int i = 0; i < nFieldWidth; i++) // setting the boundry 
	{
		for (int ii = 0; ii < nFieldHeight; ii++)
		{
			pField[ii * nFieldHeight + i] = (i == 0 || i == nFieldWidth || ii == nFieldHeight - 1) ? 9 : 0; // filling it with 9 if on the side and 0 if inside
		}
	}


	// creates screen buffer
	// replaces cw
	wchar_t* screen = new wchar_t[nScreenWidth * nScreenHeight];
	for (int i = 0; i < nScreenWidth * nScreenHeight; i++)
	{
		screen[i] = L' ';
	}
	HANDLE hConsole = CreateConsoleScreenBuffer(GENERIC_READ | GENERIC_WRITE, 0, NULL, CONSOLE_TEXTMODE_BUFFER, NULL);
	SetConsoleActiveScreenBuffer(hConsole);
	DWORD dwBytesWritten = 0;



	// Game Loops
	bool bGameOver = false;

	while (!bGameOver)
	{
		// Draw Field 
		// Display Frame
		for (int i = 0; i < nFieldWidth; i++)
		{
			for (int ii = 0; ii < nFieldHeight; ii++)
			{
				screen[(ii + 2) * nScreenWidth + (i + 2)] = L" OOOOOOO=#"[pField[ii * nFieldWidth + i]]; // L" OOOOOO" is the Template for the Tiels
			}
		}
		WriteConsoleOutputCharacter(hConsole, screen, nScreenWidth * nScreenHeight, { 0,0 }, &dwBytesWritten);
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

