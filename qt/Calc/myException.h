#pragma once

class MyException
{
public:
    MyException (const char *string);
    const char *message();

private:
    const char* const mString;
};
