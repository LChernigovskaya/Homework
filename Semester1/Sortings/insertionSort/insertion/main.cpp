#include <iostream>

using namespace std;

void insertionSort(double numbers[]);
void swap (double numbers[], int i, int j);

int const size = 10;

int main()
{
    double numbers[size];
    for(int i = 0; i < size; i++)
        cin >> numbers[i];

    insertionSort(numbers);

    for(int k = 0; k < size; k++)
       cout << numbers[k] << " ";

    return 0;
}

void insertionSort(double numbers[])
{
    for (int i = 1; i < size; i++)
       while ((i > 0) && (numbers[i] < numbers[i - 1]) )
        {
            swap(numbers, i, i-1);
            i--;
        }
}

void swap (double numbers[], int i, int j)
{
    double c = numbers[i];
    numbers[i] = numbers[j];
    numbers[j] = c;
}
