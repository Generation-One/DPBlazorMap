using GenOne.DPBlazorMapLibrary.Components.Map;
using GenOne.DPBlazorMapLibrary.Models.Basics;
using GenOne.DPBlazorMapLibrary.Models.Layers.RasterLayers.ImageOverlays;

namespace GenOne.DPBlazorMapLibrary.Factorys.Interfaces
{
    internal interface IImageOverlayFactory
    {
        public Task<ImageOverlay> CreateImageOverlay(string imageUrl, LatLngBounds bounds, ImageOverlayOptions? options);
        public Task<ImageOverlay> CreateImageOverlayAndAddToMap(string imageUrl, Map map, LatLngBounds bounds, ImageOverlayOptions? options);
    }
}
