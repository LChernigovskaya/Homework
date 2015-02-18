#include <iostream>

using namespace std;

void selectionSort (double numbers[]);

int const size = 10;

int main()
{
    double numbers[size];
    for(int i = 0; i < size; i++)
        cin >> numbers[i];

    selectionSort(numbers);

    for(int k = 0; k < size; k++)
       cout << numbers[k] << " ";

    return 0;
}
void swap (double numbers[], int i, int j)
{
    double c = numbers[i];
    numbers[i] = numbers[j];
    numbers[j] = c;
}

int findMin(double numbers[], int head, int tail)
{
    int minIndex = head;
    for (int i = head + 1; i <= tail; i++)
        if (numbers[i] < numbers[minIndex])
            minIndex = i;
    return minIndex;
}

void selectionSort (double numbers[])
{
    for (int i = 0; i < size; i++)
    {
        int min = findMin(numbers, i, size - 1);
        swap (numbers, i, min);
    }
}

