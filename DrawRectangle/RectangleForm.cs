using System.Drawing;
using System.Windows.Forms;

namespace DrawRectangle
{
    public partial class RectangleForm : Form
    {
        private IRectangle rectangle;

        public RectangleForm()
        {
            InitializeComponent();
        }

        public RectangleForm(IRectangle rectangle)
        {
            InitializeComponent();
            this.rectangle = rectangle;
            this.Paint += new PaintEventHandler(this.RectangleForm_Paint);
        }

        public void RectangleForm_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.FromArgb(255, 0, 0, 0), 5);
            int startPointX = (rectangle.diagonalStartPoint.X < rectangle.diagonalEndPoint.X) ? rectangle.diagonalStartPoint.X : rectangle.diagonalEndPoint.X;
            int startPointY = (rectangle.diagonalStartPoint.Y < rectangle.diagonalEndPoint.Y) ? rectangle.diagonalStartPoint.Y : rectangle.diagonalEndPoint.Y;

            int width = ((rectangle.diagonalStartPoint.X > rectangle.diagonalEndPoint.X) ? rectangle.diagonalStartPoint.X : rectangle.diagonalEndPoint.X)-startPointX;
            int height = ((rectangle.diagonalStartPoint.Y > rectangle.diagonalEndPoint.Y) ? rectangle.diagonalStartPoint.Y : rectangle.diagonalEndPoint.Y)-startPointY;

            //draw rectangle
            e.Graphics.DrawRectangle(blackPen, startPointX, startPointY, width, height);
        }
    }
}
