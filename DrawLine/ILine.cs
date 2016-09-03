using DrawPoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawLine
{
    /* interface for Line */
    public interface ILine
    {
        IPoint startPoint { get; set; }

        IPoint endPoint { get; set; }

        void DrawLine();
    }
}
