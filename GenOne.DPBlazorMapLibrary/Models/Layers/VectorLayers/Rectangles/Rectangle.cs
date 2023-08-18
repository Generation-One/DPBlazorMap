using GenOne.DPBlazorMapLibrary.JsInterops.Events;
using GenOne.DPBlazorMapLibrary.Models.Basics;
using GenOne.DPBlazorMapLibrary.Models.Layers.VectorLayers.Polygons;
using Microsoft.JSInterop;

namespace GenOne.DPBlazorMapLibrary.Models.Layers.VectorLayers.Rectangles
{
    /// <summary>
    /// A class for drawing rectangle overlays on a map. Extends Polygon.
    /// </summary>
    public class Rectangle : Polygon
    {
        public Rectangle(IJSObjectReference jsReference, IEventedJsInterop eventedJsInterop)
            : base(jsReference, eventedJsInterop)
        {
        }

        public override Task<LatLngBounds> GetBounds()
        {
            return base.GetBounds();
        }
    }
}
