using System.Text.Json.Serialization;
using GenOne.DPBlazorMapLibrary.Models.BaseJsReferences;
using Microsoft.JSInterop;

namespace GenOne.DPBlazorMapLibrary.Models.Basics.Icons
{
    public class Icon : JsReferenceBase
    {
        public Icon(IJSObjectReference jsReference)
        {
            JsReference = jsReference;
        }

        
    }

    [JsonSerializable(typeof(Icon))]
    internal partial class IconSerializerContext : JsonSerializerContext
    { }
}
