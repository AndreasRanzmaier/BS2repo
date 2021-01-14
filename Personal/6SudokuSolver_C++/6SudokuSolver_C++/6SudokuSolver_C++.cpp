// Andreas Ranzmaier | 14.01.2021 | port from my c# file functioning 
// waiting to be made into an in delphi usable dll so i can make a grafikal representation out of it

#include <iostream>
#include <string>

//======================= GLOBAL VARIABLES ========================
const int row1 = 9;
const int collumn1 = 9;
int SudokuField[row1][collumn1];

using namespace std;

//=======================	   Methodes      ========================
bool Possible(int Row, int Collumn, int TryNumber);
int determineHaus(int Row, int Collumn);
void minxy(int haus, int& minx, int& miny);
void generateArrayOfString(string OneLine);
void solve();
string generateStringOfArray();

int main()
{
	string OneLiner = "010000030000000800026009000000107060900300001000000057100080005390050080050690000";
	generateArrayOfString(OneLiner);

	solve();

	string test = generateStringOfArray();
}

// makes an string out of the array
string generateStringOfArray()
{
	string tmpstr;
	for (int i = 0; i < row1; i++)
	{
		for (int ii = 0; ii < collumn1; ii++)
		{
		int tmpint = SudokuField[i][ii];
		
		tmpstr += to_string(tmpint);
		}
	}
	return tmpstr;
}

// solves the array with backtracking
void solve()
{
	//von [0,0] 
	for (int i = 0; i < row1; i++)
	{
		//bis [8,8]
		for (int j = 0; j < collumn1; j++)
		{
			if (SudokuField[i][j] == 0)
			{
				//für alle möglichen zahlen 1-9
				for (int n = 1; n < 10; n++)
				{

					if (Possible(i, j, n))
					{
						// ist möglich kann aber falsch sein 
						//todo: visualisierung 
						SudokuField[i][j] = n; //one free square less

						solve();

						//ausrechnen ob alle felder richtig belegt sind                                     
						int full = 0;
						for (int x = 0; x < row1; x++)
						{
							for (int y = 0; y < collumn1; y++)
							{
								full = full + SudokuField[x][y];
							}
						}
						if (full == 405)
						{
							return;
						}

						SudokuField[i][j] = 0;
					}
				}
				return;
			}
		}
	}
}

// checks if a specific number could be Theoretically places in a given spot
bool Possible(int Row, int Collumn, int tryNumber)
{
	//cant put a number somewhere if there already is one
	//find all the row numbers
	for (int i = 0; i < row1; i++)
	{
		if (SudokuField[Row][i] == tryNumber)
		{
			return false;
		}
	}

	//find all the collumn numbers
	for (int i = 0; i < collumn1; i++)
	{
		if (SudokuField[i][Collumn] == tryNumber)
		{
			return false;
		}
	}

	//find all the numbers in same square  
	int haus = determineHaus(Row, Collumn);
	int minx = 0;
	int miny = 0;

	minxy(haus, minx, miny);

	for (int x = minx; x < minx + 3; x++)
	{
		for (int y = miny; y < miny + 3; y++)
		{
			if (SudokuField[x][y] == tryNumber)
			{
				return false;
			}
		}
	}
	return true;
}

// determinesthe 3x3 Field in wich the field to check is 
int determineHaus(int Row, int Collumn)
{
	//ausgabe 1-9 je nach "Haus" also 3x3 kasten
	//147
	if (Row <= 2)
	{
		if (Collumn <= 2)
		{
			return 1;
		}
		else if (Collumn > 2 && Collumn <= 5)
		{
			return 4;
		}
		else
		{
			return 7;
		}
	}
	//258
	else if (Row > 2 && Row <= 5)
	{
		if (Collumn <= 2)
		{
			return 2;
		}
		else if (Collumn > 2 && Collumn <= 5)
		{
			return 5;
		}
		else
		{
			return 8;
		}
	}
	//369
	else if (Row > 5 && Row <= 8)
	{
		if (Collumn <= 2)
		{
			return 3;
		}
		else if (Collumn > 2 && Collumn <= 5)
		{
			return 6;
		}
		else
		{
			return 9;
		}
	}
	else
	{
		return 0;
	}
}

// checks the haus and sends back its top left corner 
void minxy(int haus, int& minx, int& miny)
{
	if (haus == 1)
	{
		minx = 0;
		miny = 0;
	}
	else if (haus == 2)
	{
		minx = 3;
		miny = 0;
	}
	else if (haus == 3)
	{
		minx = 6;
		miny = 0;
	}
	else if (haus == 4)
	{
		minx = 0;
		miny = 3;
	}
	else if (haus == 5)
	{
		minx = 3;
		miny = 3;
	}
	else if (haus == 6)
	{
		minx = 6;
		miny = 3;
	}
	else if (haus == 7)
	{
		minx = 0;
		miny = 6;
	}
	else if (haus == 8)
	{
		minx = 3;
		miny = 6;
	}
	else  //if haus = 9
	{
		minx = 6;
		miny = 6;
	}
}

// generate array from sudoku string 
void generateArrayOfString(string OneLine)
{
	int x = 0;

	//von [0,0] 
	for (int i = 0; i < row1; i++)
	{
		//bis [8,8]
		for (int j = 0; j < collumn1; j++)
		{
			string z = OneLine.substr(x, 1);
			SudokuField[i][j] = stoi(z);
			x++;
		}
	}
}
