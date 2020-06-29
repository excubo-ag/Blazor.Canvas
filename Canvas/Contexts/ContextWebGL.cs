using Microsoft.JSInterop;

namespace Excubo.Blazor.Canvas.Contexts
{
    public class ContextWebGL : Context
    {
        public ContextWebGL(string ctx, IJSRuntime js) : base(ctx, js) { }
    }
}
