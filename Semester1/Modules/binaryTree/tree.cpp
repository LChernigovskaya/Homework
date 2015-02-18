#include <iostream>
#include "tree.h"

using std::cout;

Tree *createTree()
{
    Tree *tree = new Tree;
    tree->root = nullptr;
    return tree;
}

TreeElement *createTreeElement(int value)
{
    TreeElement *treeElement = new TreeElement;
    treeElement->value = value;
    treeElement->leftChild = nullptr;
    treeElement->rightChild = nullptr;
    return treeElement;
}
bool isExist(int value, TreeElement *treeElement)
{
    if (treeElement == nullptr)
        return false;

    if (treeElement->value == value)
        return true;

    if (treeElement->value > value)
        isExist(value, treeElement->leftChild);
    else
        isExist(value, treeElement->rightChild);
}



bool isExist(int value, Tree *tree)
{
   return isExist(value, tree->root);
}

void addElement(int value, TreeElement* &treeElement)
{
    if(treeElement == nullptr)
        treeElement = createTreeElement(value);
    else
    {
        if(treeElement->value > value)
            addElement(value, treeElement->leftChild);
        if(treeElement->value < value)
            addElement(value, treeElement->rightChild);
    }
}

void addElement(int value, Tree *tree)
{
   addElement(value, tree->root);
}

void printAscending(TreeElement *treeElement)
{
    if (treeElement == nullptr)
        return;
    printAscending(treeElement->leftChild);
    cout << treeElement->value << " ";
    printAscending(treeElement->rightChild);
}

void printAscending(Tree *tree)
{
    if (tree->root != nullptr)
        printAscending(tree->root);
}

void printTree(TreeElement *treeElement)
{
    if (treeElement == nullptr)
    {
        cout << "null";
        return;
    }
    cout << treeElement->value << "( ";
    printTree (treeElement->leftChild);
    cout << " ";
    printTree (treeElement->rightChild);
    cout << " )";
}

void printTree(Tree *tree)
{
    if (tree->root != nullptr)
        printTree(tree->root);
}

void printDescending(TreeElement *treeElement)
{
    if (treeElement == nullptr)
        return;
    printDescending(treeElement->rightChild);
    cout << treeElement->value << " ";
    printDescending(treeElement->leftChild);
}

void printDescending(Tree *tree)
{
    if (tree->root != nullptr)
        printDescending(tree->root);
}

TreeElement *exist(int value, TreeElement *treeElement)
{
    if (treeElement == nullptr)
        return nullptr;

    if (treeElement->value == value)
        return treeElement;

    if (treeElement->value > value)
        exist(value, treeElement->leftChild);
    else
        exist(value, treeElement->rightChild);
}

TreeElement *exist(int value, Tree *tree)
{
    return exist(value, tree->root);
}

int findMin (TreeElement *treeElement)
{
    if(treeElement->leftChild == nullptr)
        return treeElement->value;
    else
        return findMin(treeElement->leftChild);
}

void deleteTreeElement(int value, TreeElement* &treeElement)
{
    if (treeElement == nullptr)
        return;

    if (treeElement->value == value)
    {
        if (treeElement->leftChild == nullptr && treeElement->rightChild == nullptr)
        {
            delete treeElement;
            treeElement = nullptr;
            return;
        }
        if (treeElement->leftChild != nullptr && treeElement->rightChild == nullptr)
        {
            TreeElement *auxilary = treeElement->leftChild;
            delete treeElement;
            treeElement = auxilary;
            return;
        }
        if (treeElement->leftChild == nullptr && treeElement->rightChild != nullptr)
        {
            TreeElement *auxilary = treeElement->rightChild;
            delete treeElement;
            treeElement = auxilary;
            return;
        }
        if (treeElement->leftChild != nullptr && treeElement->rightChild != nullptr)
        {
            int newValue = findMin(treeElement->rightChild);
            deleteTreeElement(newValue, treeElement);
            treeElement->value = newValue;
            return;
        }
    }
    else
    {
        if (treeElement->value > value)
            deleteTreeElement(value, treeElement->leftChild);
        else
            deleteTreeElement(value, treeElement->rightChild);
    }

}

void deleteTreeElement(int value, Tree* &tree)
{
    deleteTreeElement(value, tree->root);
}
