using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrawPoint;

namespace DrawRectangle
{
    public class RectangleOperations : PointOperations, IRectangle
    {
        public IPoint diagonalEndPoint
        {
            get;
            set;
        }

        public IPoint diagonalStartPoint
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
