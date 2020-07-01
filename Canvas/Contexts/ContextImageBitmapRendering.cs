using Microsoft.JSInterop;
using System;

namespace Excubo.Blazor.Canvas.Contexts
{
    public partial class ContextImageBitmapRendering : Context
    {
        internal ContextImageBitmapRendering(string ctx, IJSRuntime js) : base(ctx, js) { }
        /// <summary>
        /// Displays the given ImageBitmap in the canvas associated with this rendering context. Ownership of the ImageBitmap is transferred to the canvas. This was previously named transferImageBitmap(), but was renamed in a spec change. The old name is being kept as an alias to avoid code breakage.
        /// 
        /// Experimental method. Use at own risk. See https://developer.mozilla.org/en-US/docs/Web/API/ImageBitmapRenderingContext/transferFromImageBitmap.
        /// Last checked: 2020-06-28. If you get the "Obsolete" message, but the state is no longer experimental, please contact the library maintainers.
        /// </summary>
        /// <returns></returns>
        [Obsolete("Experimental method. Use at own risk. See https://developer.mozilla.org/en-US/docs/Web/API/ImageBitmapRenderingContext/transferFromImageBitmap.")]
        private void transferFromImageBitmap(object bitmap)
        {
            //TODO transferFromImageBitmap
        }
    }
}
