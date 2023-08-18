using System.Text.Json.Serialization;

namespace GenOne.DPBlazorMapLibrary.Models.GeoJSON
{
    public class Feature
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("properties")]
        public object Properties { get; set; }

        [JsonPropertyName("geometry")]
        public Geometry Geometry { get; set; }
    }

    [JsonSerializable(typeof(Feature))]
    internal partial class FeatureSerializerContext : JsonSerializerContext
    { }
}