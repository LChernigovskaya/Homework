#include <iostream>

using namespace std;

void bubble(double array[]);

int const size = 10;

int main()
{
   double array[size];
   for (int i = 0; i < size; i++)
       cin >> array[i];
   bubble(array);

   for (int k = 0; k < size; k++)
        cout << array[k] << " ";
   return 0;
}

void bubble(double array[])
{
    for(int i = 0; i < size - 1; i++)
        for(int j = 0; j < size - 1 - i; j++)
        {
            double c = 0;
            if (array[j] > array[j+1])
            {
                c = array[j];
                array[j] = array[j + 1];
                array[j + 1] = c;
            }
        }
}
