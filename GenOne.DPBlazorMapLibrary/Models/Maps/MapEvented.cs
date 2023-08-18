using GenOne.DPBlazorMapLibrary.JsInterops.Events;
using GenOne.DPBlazorMapLibrary.Models.Events;
using Microsoft.JSInterop;

namespace GenOne.DPBlazorMapLibrary.Models.Maps
{
    public class MapEvented : Evented
    {
        public MapEvented(IJSObjectReference jsReference, IEventedJsInterop eventedJsInterop)
        {
            JsReference = jsReference;
            EventedJsInterop = eventedJsInterop;
        }
    }
}
