using GenOne.DPBlazorMapLibrary.Components.Map;
using GenOne.DPBlazorMapLibrary.Models.Basics;
using GenOne.DPBlazorMapLibrary.Models.Layers.VectorLayers.CircleMarkers;

namespace GenOne.DPBlazorMapLibrary.Factorys.Interfaces
{
    public interface ICircleMarkerFactory
    {
        Task<CircleMarker> CreateCircleMarker(LatLng latLng, CircleMarkerOptions? options);
        Task<CircleMarker> CreateCircleMarkerAndAddToMap(LatLng latLng, Map map, CircleMarkerOptions? options);
    }
}
