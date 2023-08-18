using GenOne.DPBlazorMapLibrary.JsInterops.Events;
using GenOne.DPBlazorMapLibrary.Models.Layers.VectorLayers.CircleMarkers;
using Microsoft.JSInterop;

namespace GenOne.DPBlazorMapLibrary.Models.Layers.VectorLayers.Circles
{
    /// <summary>
    /// A class for drawing circle overlays on a map. Extends CircleMarker.
    /// </summary>
    public class Circle : CircleMarker
    {
        public Circle(IJSObjectReference jsReference, IEventedJsInterop eventedJsInterop)
            : base(jsReference, eventedJsInterop)
        {
        }
    }
}
