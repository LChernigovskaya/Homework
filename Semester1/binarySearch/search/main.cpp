#include <iostream>

using namespace std;
int binarySearch (int numbers[], int size, int n);
int main()
{
    cout << "input size" << endl;
    int size = 0;
    cin >> size;
    int numbers[size];
    cout << "input the array in right order" << endl;
    for(int i = 0; i < size; i++)
        cin >> numbers[i];

    cout << "input n" << endl;
    int n = 0;
    cin >> n;

    if (binarySearch(numbers, size, n) == -1)
        cout << "don't exist such element";
    else
        cout << binarySearch(numbers, size, n);

    return 0;
}

int binarySearch (int numbers[], int size, int n)
{
    int left = 0;
    int right = size;
    int middle = 0;
    while (left < right)
    {
        middle = left + (left + right) / 2;
        if (numbers[middle] < n)
            left = middle + 1;
        else
        if (numbers[middle] > n)
            right = middle - 1;
        else
            return middle;
    }
    return -1;
}
