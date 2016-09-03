using DrawPoint;

namespace DrawCircle
{
    public interface ICircle : IPoint
    {
        int radius { get; set; }

        IPoint center { get; set; }

        void DrawCircle();
    }
}