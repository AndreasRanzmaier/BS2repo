// 2Structs.cpp : Diese Datei enthält die Funktion "main". Hier beginnt und endet die Ausführung des Programms.
//

#include <iostream>
#include <string>
using namespace std;

struct Player
{
    string DisplayName;
    int Level;
    float Health;

    void TakeDamage(float dmg)
    {
        Health -= dmg;
    }

    // alternative way to acces struct variables 
    int GetLevel()
    {
        if (Level > 9)
        {
            cout << "Level is allready geater than 9!";
        }
        return Level;
    }
};

int main()
{
    Player Paul;
    Paul.DisplayName = "Paulstar";
    Paul.Level = 1;
    Paul.Health = 100.f;
    
    cout << "p_1 level= " << Paul.GetLevel() << endl;

    system("pause");
}

