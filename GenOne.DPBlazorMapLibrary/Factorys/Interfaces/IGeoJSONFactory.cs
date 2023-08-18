using GenOne.DPBlazorMapLibrary.Components.Map;
using GenOne.DPBlazorMapLibrary.Models.Layers.OtherLayers.GeoJSON;

namespace GenOne.DPBlazorMapLibrary.Factorys.Interfaces
{
    public interface IGeoJSONFactory
    {
        public Task<GeoJSONLayer> CreateGeoJSONLayer(object geojson, GeoJSONOptions? options);
        public Task<GeoJSONLayer> CreateGeoJSONLayerAndAddToMap(object geojson, Map map, GeoJSONOptions? options);
    }
}
