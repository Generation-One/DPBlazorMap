using GenOne.DPBlazorMapLibrary.Models.Layers.OtherLayers.FeatureGroups;
using Microsoft.JSInterop;

namespace GenOne.DPBlazorMapLibrary.Models.Layers.OtherLayers.GeoJSON
{
    /// <summary>
    /// Represents a GeoJSON object or an array of GeoJSON objects. Allows you to parse GeoJSON data and display it on the map. Extends FeatureGroup.
    /// </summary>
    public class GeoJSONLayer : FeatureGroup
    {
        public GeoJSONLayer(IJSObjectReference jsReference) : base(jsReference)
        {
        }

    }
}
