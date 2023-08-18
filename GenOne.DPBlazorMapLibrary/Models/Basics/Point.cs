using System.Text.Json.Serialization;

namespace DPBlazorMapLibrary
{
    public class Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; }
        public int Y { get; }
    }

    [JsonSerializable(typeof(Point))]
    internal partial class PointSerializerContext : JsonSerializerContext
    { }
}
