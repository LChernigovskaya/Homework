using System.Drawing;
using System.Windows.Forms;

namespace GraphicsEditor
{
    /// <summary>
    /// Interface for builder, which build shape
    /// </summary>
    interface ShapeBuilder
    {
        /// <summary>
        /// Sets starting pointer
        /// </summary>
        void Init(Point point);

        /// <summary>
        /// Sets second pointer for drawing;
        /// this pointer are chahging during mouse moving
        /// </summary>
        /// <param name="point"></param>
        void Move(Point point);

        /// <summary>
        /// Draws shape by 2 coordinates
        /// </summary>
        void Draw(PaintEventArgs e);

        /// <summary>
        /// Returns new shape
        /// </summary>
        Shape GetProduct();
    }
}
