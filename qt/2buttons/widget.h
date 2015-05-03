#pragma once

#include <QWidget>

namespace Ui {
class Widget;
}

class Widget : public QWidget
{
    Q_OBJECT

public:
    explicit Widget(QWidget *parent = 0);
    ~Widget();

private slots:
    void button1Pushed();
    void button2Pushed();

private:
    Ui::Widget *ui;
};
