using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawLine
{
    public partial class LineForm : Form
    {
        private ILine line;

        public LineForm()
        {
            InitializeComponent();
        }

        public LineForm(ILine line)
        {
            InitializeComponent();
            this.line = line;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LineForm_Paint);
        }

        public void LineForm_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.Black, 3);

            // Draw line to screen.
            e.Graphics.DrawLine(blackPen, line.startPoint.X, line.startPoint.Y, line.endPoint.X, line.endPoint.Y);
        }
    }
}
