// Getters and Setters 
// A way of changing private variables

#include <iostream>
#include <string>
using namespace std;

class Creature
{
public:
	Creature()
	{
		cout << "a creature has been created" << endl;
		Health = 100.f;
	}
	
	void SetName(string _Name)
	{
		Name = _Name;
	}

	string GetName()
	{
		return Name;
	}

	float GetHealth()
	{
		return Health;
	}

	void TakeDamage(float damage)
	{
		cout << "taking " << damage << " damage!" << endl;
		float Total;
		Total = Health - damage;
		
		if (Total <= 0.f)
			cout << GetName() << " has died";
		else
			Health -= damage;

		cout << "Health: " << GetHealth() << endl;
	}

private:
	float Health;
	string Name;

protected:
	// only accessible from this and child classes
	int NumberOfLimbs;
};

class Goblin : public Creature
{
public: 
	Goblin()
	{
		cout << "its a Goblin" << endl;
		NumberOfLimbs = 5;
		SetName("Doby");
	}
};

int main()
{
	Creature Igor;
	Igor.SetName("Igor");

	cout << "Name: " << Igor.GetName() << endl;
	cout << "Health: " << Igor.GetHealth() << endl;
	Igor.TakeDamage(34);


	Goblin Gobby;
	cout << Gobby.GetName() << endl;


	system("pause");
}

