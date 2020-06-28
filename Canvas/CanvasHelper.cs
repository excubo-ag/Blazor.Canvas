using Excubo.Blazor.Canvas.Contexts;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
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
        public static async Task<ImageBitmapRenderingContext> GetImageBitmapRenderingContextAsync(this IJSRuntime js, ElementReference canvas)
        {
            var (context_id, command) = BuildEvalCommand(canvas, "bitmaprenderer");
            await js.InvokeVoidAsync("eval", command);
            return new ImageBitmapRenderingContext(context_id, js);
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
