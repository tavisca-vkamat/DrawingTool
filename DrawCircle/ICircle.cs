using DrawPoint;

namespace DrawCircle
{
    public interface ICircle 
    {
        int radius { get; set; }

        IPoint center { get; set; }

        void DrawCircle();
    }
}