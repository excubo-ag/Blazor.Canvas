using Excubo.Blazor.Canvas.Contexts;
using Excubo.Blazor.Canvas.Extensions;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace Excubo.Blazor.Canvas
{
    public static class CanvasHelper
    {
        public static ValueTask<string> ToDataURLAsync(this IJSRuntime js, ElementReference canvas, string type = "image/png", double? encoderOptions = null)
        {
            var query = $"document.querySelector('[_bl_{canvas.Id}=\"\"]')";
            var get = $"{query}.toDataURL('{type}'{(encoderOptions == null ? "" : ", " + encoderOptions.Value)})";
            return js.InvokeAsync<string>("eval", get);
        }
        public static async Task<Context2D> GetContext2DAsync(this IJSRuntime js, ElementReference canvas, bool alpha = true, bool desynchronized = false)
        {
            var arguments = PrepareArguments(alpha, desynchronized);
            var (context_id, command) = BuildEvalCommand(canvas, "2d", arguments);
            await js.InvokeVoidAsync("eval", command);
            return new Context2D(context_id, js);
        }
        [Obsolete("Sorry, not yet implemented")]
        public static async Task<ContextImageBitmapRendering> GetContextImageBitmapRenderingAsync(this IJSRuntime js, ElementReference canvas)
        {
            throw new NotImplementedException("Sorry, not yet implemented");
            var (context_id, command) = BuildEvalCommand(canvas, "bitmaprenderer");
            await js.InvokeVoidAsync("eval", command);
            return new ContextImageBitmapRendering(context_id, js);
        }
        [Obsolete("Sorry, not yet implemented")]
        public static async Task<ContextWebGL> GetContextWebGLAsync(this IJSRuntime js, ElementReference canvas,
            bool alpha = true, bool desynchronized = false, bool antialias = false, bool depth = false, bool fail_if_major_performance_caveat = false,
            PowerPreference power_preference = PowerPreference.Default, bool premultiplied_alpha = false, bool preserve_drawing_buffer = false, bool stencil = false)
        {
            throw new NotImplementedException("Sorry, not yet implemented");
            var arguments = PrepareArguments(alpha, desynchronized, antialias, depth, fail_if_major_performance_caveat,
                power_preference, premultiplied_alpha, preserve_drawing_buffer, stencil);
            var (context_id, command) = BuildEvalCommand(canvas, "webgl", arguments);
            await js.InvokeVoidAsync("eval", command);
            return new ContextWebGL(context_id, js);
        }
        [Obsolete("Sorry, not yet implemented")]
        public static async Task<ContextWebGL2> GetContextWebGL2Async(this IJSRuntime js, ElementReference canvas)
        {
            throw new NotImplementedException("Sorry, not yet implemented");
            var (context_id, command) = BuildEvalCommand(canvas, "webgl2");
            await js.InvokeVoidAsync("eval", command);
            return new ContextWebGL2(context_id, js);
        }
        private static string PrepareArguments(bool alpha, bool desynchronized)
        {
            return $@"{{
              alpha: {alpha.ToString().ToLowerInvariant()},
              desynchronized: {desynchronized.ToString().ToLowerInvariant()}
            }}";
        }
        private static string PrepareArguments(bool alpha, bool desynchronized, bool antialias, bool depth, bool fail_if_major_performance_caveat,
            PowerPreference power_preference, bool premultiplied_alpha, bool preserve_drawing_buffer, bool stencil)
        {
            return $@"{{
                alpha: {alpha.ToString().ToLowerInvariant()},
                desynchronized: {desynchronized.ToString().ToLowerInvariant()},
                antialias: {antialias.ToString().ToLowerInvariant()},
                depth: {depth.ToString().ToLowerInvariant()},
                failIfMajorPerformanceCaveat: {fail_if_major_performance_caveat.ToString().ToLowerInvariant()},
                powerPreference: ""{power_preference.ToJsEnumValue()}"",
                premultipliedAlpha: {premultiplied_alpha.ToString().ToLowerInvariant()},
                preserveDrawingBuffer: {preserve_drawing_buffer.ToString().ToLowerInvariant()},
                stencil: {stencil.ToString().ToLowerInvariant()}
            }}";
        }
        private static (string Id, string Command) BuildEvalCommand(ElementReference canvas, string type, string arguments = null)
        {
            var query = $"document.querySelector('[_bl_{canvas.Id}=\"\"]')";
            var get = $"{query}.getContext('{type}'{(arguments == null ? "" : ", " + arguments)})";
            var context_id = "ctx_" + canvas.Id.Replace('-', '_');
            var lhs = $"window.{context_id}";
            var assignment = $"{lhs} = {get}";
            return (Id: context_id, Command: assignment);
        }
    }
}