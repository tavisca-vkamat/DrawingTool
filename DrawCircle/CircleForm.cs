using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawCircle
{
    public partial class CircleForm : Form
    {
        private ICircle circle;

        public CircleForm()
        {
            InitializeComponent();
        }

        public CircleForm(ICircle circle)
        {
            InitializeComponent();
            this.circle = circle;
            this.Paint += new PaintEventHandler(this.CircleForm_Paint);
        }
        public void CircleForm_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.FromArgb(255, 0, 0, 0), 5);

            //draw rectangle
            e.Graphics.DrawEllipse(blackPen, circle.center.X - circle.radius, circle.center.Y - circle.radius, (float)(Math.Sqrt(double.Parse("2"))) * circle.radius, (float)(Math.Sqrt(double.Parse("2"))) * circle.radius);
        }
    }
}
