#include "clock.h"
#include "ui_clock.h"

Clock::Clock(QWidget *parent) :
    QWidget(parent),
    ui(new Ui::Clock),
    gmt(false)
{
    ui->setupUi(this);
    connect(ui->GMT, SIGNAL(toggled(bool)), this, SLOT(checkedGMT(bool)));
    QTimer *timer = new QTimer(this);
    connect(timer, SIGNAL(timeout()), this, SLOT(update()));
    timer->start(1000);
}

Clock::~Clock()
{
    delete ui;
}

void Clock::paintEvent(QPaintEvent *event)
{
    static const QPoint hourHand[3] = {
        QPoint(7, 8),
        QPoint(-7, 8),
        QPoint(0, -100)
    };
    static const QPoint minuteHand[3] = {
        QPoint(7, 8),
        QPoint(-7, 8),
        QPoint(0, -150)
    };
    static const QPoint secondHand[3] = {
        QPoint(7, 8),
        QPoint(-7, 8),
        QPoint(0, -180)
    };

    QTime time = QTime::currentTime();
    if (gmt)
    {
        time.setHMS(QTime::currentTime().hour() - 3,
                    QTime::currentTime().minute(),
                    QTime::currentTime().second());
    }
    int side = qMin(width(), height());

    QPainter painter(this);
    painter.setRenderHint(QPainter::Antialiasing);
    painter.translate(width() / 2, height() / 2);
    painter.scale(side / 400.0, side / 400.0);

    QColor hourColor(127, 0, 127);
    QColor minuteColor(0, 127, 127, 191);
    QColor secondColor(127, 127, 0, 180);

    painter.setPen(Qt::NoPen);
    painter.setBrush(hourColor);
    painter.save();
    painter.rotate(30.0 * ((time.hour() + time.minute() / 60.0)));
    painter.drawConvexPolygon(hourHand, 3);
    painter.restore();

    painter.setPen(Qt::NoPen);
    painter.setBrush(minuteColor);
    painter.save();
    painter.rotate(6.0 * ((time.minute() + time.second() / 60.0)));
    painter.drawConvexPolygon(minuteHand, 3);
    painter.restore();

    painter.setPen(Qt::NoPen);
    painter.setBrush(secondColor);
    painter.save();
    painter.rotate(6.0 * time.second());
    painter.drawConvexPolygon(secondHand, 3);
    painter.restore();

    QPen clockPen(Qt::gray);
    clockPen.setWidth(7);
    painter.setPen(clockPen);
    painter.setBrush(Qt::NoBrush);
    QRect rect(-180, -180, 360, 360);
    painter.drawEllipse(rect);

    for (int i = 0; i < 12; ++i)
    {
        painter.drawLine(155, 0, 173, 0);
        painter.rotate(30.0);
    }

    clockPen.setWidth(2);
    painter.setPen(clockPen);

    for (int i = 0; i < 60; ++i)
    {
        if ((i % 5) != 0)
            painter.drawLine(173, 0, 160, 0);
        painter.rotate(6.0);
    }
}

void Clock::checkedGMT(bool check)
{
    gmt = check;
}



