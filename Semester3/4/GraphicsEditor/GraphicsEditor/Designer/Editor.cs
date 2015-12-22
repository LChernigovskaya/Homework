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

        public Editor()
        {
            this.model = new Model();
            this.controller = new Controller(this.model);
            InitializeComponent();
        }

        /// <summary>
        /// If cursor isn't pressed - draw new shape by builder
        /// If cursor is pressed - select shape
        /// If press end of shape - builder is inited by this shape builder
        /// </summary>
        private void SceneMouseDown(object sender, MouseEventArgs e)
        {
            this.mouseDown = true;
            this.model.UnselectCurrent();

            if (!cursorSelected)
            {
                this.builder.Init(new Point(e.X, e.Y));
            }
            else
            {
                Command selectCommand = new SelectElementCommand(new Point(e.X, e.Y));
                this.controller.Handle(selectCommand);

                if (model.HasSelectedPoint())
                {
                    this.builder = model.GetCurrentElementBuilder();
                    this.builder.Init(model.GetCurrentElementInitPoint());
                }

                scene.Invalidate();
            }
        }

        /// <summary>
        /// Builder draws a shape
        /// If end of shape is pressed then current element is unvisible and builder draws new
        /// </summary>
        private void SceneMouseMove(object sender, MouseEventArgs e)
        {
            if (this.mouseDown)
            {
                if (!cursorSelected || (cursorSelected && model.HasSelectedPoint()))
                {
                    this.builder.Move(new Point(e.X, e.Y));
                    this.mouseMove = true;
                }

                if (cursorSelected && model.HasSelectedPoint())
                {
                    this.model.GetCurrentElement().Visible = false;
                }

                scene.Invalidate();
            }
        }

        /// <summary>
        /// Builder draws a new element and model redraws all its elements
        /// </summary>
        private void scenePaint(object sender, PaintEventArgs e)
        {
            if (this.mouseMove)
            {
                this.builder.Draw(e);
            }

            this.model.Draw(e);
        }

        /// <summary>
        /// If mouse was pressed and moved -- builder returns product
        /// If user drew -- create add command
        /// If user moved current element -- create move command
        /// </summary>
        private void sceneMouseUp(object sender, MouseEventArgs e)
        {
            if (mouseMove)
            {
                Shape newShape = this.builder.GetProduct();

                if (!cursorSelected)
                {
                    if (newShape != null)
                    {
                        Command addCommand = new AddCommand(newShape);
                        this.controller.Handle(addCommand);
                    }
                }
                else if (model.HasSelectedPoint())
                {
                    Command moveCommand = new MoveCommand(newShape);
                    this.controller.Handle(moveCommand);
                }
                
                scene.Invalidate();
            }

            this.mouseDown = false;
            this.mouseMove = false;
        }
        
        private void undoClick(object sender, EventArgs e)
        {
            controller.Undo();
            scene.Invalidate();
        }

        private void redoClick(object sender, EventArgs e)
        {
            controller.Redo();
            scene.Invalidate();
        }

        /// <summary>
        /// Builder is initialized by new line builder
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
        /// Creates remove command
        /// </summary>
        private void removeElementClick(object sender, EventArgs e)
        {
            Command removeElement = new RemoveCommand();
            this.controller.Handle(removeElement);
            scene.Invalidate();
        }
    }
}
