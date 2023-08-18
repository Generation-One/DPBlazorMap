using GenOne.DPBlazorMapLibrary.Components.Map;
using GenOne.DPBlazorMapLibrary.Models.Basics;
using GenOne.DPBlazorMapLibrary.Models.Layers.Markers;

namespace GenOne.DPBlazorMapLibrary.Factorys.Interfaces
{
    public interface IMarkerFactory
    {
        public Task<Marker> CreateMarker(LatLng latLng, MarkerOptions? options);
        public Task<Marker> CreateMarkerAndAddToMap(LatLng latLng, Map map, MarkerOptions? options);
    }
}
