using System.Text.Json.Serialization;

namespace GenOne.DPBlazorMapLibrary.Models.GeoJSON
{
    public class Crs
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("properties")]
        public object Properties { get; set; }
    }

    [JsonSerializable(typeof(Crs))]
    internal partial class CrsSerializerContext : JsonSerializerContext
    { }
}