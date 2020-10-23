using Excubo.Blazor.Canvas.Contexts;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Excubo.Blazor.Canvas
{
    [Excubo.Generators.Blazor.GenerateSetParametersAsync(RequireExactMatch = true)]
    public partial class Canvas : ComponentBase
    {
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "canvas");
            builder.AddMultipleAttributes(1, AdditionalAttributes);
            builder.AddElementReferenceCapture(2, (element) => canvas = element);
            builder.CloseElement();
        }
        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> AdditionalAttributes { get; set; }
        [Inject]
        private IJSRuntime js { get; set; }
        private ElementReference canvas;
        public ValueTask<string> ToDataURLAsync(string type = "image/png", double? encoderOptions = null) => js.ToDataURLAsync(canvas, type, encoderOptions);
        public Task<Context2D> GetContext2DAsync(bool alpha = true, bool desynchronized = false) => js.GetContext2DAsync(canvas, alpha, desynchronized);
        [Obsolete("Sorry, not yet implemented")]
        public Task<ContextImageBitmapRendering> GetContextImageBitmapRenderingAsync() => js.GetContextImageBitmapRenderingAsync(canvas);
        [Obsolete("Sorry, not yet implemented")]
        public Task<ContextWebGL> GetContextWebGLAsync(
            bool alpha = true, bool desynchronized = false, bool antialias = false, bool depth = false, bool fail_if_major_performance_caveat = false,
            PowerPreference power_preference = PowerPreference.Default, bool premultiplied_alpha = false, bool preserve_drawing_buffer = false, bool stencil = false)
            => js.GetContextWebGLAsync(canvas, alpha, desynchronized, antialias, depth, fail_if_major_performance_caveat,
                power_preference, premultiplied_alpha, preserve_drawing_buffer, stencil);
        [Obsolete("Sorry, not yet implemented")]
        public Task<ContextWebGL2> GetContextWebGL2Async() => js.GetContextWebGL2Async(canvas);
    }
}
