using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawTriangle
{
    public partial class TriangleForm : Form
    {
        private ITriangle triangle;

        public TriangleForm()
        {
            InitializeComponent();
        }

        public TriangleForm(ITriangle triangle)
        {
            InitializeComponent();
            this.triangle = triangle;
            this.Paint += new PaintEventHandler(this.TriangleForm_Paint);
        }

        public void TriangleForm_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.FromArgb(255, 0, 0, 0), 5);
            //draw triangle
            e.Graphics.DrawLine(blackPen, triangle.one.X, triangle.one.Y, triangle.two.X, triangle.two.Y);
            e.Graphics.DrawLine(blackPen, triangle.one.X, triangle.one.Y, triangle.three.X, triangle.three.Y);
            e.Graphics.DrawLine(blackPen, triangle.two.X, triangle.two.Y, triangle.three.X, triangle.three.Y);
        }
    }
}
