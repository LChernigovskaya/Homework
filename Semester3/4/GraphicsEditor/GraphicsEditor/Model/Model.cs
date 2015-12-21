using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicsEditor
{
    /// <summary>
    /// Keeps all elements
    /// </summary>
    class Model
    {
        private List<Shape> elements = new List<Shape>();
        private Shape currentElement = null;

        public Shape GetCurrentElement()
        {
            return this.currentElement;
        }


        /// <summary>
        /// current element becomes unselect, and changes
        /// </summary>=
        public void SetCurrentElement(Shape element)
        {
            this.UnselectCurrent();

            this.currentElement = element;

            if (this.currentElement != null)
            {
                this.currentElement.Selected = true;
            }
        }

        public void AddElement(Shape element)
        {
            this.elements.Add(element);
            this.currentElement = element;
            this.currentElement.Visible = true;
            this.currentElement.Selected = true;
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

        /// <summary>
        /// If findes shape, that intersects with point, return it
        /// else return null
        /// </summary>
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

        /// <summary>
        /// Checks if end of the current element is pressed
        /// </summary>
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
