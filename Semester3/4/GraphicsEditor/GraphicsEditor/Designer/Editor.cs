using System;
using System.Drawing;
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

        /// <summary>
        /// If press not cursor -- draw new shape by builder
        /// If press cursor -- new select command
        /// If press end of shape -- shape return her builder and builder init by point of lenght, which won't move
        /// </summary>
        private void pictureBoxMouseDown(object sender, MouseEventArgs e)
        {
            this.mouseDown = true;
            this.model.UnselectCurrent();
            if (!cursorSelected)
            {
                this.builder.Init(new Point(e.X, e.Y));
            }
            else
            {
                Command select = new SelectElementCommand(new Point(e.X, e.Y));
                this.controller.Push(select);
                if (model.HasSelectedPoint())
                {
                    this.builder = model.GetCurrentElement().Builder;
                    this.builder.Init(model.GetCurrentElement().InitPoint);
                }
                pictureBox1.Invalidate();
            }
        }

        /// <summary>
        /// If press not cursor -- builder draw shape
        /// If press cursor and press end of shape -- current element - unvisible and builder draw
        /// </summary>
        private void pictureBoxMouseMove(object sender, MouseEventArgs e)
        {
            if (this.mouseDown)
            {
                if (!cursorSelected)
                {
                    this.builder.Move(new Point(e.X, e.Y));
                    pictureBox1.Invalidate();
                    this.mouseMove = true;
                }
                else if (model.HasSelectedPoint())
                {
                    this.model.GetCurrentElement().Visible = false;
                    this.builder.Move(new Point(e.X, e.Y));
                    pictureBox1.Invalidate();
                    this.mouseMove = true;
                }
            }
        }

        /// <summary>
        /// builder draw new element and model draw all her elements
        /// </summary>
        private void pictureBoxPaint(object sender, PaintEventArgs e)
        {
            if (this.mouseMove)
            {
                this.builder.Draw(e);
            }
            this.model.Draw(e);
        }

        /// <summary>
        /// If mouse pressed and moved -- builder return product
        /// If we drew -- create add command
        /// If we moved current element -- create move command
        /// </summary>
        private void pictureBoxMouseUp(object sender, MouseEventArgs e)
        {
            if (mouseMove)
            {
                Shape newShape = this.builder.GetProduct();
                if (!cursorSelected)
                {
                    if (newShape != null)
                    {
                        Command addNewShape = new AddCommand(newShape);
                        this.controller.Push(addNewShape);
                    }
                }

                if (model.HasSelectedPoint())
                {
                    Command move = new MoveCommand(newShape);
                    this.controller.Push(move);
                }
                pictureBox1.Invalidate();
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

        /// <summary>
        /// builder initialize by new line builder
        /// </summary>
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

        /// <summary>
        /// creates remove command
        /// </summary>
        private void removeElementClick(object sender, EventArgs e)
        {
            Command removeElement = new RemoveCommand();
            this.controller.Push(removeElement);
            pictureBox1.Invalidate();
        }
    }
}
