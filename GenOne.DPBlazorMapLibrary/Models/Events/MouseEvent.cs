using System.Text.Json.Serialization;
using GenOne.DPBlazorMapLibrary.Models.Basics;

namespace GenOne.DPBlazorMapLibrary.Models.Events
{
    public class MouseEvent : Event
    {
        /// <summary>
        /// The geographical point where the mouse event occurred.
        /// </summary>
        public LatLng LatLng { get; set; } = default!;

        /// <summary>
        /// Pixel coordinates of the point where the mouse event occurred relative to the map layer.
        /// </summary>
        public Point LayerPoint { get; set; } = default!;

        /// <summary>
        /// Pixel coordinates of the point where the mouse event occurred relative to the map сontainer.
        /// </summary>
        public Point ContainerPoint { get; set; } = default!;
    }

    [JsonSerializable(typeof(MouseEvent))]
    internal partial class MouseEventSerializerContext : JsonSerializerContext
    { }
}
