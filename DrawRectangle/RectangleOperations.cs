using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrawPoint;

namespace DrawRectangle
{
    public class RectangleOperations : IRectangle
    {
        public Point diagonalEndPoint
        {
            get;
            set;
        }

        public Point diagonalStartPoint
        {
            get;
            set;
        }

        public void DrawRectangle()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RectangleForm(this));
        }
    }
}
