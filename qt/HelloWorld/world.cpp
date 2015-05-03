#include "world.h"
#include "ui_world.h"

World::World(QWidget *parent) :
    QWidget(parent),
    ui(new Ui::World)
{
    ui->setupUi(this);
    connect(ui->pushButton, SIGNAL(clicked()), this, SLOT(close()));
}

World::~World()
{
    delete ui;
}
