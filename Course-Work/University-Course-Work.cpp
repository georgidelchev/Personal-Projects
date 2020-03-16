
#include <iostream>

using namespace std;

#include <chrono>
#include <thread>

using namespace std::this_thread;
using namespace std::chrono;

float face(int);
float biggestA(float, float, int, int);

int br;
int k;

int main()
{
	cout << "                 #-----------------------------------#" << endl;
	cout << "                             Welcome to the " << endl;
	cout << "                        Rhombs calculator v1.0!" << endl;
	cout << "                 #-----------------------------------#" << endl;

	sleep_for(nanoseconds(10));
	sleep_until(system_clock::now() + seconds(2));

	cout << "                  Course work by Georgi Videv Delchev" << endl;
	cout << "                        for the discipline of " << endl;
	cout << "                    programming and using computers!" << endl;
	cout << "                 #-----------------------------------#" << endl;

	sleep_for(nanoseconds(10));
	sleep_until(system_clock::now() + seconds(2));

	cout << "                          <=> Let's begin! <=>" << endl;
	cout << "                 #-----------------------------------#" << endl;
	cout << endl;

	sleep_for(nanoseconds(20));
	sleep_until(system_clock::now() + seconds(3));

	int rhombNum = 0;
	float funResult;

	while (rhombNum <= 0)
	{
		cout << "> " << "Enter number of rhombs " << endl;
		cout << "  that you want to calculate!" << endl;
		cout << "=> "; cin >> rhombNum;
	}

	funResult = face(rhombNum);

	sleep_for(nanoseconds(30));
	sleep_until(system_clock::now() + seconds(3));

	char A;
	int sml = 1;
	char ch = sml;

	cout << "Do you like it?" << endl << "Type 'Y' (for yes) or 'N' (for no) : " << endl << ">";
	cin >> A;

	if (A == 'Y' || A == 'y')
	{
		cout << "Thanks! " << ch << ch << ch << endl;
	}

	else if (A == 'N' || A == 'n')
	{
		cout << "Tell me what to improve! " << endl;
	}

	else
	{
		cout << "There is no valid enter!" << endl;
	}

	sleep_for(nanoseconds(30));
	sleep_until(system_clock::now() + seconds(3));

	cout << endl;
	cout << endl;
	cout << "                   #-------------------------------#" << endl;
	cout << "                    Thanks for using my calculator!" << endl;
	cout << "                                  Bye!" << endl;
	cout << "                   #-------------------------------#" << endl;
	cout << endl;
	cout << endl;

	return 0;
}

float face(int rhombNum)
{
	float a, ha, big = 0.0, funResult = 0.0;
	int i, j;

	for (i = 1; i <= rhombNum;)
	{
		cout << "#-------------------------------------#" << endl;
		cout << "> " << "Enter side 'a' for rhomb " << "[" << i << "]" << ":" << " " << endl;
		cout << "=> "; cin >> a;

		cout << "> " << "Enter height 'ha' for rhomb " << "[" << i << "]" << ":" << " " << endl;
		cout << "=> "; cin >> ha;

		if (ha > a || ha == 0 || a == 0)
		{

			i = i;

			if (ha == 0)
			{
				cout << "=>>   Enter a value for [ha] greater than 0!" << endl;
				cout << "" << endl;
			}

			else if (a == 0)
			{
				cout << "=>>   Enter a value for [a] greater than 0!" << endl;
				cout << "" << endl;
			}

			else if (ha > a)
			{
				cout << "=>>   Value of 'ha' is too big!" << endl;
				cout << "=>>   Please enter a valid value for [ha]!" << endl;
			}
		}

		else
		{
			funResult = a * ha;
			cout << "  *Rhomb Area: " << "[" << funResult << " cm^2" << "]" << endl;
			j = i;
			big = biggestA(funResult, big, j, rhombNum);
			i++;
		}
	}
	cout << endl;
	cout << "  *The rhomb with the biggest area is: Rhomb " << "[" << br << "]" << " with: " << "[" << big << " cm^2" << "]" << endl;
	cout << endl;
	cout << endl;

	return funResult;
}

float biggestA(float funResult, float big, int j, int rhombNum)
{
	if (funResult > big)
	{
		big = funResult,
			br = j;
	}

	int rh = rhombNum;
	float* rhArray;
	rhArray = new float[rh];
	int count = 0;

	if (k < rh)
	{
		rhArray[k] = funResult;
		cout << "  *Array Element " << "#" << "[" << k << "]" << " have value: " << "[" << funResult << "]" << endl;
		k++;
	}

	return big;
}