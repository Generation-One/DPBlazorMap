using GenOne.DPBlazorMapLibrary.Components.Map;
using GenOne.DPBlazorMapLibrary.Models.Basics;
using GenOne.DPBlazorMapLibrary.Models.Layers.RasterLayers.VideoOverlays;

namespace GenOne.DPBlazorMapLibrary.Factorys.Interfaces
{
    public interface IVideoOverlayFactory
    {
        public Task<VideoOverlay> CreateVideoOverlay(string video, LatLngBounds bounds, VideoOverlayOptions? options);
        public Task<VideoOverlay> CreateVideoOverlayAndAddToMap(string video, Map map, LatLngBounds bounds, VideoOverlayOptions? options);
    }
}
