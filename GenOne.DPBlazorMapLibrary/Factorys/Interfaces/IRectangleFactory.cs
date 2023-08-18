using GenOne.DPBlazorMapLibrary.Components.Map;
using GenOne.DPBlazorMapLibrary.Models.Basics;
using GenOne.DPBlazorMapLibrary.Models.Layers.VectorLayers.Rectangles;

namespace GenOne.DPBlazorMapLibrary.Factorys.Interfaces
{
    public interface IRectangleFactory
    {
        Task<Rectangle> CreateRectangle(LatLngBounds latLngBounds, RectangleOptions? options);
        Task<Rectangle> CreateRectangleAndAddToMap(LatLngBounds latLngBounds, Map map, RectangleOptions? options);
    }
}
