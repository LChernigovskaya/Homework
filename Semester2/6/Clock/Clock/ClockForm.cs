using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class ClockForm : Form
    {
        public ClockForm()
        {
            InitializeComponent();
        }

        float x2_min = 0;
        float y2_min = 0;
        float x2_sec = 0;
        float y2_sec = 0;
        float x2_h = 0;
        float y2_h = 0;

        private void pictureBoxForClock_Paint(object sender, PaintEventArgs e)
        {
            Pen penForClock = new Pen(Color.Blue, 7);
            Pen penForHour = new Pen(Color.Black, 6);
            Pen penForMinute = new Pen(Color.Black, 4);
            Pen penForSecond = new Pen(Color.Red, 1);
            Pen penForDevisions = new Pen(Color.Blue, 2);
            SolidBrush brushForClock = new SolidBrush(Color.SkyBlue);

            var width = pictureBoxForClock.Width;
            var height = pictureBoxForClock.Height;

            e.Graphics.TranslateTransform(width / 2, (height / 2));
            e.Graphics.DrawEllipse(penForClock, - (width / 2 - 10), -(height / 2 - 10), width - 20, height - 20);
            e.Graphics.FillEllipse(brushForClock, -(width / 2 - 10), -(height / 2 - 10), width - 20, height - 20);
            for (int i = 6; i < 360; i += 6)
            {
                e.Graphics.DrawLine(penForDevisions, (float)((width / 2 - 20) * Math.Cos(Math.PI * (i - 90) / 180)), (float)((height / 2 - 20) * Math.Sin(Math.PI * (i - 90) / 180)), (float)((width / 2 - 10) * Math.Cos(Math.PI * (i - 90) / 180)), (float)((height / 2 - 10) * Math.Sin(Math.PI * (i - 90) / 180)));
            }
            for (int i = 0; i < 360; i += 30)
            {
                e.Graphics.DrawLine(penForClock, (float)((width / 2 - 30) * Math.Cos(Math.PI * (i - 90) / 180)), (float)((height / 2 - 30) * Math.Sin(Math.PI * (i - 90) / 180)), (float)((width / 2 - 10) * Math.Cos(Math.PI * (i - 90) / 180)), (float)((height / 2 - 10) * Math.Sin(Math.PI * (i - 90) / 180)));
            }
            e.Graphics.DrawLine(penForMinute, 0, 0, x2_min, y2_min);
            e.Graphics.DrawLine(penForSecond, 0, 0, x2_sec, y2_sec);
            e.Graphics.DrawLine(penForHour, 0, 0, x2_h, y2_h);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float currentHour = DateTime.Now.Hour;
            float currentMinute = DateTime.Now.Minute;
            float currentSecond = DateTime.Now.Second;

            float fi_H = 30 * (currentHour + currentMinute / 60);
            float fi_M = 6 * currentMinute;
            float fi_S = 6 * currentSecond;

            var width = pictureBoxForClock.Width;
            var height = pictureBoxForClock.Height;

            x2_sec = (float)((width / 2 - 15) * Math.Cos(Math.PI * (fi_S - 90) / 180));
            y2_sec = (float)((height / 2 - 15) * Math.Sin(Math.PI * (fi_S - 90) / 180));

            x2_min = (float)((width / 2 - 25) * Math.Cos(Math.PI * (fi_M - 90) / 180));
            y2_min = (float)((height / 2 - 25) * Math.Sin(Math.PI * (fi_M - 90) / 180));

            x2_h = (float)((width / 2 - 55) * Math.Cos(Math.PI * (fi_H - 90) / 180));
            y2_h = (float)((height / 2 - 55) * Math.Sin(Math.PI * (fi_H - 90) / 180));

            pictureBoxForClock.Refresh();
        }
    }
}
