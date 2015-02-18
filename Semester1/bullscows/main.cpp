#include <iostream>
#include <stdlib.h>
#include <time.h>

using namespace std;
void fillRandom(int guessNumber[],int size);
void answer (int guessNumbers[], int numbers[], int size);
int main()
{
    srand(time(0));
    int size = 4;
    int guessNumbers[size];
    fillRandom(guessNumbers, size);
    for(int i = 0; i < size; i++)
        cout << guessNumbers[i];
    cout << endl << "input numbers" << endl;
    int numbers[size];
    for(int i = 0; i < size; i++)
    {
        char symbol = ' ';
        cin >> symbol;
        numbers[i] = (int)(symbol - '0');
    }
    answer(guessNumbers, numbers, size);
    return 0;
}

void fillRandom(int guessNumber[],int size)
{
    int newRandomNumber = 0;
    for (int i = 0; i < size; i++)
    {
        bool hasSimilar = true;
        while (hasSimilar)
        {
            hasSimilar = false;
            newRandomNumber = rand() % 10;
            for (int j = 0; j < i; j++)
                if (guessNumber[j] == newRandomNumber)
                    hasSimilar = true;
        }

        guessNumber[i] = newRandomNumber;
    }
}

void answer (int guessNumbers[], int numbers[], int size)
{
    int countBulls = 0;
    int countCows = 0;
    for (int i = 0; i < size; i++)
    {
        if (guessNumbers[i] == numbers[i])
            countBulls++;
        for (int j = 0; j < size; j++)
        {
            if (guessNumbers[i] == numbers[j])
                countCows++;
        }
    }
    cout << countBulls << "Bulls" << endl;
    cout << countCows << "Cows" << endl;
}

int countCows(int guessNumbers[], int numbers[], int size)
{

}
