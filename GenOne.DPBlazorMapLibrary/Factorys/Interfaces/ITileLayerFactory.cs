using GenOne.DPBlazorMapLibrary.Components.Map;
using GenOne.DPBlazorMapLibrary.Models.Layers.RasterLayers.TileLayers;

namespace GenOne.DPBlazorMapLibrary.Factorys.Interfaces
{
    public interface ITileLayerFactory
    {
        public Task<TileLayer> CreateTileLayer(string urlTemplate, TileLayerOptions? options);
        public Task<TileLayer> CreateTileLayerAndAddToMap(string urlTemplate, Map map, TileLayerOptions? options);
    }
}
