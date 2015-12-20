using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsEditor
{
    public partial class Editor : Form
    {
        private ShapeBuilder builder = new NullBuilder();
        private Model model = new Model();
        private Controller controller = new Controller();
        private Line line = new Line();
        private bool mouseDown = false;
        private bool cursorSelected = false;
        Pen pen = new Pen(Color.Black, 4);

        public Editor()
        {
            InitializeComponent();
        }

        private void pictureBox1MouseDown(object sender, MouseEventArgs e)
        {
            this.model.UnselectCurrent();
            if (!cursorSelected)
            {
                this.builder.Init(e);
                this.mouseDown = true;
            }
            else
            {
                model.FindIntersection(e, this.textBox1);
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1MouseMove(object sender, MouseEventArgs e)
        {
            if (!cursorSelected)
            {
                if (this.mouseDown == true)
                {
                    this.builder.Move(e);
                    pictureBox1.Invalidate();
                }
            }
        }

        private void pictureBox1Paint(object sender, PaintEventArgs e)
        {
            this.builder.Draw(e);
            this.model.Draw(e);
        }

        private void pictureBox1MouseUp(object sender, MouseEventArgs e)
        {
            if (!cursorSelected)
            {
                Shape newShape = this.builder.GetProduct();
                if (newShape != null)
                {
                    this.model.AddElement(newShape);
                }
                this.mouseDown = false;
            }
        }

        private void redoClick(object sender, EventArgs e)
        {
            //controller.Redo();
        }

        private void undoClick(object sender, EventArgs e)
        {
            //controller.Undo();
        }

        private void addLineClick(object sender, EventArgs e)
        {
            this.builder = new LineBuilder();
            addLine.BackColor = Color.Gray;
            cursorSelected = false;
            cursor.BackColor = Color.Empty;
        }

        private void cursorClick(object sender, EventArgs e)
        {
            this.cursorSelected = true;
            addLine.BackColor = Color.Empty;
            cursor.BackColor = Color.Gray;
        }
    }
}
