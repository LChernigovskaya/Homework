#pragma once

struct TreeElement
{
    int value;
    TreeElement *rightChild;
    TreeElement *leftChild;
};

struct Tree
{
    TreeElement *root;
};

Tree *createTree();

bool isExist (int value, Tree *tree);

void addElement (int value, Tree *tree);

void printAscending (Tree *tree);

void printTree (Tree *tree);

void printDescending (Tree *tree);

void deleteTreeElement (int value, Tree *&tree);
