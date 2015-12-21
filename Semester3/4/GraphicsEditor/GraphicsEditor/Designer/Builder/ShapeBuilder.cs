using System.Drawing;
using System.Windows.Forms;

namespace GraphicsEditor
{
    /// <summary>
    /// Interface for builder, which draws a shape in moving proccess and after this builds this shape
    /// </summary>
    interface ShapeBuilder
    {
        /// <summary>
        /// Sets starting point
        /// </summary>
        void Init(Point point);

        /// <summary>
        /// Sets second point for drawing (each shape(line, ellipse, rectangle etc) can be built by two points);
        /// this point are chahging during mouse moving
        /// </summary>
        /// <param name="point"></param>
        void Move(Point point);

        /// <summary>
        /// Draws shape by two points (each shape(line, ellipse, rectangle etc) can be built by two points)
        /// </summary>
        void Draw(PaintEventArgs e);
        
        /// <returns>Created shape</returns>
        Shape GetProduct();
    }
}
