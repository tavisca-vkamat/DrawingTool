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

            //draw rectangle
            e.Graphics.DrawRectangle(blackPen, rectangle.diagonalStartPoint.X, rectangle.diagonalStartPoint.Y, rectangle.diagonalEndPoint.X, rectangle.diagonalEndPoint.Y);
        }
    }
}
