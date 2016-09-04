using DrawPoint;

namespace DrawLine
{
    /* interface for Line */
    public interface ILine
    {
        Point startPoint { get; set; }

        Point endPoint { get; set; }

        void DrawLine();
    }
}
