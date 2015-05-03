#include "stackTest.h"
#include "calcTest.h"
#include "calc.h"
#include "linkedStack.h"
using namespace std;

int main()
{
    StackTest stackTest;
    QTest::qExec(&stackTest);

    CalcTest calcTest;
    QTest::qExec(&calcTest);
}

