using System.Text.Json.Serialization;

namespace DPBlazorMapLibrary
{
    public class Event
    {
        public string Type { get; set; }
    }

    [JsonSerializable(typeof(Event))]
    internal partial class EventSerializerContext : JsonSerializerContext
    { }
}
