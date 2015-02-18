#pragma once

struct ListElement;

struct List;

List *createList();

void deleteList(List *list);

void addValue(List *list, int value);

void printList(List *list);

bool existValue(List *list, int value);

void addTail (List *list, int value);

void addInOrder (List *list, int value);
