#include <iostream>
#include "list.h"

using std::cout;

struct ListElement
{
    int value;
    ListElement *next;
};

struct List
{
    ListElement *head;
};



List *createList()
{
    List *list = nullptr;
    list = new List;
    list->head = nullptr;
    return list;
}

ListElement *createListElement(int value)
{
    ListElement *listElement = new ListElement;
    listElement->next = nullptr;
    listElement->value = value;
    return listElement;
}

void deleteList(List *list)
{
    while(list->head != nullptr)
    {
        ListElement *auxilary = list->head;
        list->head = list->head->next;
        delete auxilary;
    }
    delete list;
}


void addValue(List *list, int value)
{
    if (list->head == nullptr)
        list->head = createListElement(value);

    else
    {
        ListElement *auxilary = nullptr;
        auxilary = createListElement(value);
        auxilary->next = list->head;
        list->head = auxilary;
    }
}


void printList(List *list)
{
    ListElement *current = nullptr;
    current = list->head;
    while (current != nullptr)
    {
        cout << current->value;
        current = current->next;
    }
}


bool existValue(List *list, int value)
{
    ListElement *current = list->head;
    while (current->value != value && current->next != nullptr)
        current = current->next;
    return (current->value == value);
}

void addTail(ListElement *listElement, int value)
{
    if (listElement->next == nullptr)
    {
        listElement->next = createListElement(value);
        return;
    }

    addTail(listElement->next, value);
}


void addTail(List *list, int value)
{
    if (list->head == nullptr)
        list->head = createListElement(value);

    else
        addTail(list->head, value);
}



void addInOrder(List *list, int value)
{
    if (list->head == nullptr)
        list->head = createListElement(value);

    else
    {
        ListElement *current = list->head;
        if (current->value >= value)
        {
            addValue(list, value);
            return;
        }

        while (current->next != nullptr && current->next->value < value)
            current = current->next;
        if (current->next == nullptr)
        {
            addTail(current, value);
            return;
        }
        else
        {
            ListElement *auxilary = createListElement(value);
            auxilary->next = current->next;
            current->next = auxilary;
        }
    }

}
