using Microsoft.JSInterop;

namespace Excubo.Blazor.Canvas.Contexts
{
    public partial class Context2D : Context
    {
        public Context2D(string ctx, IJSRuntime js) : base(ctx, js) { }
    }
}
