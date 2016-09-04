using DrawPoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawTriangle
{
    public interface ITriangle
    {
        Point one {get;set;}
        Point two { get; set; }
        Point three { get; set; }
        void DrawTriangle();
    }
}
