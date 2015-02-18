#include <iostream>

using namespace std;

int findAlive(int count, int deleteNumber);

struct Soldier
{
    int number;
    Soldier *next;
};

int main()
{
    cout << "input count " << endl;
    int count = 0;
    cin >> count;
    cout << "input the number, which are deleted" << endl;
    int deleteNumber = 0;
    cin >> deleteNumber;
    cout << findAlive(count, deleteNumber);
    return 0;
}

int findAlive (int count, int deleteNumber)
{
    Soldier *ring = new Soldier;
    ring = nullptr;

    for (int i = count; i >= 1; i--)
    {
        Soldier *auxilary = new Soldier;
        auxilary->number = i;
        auxilary->next = ring;
        ring = auxilary;
    }

    Soldier *current = new Soldier;
    current = ring;
    while(current->next != nullptr)
        current = current->next;
    current->next = ring;

    Soldier *auxilary = new Soldier;
    auxilary = ring;
    while (auxilary->next != auxilary)
    {
        for (int i = 1; i < deleteNumber - 1; i++)
            auxilary = auxilary->next;

        Soldier *current = auxilary->next->next;
        delete auxilary->next;
        auxilary->next = current;
        auxilary = auxilary->next;
    }

    return auxilary->number;
}


