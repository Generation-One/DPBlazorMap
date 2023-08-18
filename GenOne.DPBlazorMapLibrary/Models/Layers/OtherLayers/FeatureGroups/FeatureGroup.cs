using GenOne.DPBlazorMapLibrary.Models.Layers.OtherLayers.LayerGroups;
using Microsoft.JSInterop;

namespace GenOne.DPBlazorMapLibrary.Models.Layers.OtherLayers.FeatureGroups
{
    /// <summary>
    /// Extended LayerGroup that makes it easier to do the same thing to all its member layers:
    /// </summary>
    public class FeatureGroup : LayerGroup
    {
        //TODO: setStyle
        //TODO: bringToFront
        //TODO: bringToBack
        //TODO: getBounds

        public FeatureGroup(IJSObjectReference jsReference) : base(jsReference)
        {
        }

    }
}
