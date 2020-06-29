using Microsoft.JSInterop;

namespace Excubo.Blazor.Canvas.Contexts
{
    public class ContextWebGL2 : Context
    {
        public ContextWebGL2(string ctx, IJSRuntime js) : base(ctx, js) { }
    }
}
