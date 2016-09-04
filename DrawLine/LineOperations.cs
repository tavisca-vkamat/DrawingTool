using DrawPoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawLine
{
    public class LineOperations : ILine
    {
        public Point endPoint
        {
            get;
            set;
        }

        public Point startPoint
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
