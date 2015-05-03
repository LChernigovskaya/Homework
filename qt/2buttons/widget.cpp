#include "widget.h"
#include "ui_widget.h"

Widget::Widget(QWidget *parent) :
    QWidget(parent),
    ui(new Ui::Widget)
{
    ui->setupUi(this);
    connect(ui->pushButton1, SIGNAL(clicked()), this, SLOT(button1Pushed()));
    connect(ui->pushButton2, SIGNAL(clicked()), this, SLOT(button2Pushed()));
}

Widget::~Widget()
{
    delete ui;
}

void Widget::button1Pushed()
{
    ui->pushButton1->setDisabled(true);
    ui->pushButton2->setEnabled(true);
}

void Widget::button2Pushed()
{
    ui->pushButton1->setEnabled(true);
    ui->pushButton2->setDisabled(true);
}
