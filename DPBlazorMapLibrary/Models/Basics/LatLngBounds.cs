using System.Text.Json.Serialization;

namespace DPBlazorMapLibrary
{
    public class LatLngBounds
    {
        public LatLngBounds()
        {
        }

        public LatLngBounds(LatLng southwest, LatLng northeast)
        {
            SouthWest = southwest;
            NorthEast = northeast;
        }

        public LatLng SouthWest { get; set; }
        public LatLng NorthEast { get; set; }

        public IEnumerable<LatLng> ToLatLng()
        {
            return new List<LatLng>() { SouthWest, NorthEast };
        }
    }

    [JsonSerializable(typeof(LatLngBounds))]
    internal partial class LatLngBoundsSerializerContext : JsonSerializerContext
    { }
}
