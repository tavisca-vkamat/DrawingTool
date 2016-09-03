using DrawPoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawLine
{
    public class LineOperations : PointOperations, ILine
    {
        public IPoint endPoint
        {
            get;
            set;
        }

        public IPoint startPoint
        {
            get;
            set;
        }

        [STAThread]
        public void DrawLine()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LineForm(this));
        }
    }
}
