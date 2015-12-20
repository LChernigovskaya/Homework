using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (this.currentElement != null)
            {
                this.currentElement.SetSelected(false);
            }
            this.currentElement = element;
            if (this.currentElement != null)
            {
                this.currentElement.SetSelected(true);
            }
        }

        public void AddElement(Shape element)
        {
            this.elements.Add(element);
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

        public void RemoveAllElements()
        {
            this.elements.Clear();
        }

        public void Draw(PaintEventArgs e)
        {
            foreach (var element in elements)
            {
                element.Draw(e);
            }
        }

        public Shape FindIntersection(MouseEventArgs e)
        {
            int i = elements.Count - 1;
            while (i >= 0 && !(elements[i].Contain(e)))
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
                this.currentElement.SetSelected(false);
            }
        }

    }
}
