#include <iostream>

using namespace std;

void quickSort(double numbers[], int head, int tail);

void swap (double numbers[], int i, int j);

int main()
{
    cout << "input size" << endl;
    int size = 0;
    cin >> size;

    double numbers[size];
    for(int i = 0; i < size; i++)
        cin >> numbers[i];

    quickSort(numbers, 0, size - 1);

    for(int k = 0; k < size; k++)
       cout << numbers[k] << " ";

    return 0;
}

void quickSort(double numbers[], int head, int tail)
{
    double x = numbers[tail];
    int i = head;
    int j = tail - 1;
    while (i < j)
    {
        if ((numbers[i] <= x) || (numbers[j] >= x))
        {
            if (numbers[i] <= x)
                i++;
            if (numbers[j] >= x)
                j--;
        }
        else
        {
            swap(numbers, i, j);
            i++;
            j--;
        }
    }

    if (numbers[tail] < numbers[i])
        swap (numbers, tail, i);

    if (head < i)
        quickSort(numbers, head, i);
    if (i + 1 < tail)
        quickSort(numbers, i + 1, tail);
}

void swap (double numbers[], int i, int j)
{

    double c = numbers[i];
    numbers[i] = numbers[j];
    numbers[j] = c;
}
