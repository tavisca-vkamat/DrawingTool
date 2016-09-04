using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawHexagon
{
    public partial class HexagonForm : Form
    {
        private IHexagon hexagon;

        public HexagonForm()
        {
            InitializeComponent();
        }

        public HexagonForm(IHexagon hexagon)
        {
            InitializeComponent();
            this.hexagon = hexagon;
            this.Paint += new PaintEventHandler(this.HexagoneForm_Paint);
        }
        public void HexagoneForm_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.FromArgb(255, 0, 0, 0), 5);
            int[] x = new int[6];
            int[] y = new int[6];
            /* find all coordinates of hexagone */
            for (int hexagoneCoordinates = 0; hexagoneCoordinates < 6; hexagoneCoordinates++)
            {
                x[hexagoneCoordinates] = hexagon.center.X + (int)((hexagon.side * Math.Cos(10 * Math.PI * hexagoneCoordinates / 6)));
                y[hexagoneCoordinates] = hexagon.center.Y + (int)((hexagon.side * Math.Sin(10 * Math.PI * hexagoneCoordinates / 6)));
            }

            /* draw lines of hexagone */
            for (int drawLines = 0; drawLines < 5; drawLines++)
                e.Graphics.DrawLine(blackPen, x[drawLines], y[drawLines], x[drawLines + 1], y[drawLines + 1]);
            e.Graphics.DrawLine(blackPen, x[5], y[5], x[0], y[0]);
        }
    }
}
