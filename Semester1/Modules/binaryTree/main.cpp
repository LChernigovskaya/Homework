#include <iostream>
using namespace std;

#include "tree.h"

int main()
{
    Tree *tree = createTree();
    addElement(10, tree);
    addElement(5, tree);
    addElement(3, tree);
    addElement(16, tree);
    addElement(13, tree);
    addElement(19, tree);
    addElement(20, tree);
    addElement(17, tree);
    printAscending(tree);
    cout << endl;
    printTree (tree);
    cout << endl;
    printDescending(tree);
    cout << endl;
    deleteTreeElement(16, tree);
    printTree(tree);

    return 0;
}

