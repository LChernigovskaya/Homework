#include <iostream>
#include "list.h"

using namespace std;

int main()
{
   List *list1 = createList();

   addValue(list1, 4);
   addValue(list1, 3);
   addValue(list1, 2);
   addValue(list1, 1);

   printList(list1);
   cout << endl;
   if (existValue(list1, 0))
       cout << "exist" << endl;
   else
       cout << "do not exist" << endl;

   deleteList(list1);

   List *list2 = createList();

   addTail(list2, 4);
   addTail(list2, 3);
   addTail(list2, 2);
   addTail(list2, 1);

   printList(list2);
   cout << endl;

   deleteList(list2);

   List *list = createList();

   addInOrder(list, 2);
   addInOrder(list, 5);
   addInOrder(list, 6);
   addInOrder(list, 4);
   addInOrder(list, 1);
   addInOrder(list, 6);


   printList(list);
   deleteList(list);

   return 0;
}

