﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicsEditor
{
    class Line : Shape
    {
        private Pen pen = new Pen(Color.Black);
        private Point point1;
        private Point point2;

        public Line(Point firstCoord, Point secondCoord, ShapeBuilder builder)
        {
            this.Builder = builder;
            this.point1 = firstCoord;
            this.point2 = secondCoord;
            this.Selected = false;
            this.Visible = true;
        }
        
        public override void Draw(PaintEventArgs e)
        {
            if (Visible)
            {
                e.Graphics.DrawLine(pen, point1, point2);
                if (this.Selected)
                {
                    DrawSelection(e);
                }
            }
        }
        
        private void DrawSelection(PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(pen, new Rectangle(point1.X - 2, point1.Y - 2, 4, 4));
            e.Graphics.DrawEllipse(pen, new Rectangle(point2.X - 2, point2.Y - 2, 4, 4));
        }

        public override bool Contain(Point point)
        {
            if (MinDist(point) <= 15)
            {
                this.Selected = true;
                return true;
            }
            return false;
        }

        /// <summary>
        /// returns min distance from point to line
        /// if min distance is distance to end of line -- sets initPoint and selectedPoint
        /// </summary>
        private double MinDist(Point point)
        {
            Point vector1 = new Point(point.X - point1.X, point.Y - point1.Y);
            Point vector2 = new Point(point2.X - point1.X, point2.Y - point1.Y);
            if (ScalarProduct(vector1, vector2) < 0.0)
            {
                this.SelectedPoint = point1;
                this.InitPoint = point2;
                return Math.Sqrt(ScalarProduct(vector1, vector1));
            }
            else
            {
                Point vector3 = new Point(point.X - point2.X, point.Y - point2.Y);
                Point vector4 = new Point(-vector2.X, -vector2.Y);
                if (ScalarProduct(vector3, vector4) < 0.0)
                {
                    this.SelectedPoint = point2;
                    this.InitPoint = point1;
                    return Math.Sqrt(ScalarProduct(vector3, vector3));
                }
                else
                {
                    this.SelectedPoint = default(Point);
                    this.InitPoint = default(Point);
                    double cosAlpha = ScalarProduct(vector3, vector4) / (Math.Sqrt(ScalarProduct(vector3, vector3)) * Math.Sqrt(ScalarProduct(vector4, vector4)));
                    double sinAlpha = Math.Sqrt(1 - cosAlpha * cosAlpha);
                    return sinAlpha * Math.Sqrt(ScalarProduct(vector3, vector3));
                }
            }
        }

        /// <summary>
        /// Count scalar product of two vectors
        /// </summary>
        private double ScalarProduct(Point vector1, Point vector2) => vector1.X * vector2.X + vector1.Y * vector2.Y;
    }
}
