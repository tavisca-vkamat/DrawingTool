using DrawPoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawRectangle
{
    public interface IRectangle 
    {
        /*start point Diagonal*/
        IPoint diagonalStartPoint { get; set; }

        //end point diagonal
        IPoint diagonalEndPoint { get; set; }

        /* method to draw line takes line instance and draws on form */
        void DrawRectangle();
    }
}
