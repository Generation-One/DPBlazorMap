using GenOne.DPBlazorMapLibrary.Models.Events;
using Microsoft.JSInterop;

namespace GenOne.DPBlazorMapLibrary.JsInterops.Events
{
    public interface IEventedJsInterop
    {
        ValueTask OnCallback(DotNetObjectReference<Evented> eventedClass, IJSObjectReference eventedReference, string eventType);
    }
}
