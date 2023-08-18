using Microsoft.JSInterop;

namespace GenOne.DPBlazorMapLibrary.JsInterops.LeftletDefaultIconFactories
{
    public interface IIconFactoryJsInterop
    {
        ValueTask<IJSObjectReference> CreateDefaultIcon();
    }
}
