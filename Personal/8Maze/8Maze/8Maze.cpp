// 8Maze.cpp | Ranzmaier Andreas | 14.02.2021
//

#include <iostream>
#include <stack>
using namespace std;
#include "olcConsoleGameEngine.h"

class olc_Maze : public olcConsoleGameEngine
{
public:
	olc_Maze()
	{
		m_sAppName = L"Maze";
	}

private:
	int m_nMazeWidth;
	int m_nMazeHeight;
	int* m_maze;
	int m_nVisitedCells;

	stack<pair<int, int>> m_stack;

	enum
	{
		CELL_PATH_N = 0x01,
		CELL_PATH_E = 0x01,
		CELL_PATH_S = 0x01,
		CELL_PATH_W = 0x01,
		CELL_VISITED = 0x01,
	};


protected:
	virtual bool OnUserCreate()
	{
		// Maze parameters
		m_nMazeWidth = 40;
		m_nMazeHeight = 25;

		m_maze = new int[m_nMazeWidth*m_nMazeHeight];
		memset(m_maze, 0x00, m_nMazeWidth * m_nMazeHeight * sizeof(int));

		m_stack.push(make_pair(0, 0));
		m_maze[0] = CELL_VISITED;
		m_nVisitedCells = 1;
		return true;
	}

	virtual bool OnUserUpdate(float fElapsedTime)
	{
		// Drawing stuff 

		// Clear screen
		Fill(0, 0, m_nScreenWidth, m_nScreenHeight, L' ');

		// Draw Maze 
		for (int x = 0; x < m_nMazeWidth; x++)
		{
			for (int y = 0; y < m_nScreenHeight; y++)
			{
				if (m_maze[y * m_nMazeWidth + x] & CELL_VISITED)
				{
					Draw(x, y, PIXEL_SOLID, FG_WHITE);
				}
				else
				{
					Draw(x, y, PIXEL_SOLID, FG_BLUE);
				}
			}
		}
		return true;

	}
};


int main()
{
	// Seed random number generator
	//srand(clock());

	// Use olcConsoleGameEngine derived app
	olc_Maze game;
	game.ConstructConsole(160, 100, 8, 8);
	game.Start();

	return 0;
}