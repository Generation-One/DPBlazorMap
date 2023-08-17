using Microsoft.JSInterop;
using System.Text.Json.Serialization;

namespace DPBlazorMapLibrary
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
