#include <iostream>

#include "stack.h"
#include <fstream>

using std::cout;
using std::cin;
using std::endl;
using std::ifstream;

int main()
{
    Stack *stack = createStack();
    ifstream input("input.txt");

    if (!input.is_open())
    {
        cout << "File doesn't exist" << endl;
        return 0;
    }

    char symbol = ' ';
    while (input.get(symbol))
    {
        if (symbol == '(')
            push(symbol, stack);

        if (symbol == ')')
        {
            if (isEmpty(stack))
            {
                cout << "It's wrong" << endl;
                return 0;
            }
            else
                pop(stack);
        }
    }

    if (isEmpty(stack))
        cout << "It's right" << endl;
    else
        cout << "It's wrong" << endl;
    return 0;

    input.close();

    return 0;
}
