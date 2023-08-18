using GenOne.DPBlazorMapLibrary.Components.Map;
using GenOne.DPBlazorMapLibrary.Models.Basics;
using GenOne.DPBlazorMapLibrary.Models.Layers.VectorLayers.Circles;

namespace GenOne.DPBlazorMapLibrary.Factorys.Interfaces
{
    public interface ICircleFactory
    {
        Task<Circle> CreateCircle(LatLng latLng, CircleOptions? options);
        Task<Circle> CreateCircleAndAddToMap(LatLng latLng, Map map, CircleOptions? options);
    }
}
