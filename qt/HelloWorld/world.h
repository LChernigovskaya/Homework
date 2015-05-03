#pragma once

#include <QWidget>

namespace Ui {
class World;
}

class World : public QWidget
{
    Q_OBJECT

public:
    explicit World(QWidget *parent = 0);
    ~World();

private:
    Ui::World *ui;
};

