#include <iostream>

using namespace std;

void merge (double numbers[], int left, int right);
void mergeSort (double numbers[], int left, int right);

int main()
{
    cout << "input size" << endl;
    int size = 0;
    cin >> size;
    int left = 0;
    int right = size - 1;
    double numbers[size];
    for(int i = 0; i < size; i++)
        cin >> numbers[i];

    mergeSort(numbers, 0, size - 1);

    for(int k = 0; k < size; k++)
       cout << numbers[k] << " ";

    return 0;
}

 void mergeSort (double numbers[], int left, int right)
 {

     if (left < right)
     {
         int middle = (left + right) / 2;
         mergeSort(numbers, left, middle);
         mergeSort(numbers, middle + 1, right);
         merge(numbers, left, right);
     }
 }

 void merge (double numbers[], int left, int right)
 {
     int mid = (left + right) / 2;
     double auxilaryArray[right - left + 1];
     int i = left;
     int j = mid + 1;
     int length = right - left + 1;
     while (i <= mid && j <= right)
     {
         if (numbers[i] < numbers[j])
         {
             auxilaryArray[i + j - left - mid - 1] = numbers[i];
             i++;
         }
         else
         {
             auxilaryArray[i + j - left - mid - 1] = numbers[j];
             j++;
         }
     }

     if (i > mid)
     {
        while (j <= right)
        {
            auxilaryArray[j - left] = numbers[j];
            j++;
        }
     }
     else
     {
         while (i <= mid)
         {
             auxilaryArray[j - mid + i - left - 1] = numbers[i];
             i++;
         }
     }
     for (int k = 0; k < length; k++)
         numbers[k + left] = auxilaryArray[k];
 }
