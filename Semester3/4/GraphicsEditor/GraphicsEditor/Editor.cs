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
        private Model model;
        private Controller controller;
        private bool mouseDown = false;
        private bool mouseMove = false;
        private bool cursorSelected = false;
        Pen pen = new Pen(Color.Black, 4);

        public Editor()
        {
            this.model = new Model();
            this.controller = new Controller(this.model);
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
                Command select = new SelectElementCommand(e);
                this.controller.AddNewCommand(select);
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1MouseMove(object sender, MouseEventArgs e)
        {
            if (!cursorSelected && this.mouseDown)
            {
                this.builder.Move(e);
                pictureBox1.Invalidate();
                this.mouseMove = true;
            }
        }

        private void pictureBox1Paint(object sender, PaintEventArgs e)
        {
            if (this.mouseMove)
            {
                this.builder.Draw(e);
            }
            this.model.Draw(e);
        }

        private void pictureBox1MouseUp(object sender, MouseEventArgs e)
        {
            if (!cursorSelected)
            {
                Shape newShape = this.builder.GetProduct();
                if (newShape != null)
                {
                    Command addNewShape = new AddCommand(newShape);
                    this.controller.AddNewCommand(addNewShape);
                }
                this.mouseDown = false;
                this.mouseMove = false;
            }
        }

        private void redoClick(object sender, EventArgs e)
        {
            controller.Redo();
            pictureBox1.Invalidate();
        }

        private void undoClick(object sender, EventArgs e)
        {
            controller.Undo();
            pictureBox1.Invalidate();
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

        private void removeElementClick(object sender, EventArgs e)
        {
            Command removeElement = new RemoveCommand();
            this.controller.AddNewCommand(removeElement);
            pictureBox1.Invalidate();
        }
    }
}
