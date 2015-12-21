using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicsEditor
{
    class Model
    {
        private List<Shape> elements = new List<Shape>();
        private Shape currentElement = null;

        public Shape GetCurrentElement()
        {
            return this.currentElement;
        }

        public void SetCurrentElement(Shape element)
        {
            this.UnselectCurrent();

            this.currentElement = element;

            if (this.currentElement != null)
            {
                this.currentElement.Selected = true;
            }
        }

        public void MoveCurrentElement(Shape newShape)
        {
            this.currentElement.Move(newShape);
        }

        public void AddElement(Shape element)
        {
            this.elements.Add(element);
            this.currentElement = element;
            this.currentElement.Visible = true;
        }

        public void RemoveCurrentElement()
        {
            if (this.currentElement != null)
            {
                this.RemoveElement(this.currentElement);
            }
        }

        public void RemoveElement(Shape element)
        {
            this.elements.Remove(element);
        }

        public void Draw(PaintEventArgs e)
        {
            foreach (var element in elements)
            {
                element.Draw(e);
            }
        }

        public Shape FindIntersection(Point point)
        {
            int i = elements.Count - 1;
            while (i >= 0 && !(elements[i].Contain(point)))
            {
                i--;
            }
            if (i >= 0)
            {
                return elements[i];
            }
            return null;
        }

        public void UnselectCurrent()
        {
            if (this.currentElement != null)
            {
                this.currentElement.Selected = false;
            }
        }

        public bool HasSelectedPoint()
        {
            if (this.currentElement != null)
            {
                return this.currentElement.SelectedPoint != default(Point);
            }
            return false;
        }
    }
}
