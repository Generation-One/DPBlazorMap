using GenOne.DPBlazorMapLibrary.Components.Map;
using GenOne.DPBlazorMapLibrary.Models.Basics;
using GenOne.DPBlazorMapLibrary.Models.Layers.VectorLayers.Polylines;

namespace GenOne.DPBlazorMapLibrary.Factorys.Interfaces
{
    public interface IPolylineFactory
    {
        Task<Polyline> CreatePolyline(IEnumerable<LatLng> latLng, PolylineOptions? options);
        Task<Polyline> CreatePolylineAndAddToMap(IEnumerable<LatLng> latLng, Map map, PolylineOptions? options);

    }
}
