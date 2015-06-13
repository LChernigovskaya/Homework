TEMPLATE = app
CONFIG += console
CONFIG -= app_bundle
CONFIG += c++11

SOURCES += main.cpp \
    arrayStack.cpp \
    linkedStack.cpp \
    calc.cpp \
    myException.cpp

include(deployment.pri)
qtcAddDeployment()

HEADERS += \
    stack.h \
    arrayStack.h \
    linkedStack.h \
    stackTest.h \
    calc.h \
    calcTest.h \
    myException.h

QT += testlib
