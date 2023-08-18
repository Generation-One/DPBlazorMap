namespace GenOne.DPBlazorMapLibrary.Models.Layers.OtherLayers.GeoJSON
{
    public class GeoJSONOptions : LayerOptions
    {
        /// <summary>
        /// Whether default Markers for "Point" type Features inherit from group options.
        /// </summary>
        public bool MarkersInheritOptions { get; set; } = false;
    }
}
