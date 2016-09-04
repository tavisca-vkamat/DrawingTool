using DrawPoint;

using System.Windows.Forms;

namespace DrawHexagon
{
    public class HexagonOperations : IHexagon
    {
        public Point center
        {
            get;
            set;
        }

        public int side
        {
            get;
            set;
        }

        public void DrawHexagon()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HexagonForm(this));
        }
    }
}
