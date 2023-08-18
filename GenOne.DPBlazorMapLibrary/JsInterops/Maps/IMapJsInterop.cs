using GenOne.DPBlazorMapLibrary.JsInterops.Base;
using GenOne.DPBlazorMapLibrary.Models.Maps;
using Microsoft.JSInterop;

namespace GenOne.DPBlazorMapLibrary.JsInterops.Maps
{
    public interface IMapJsInterop : IBaseJsInterop
    {
        ValueTask<IJSObjectReference> Initialize(string id, MapOptions mapOptions);
    }
}
