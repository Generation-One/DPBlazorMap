using System.Text.Json.Serialization;

namespace GenOne.DPBlazorMapLibrary.Models.Events
{
    public class Event
    {
        public string Type { get; set; }
    }

    [JsonSerializable(typeof(Event))]
    internal partial class EventSerializerContext : JsonSerializerContext
    { }
}
