using DrawPoint;

namespace DrawCircle
{
    public interface ICircle 
    {
        int radius { get; set; }

        Point center { get; set; }

        void DrawCircle();
    }
}