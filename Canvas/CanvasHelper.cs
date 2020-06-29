using Excubo.Blazor.Canvas.Contexts;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace Excubo.Blazor.Canvas
{
    public static class CanvasHelper
    {
        public static async Task<Context2D> GetContext2DAsync(this IJSRuntime js, ElementReference canvas)
        {
            var (context_id, command) = BuildEvalCommand(canvas, "2d");
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
        public static async Task<ContextWebGL> GetContextWebGLAsync(this IJSRuntime js, ElementReference canvas)
        {
            throw new NotImplementedException("Sorry, not yet implemented");
            var (context_id, command) = BuildEvalCommand(canvas, "webgl");
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
        private static (string Id, string Command) BuildEvalCommand(ElementReference canvas, string type)
        {
            var query = $"document.querySelector('[_bl_{canvas.Id}=\"\"]')";
            var get = $"{query}.getContext('{type}')";
            var context_id = "ctx_" + canvas.Id.Replace('-', '_');
            var lhs = $"window.{context_id}";
            var assignment = $"{lhs} = {get}";
            return (Id: context_id, Command: assignment);
        }
    }
}
