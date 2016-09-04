using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrawPoint;
using System.Windows.Forms;

namespace DrawTriangle
{
    public class TriangleOperations : ITriangle
    {
        public Point one
        {
            get;
            set;
        }

        public Point three
        {
            get;
            set;
        }

        public Point two
        {
            get;
            set;
        }

        public void DrawTriangle()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TriangleForm(this));
        }
    }
}
