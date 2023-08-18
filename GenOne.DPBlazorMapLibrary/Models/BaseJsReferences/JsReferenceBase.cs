using Microsoft.JSInterop;

namespace GenOne.DPBlazorMapLibrary.Models.BaseJsReferences
{
    /// <summary>
    /// Base class for a reference to a js object
    /// </summary>
    public class JsReferenceBase
    {
        #pragma warning disable CS8618
        /// <summary>
        /// Js References
        /// </summary>
        public IJSObjectReference JsReference;
        #pragma warning restore CS8618 
    }
}
