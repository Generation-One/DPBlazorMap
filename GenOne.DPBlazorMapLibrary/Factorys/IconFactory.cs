﻿using GenOne.DPBlazorMapLibrary.Factorys.Interfaces;
using GenOne.DPBlazorMapLibrary.JsInterops.LeftletDefaultIconFactories;
using GenOne.DPBlazorMapLibrary.Models.Basics.Icons;
using Microsoft.JSInterop;

namespace GenOne.DPBlazorMapLibrary.Factorys
{
    public class IconFactory : IIconFactory
    {
        private const string _createIconJsFunction = "L.icon";

        private const string _createDivIconJsFunction = "L.divIcon";

        private readonly IIconFactoryJsInterop _iconFactoryJsInterop;
        private readonly IJSRuntime _jsRuntime;
        public IconFactory(
            IJSRuntime jsRuntime,
            IIconFactoryJsInterop iconFactoryJsInterop)
        {
            _jsRuntime = jsRuntime;
            _iconFactoryJsInterop = iconFactoryJsInterop;
        }

        #region Icon
        public async Task<Icon> Create(IconOptions options)
        {
            IJSObjectReference jsReference = await _jsRuntime.InvokeAsync<IJSObjectReference>(_createIconJsFunction, options);
            return new Icon(jsReference);
        }

        public async Task<Icon> CreateDefault()
        {
            IJSObjectReference jsReference = await _iconFactoryJsInterop.CreateDefaultIcon();
            return new Icon(jsReference);
        }
        #endregion

        public async Task<Icon> CreateDivIcon(DivIconOptions options)
        {
            IJSObjectReference jsReference = await _jsRuntime.InvokeAsync<IJSObjectReference>(_createDivIconJsFunction, options);
            return new Icon(jsReference);
        }
    }
}
