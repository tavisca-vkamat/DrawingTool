using DrawPoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawHexagon
{
    public interface IHexagon
    {
        int side { get; set; }

        Point center { get; set; }

        void DrawHexagon();
    }
}
