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

        public void AddElement(Shape element)
        {
            this.elements.Add(element);
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

        public void FindIntersection(MouseEventArgs e, TextBox tb)
        {
            int i = elements.Count - 1;
            while (i >= 0 && !(elements[i].Contain(e, tb)))
            {
                i--;
            }
            if (i >= 0)
            {
                this.currentElement = elements[i];
            }
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
