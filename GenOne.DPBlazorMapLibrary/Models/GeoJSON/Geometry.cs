using System.Text.Json.Serialization;

namespace GenOne.DPBlazorMapLibrary.Models.GeoJSON
{
    public class Geometry
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("coordinates")]
        public object[][][] Coordinates { get; set; }
    }

    [JsonSerializable(typeof(Geometry))]
    internal partial class GeometrySerializerContext : JsonSerializerContext
    { }
}