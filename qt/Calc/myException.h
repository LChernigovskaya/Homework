#pragma once

class MyException
{
public:
    MyException (const char *string);
    const char *errowString();

private:
    const char *mString;
};

