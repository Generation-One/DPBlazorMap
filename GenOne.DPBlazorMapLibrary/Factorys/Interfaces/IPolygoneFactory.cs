using GenOne.DPBlazorMapLibrary.Components.Map;
using GenOne.DPBlazorMapLibrary.Models.Basics;
using GenOne.DPBlazorMapLibrary.Models.Layers.VectorLayers.Polygons;

namespace GenOne.DPBlazorMapLibrary.Factorys.Interfaces
{
    public interface IPolygoneFactory
    {
        Task<Polygon> CreatePolygon(IEnumerable<LatLng> latLngs, PolygonOptions? options);

        Task<Polygon> CreatePolygonAndAddToMap(IEnumerable<LatLng> latLngs, Map map, PolygonOptions? options);
    }
}
