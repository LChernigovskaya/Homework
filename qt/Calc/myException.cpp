#include "myException.h"

MyException::MyException(const char *string) : mString(string)
{
}

const char *MyException::errowString()
{
    return mString;
}
