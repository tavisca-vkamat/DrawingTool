using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrawPoint;

namespace DrawCircle
{
    public class CircleOperations : PointOperations, ICircle
    {
        public IPoint center
        {
            get;
            set;
        }

        public int radius
        {
            get;
            set;
        }

        public void DrawCircle()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CircleForm(this));
        }
    }
}
