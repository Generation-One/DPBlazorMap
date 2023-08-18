using GenOne.DPBlazorMapLibrary.JsInterops.Events;
using GenOne.DPBlazorMapLibrary.Models.Layers.RasterLayers.ImageOverlays;
using Microsoft.JSInterop;

namespace GenOne.DPBlazorMapLibrary.Models.Layers.RasterLayers.VideoOverlays
{
    /// <summary>
    /// Used to load and display a video player over specific bounds of the map. Extends ImageOverlay.
    /// </summary>
    public class VideoOverlay : ImageOverlay
    {
        //TODO: add event Load

        public VideoOverlay(IJSObjectReference jsReference, IEventedJsInterop eventedJsInterop) : base(jsReference, eventedJsInterop)
        {
        }

        //TODO: getElement()

    }
}
