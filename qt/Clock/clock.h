#pragma once

#include <QWidget>
#include <QtGui>

namespace Ui {
class Clock;
}

class Clock : public QWidget
{
    Q_OBJECT

public:
    explicit Clock(QWidget *parent = 0);
    ~Clock();

protected:
    void paintEvent(QPaintEvent *event);

private slots:
    void checkedGMT(bool check);

private:
    Ui::Clock *ui;
    bool gmt;
};
