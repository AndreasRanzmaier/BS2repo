// 1Enums.cpp : Diese Datei enthält die Funktion "main". Hier beginnt und endet die Ausführung des Programms.
//

#include <iostream>
#include "1Enums.h"
using namespace std;

// ------------------------ Globale Variablen ------------------------
enum class PlayerStatus
{
	PS_Running,
	PS_Walking, 
	PS_Crouching
};

const float RunSpeed = 800.f;
const float WalkSpeed = 500.f;
const float CrouchSpeed = 300.f;

// ------------------------ Methoden Definitionen ------------------------
void UpdateMovementSpeed(PlayerStatus P_Status, float& speed);

int main()
{
	float MovementSpeed;
	PlayerStatus status = PlayerStatus::PS_Walking;

	UpdateMovementSpeed(status, MovementSpeed);
	cout << "MS = " << MovementSpeed << endl;

	system("pause");
}

void UpdateMovementSpeed(PlayerStatus P_Status, float& speed)
{
	switch (P_Status)
	{
	case PlayerStatus::PS_Running:
		speed = RunSpeed;
		break;
	case PlayerStatus::PS_Crouching:
		speed = WalkSpeed;
		break;
	case PlayerStatus::PS_Walking:
		speed = WalkSpeed;
		break;
	default:
		cout << "Err" << endl;
		speed = 0.0;
		break;
	}
}