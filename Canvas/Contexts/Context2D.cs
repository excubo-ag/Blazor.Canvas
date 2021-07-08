using Excubo.Blazor.Canvas.Extensions;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Excubo.Blazor.Canvas.Contexts
{
    public partial class Context2D : Context, IContext2DWithoutGetters
    {
        /// <summary>
        /// If you are used to the javascript naming convention and want to use it in C# too, use context.<see cref="JS"/> instead of context.
        /// </summary>
        public partial struct _JS : IContext2DWithoutGetters.I_JS { }
        internal Context2D(string ctx, IJSRuntime js) : base(ctx, js) { }
        [Obsolete("Use the synchronous call CreateBatch instead")]
        public Task<Batch2D> CreateBatchAsync()
        {
            return Task.FromResult(CreateBatch());
        }
        public Batch2D CreateBatch()
        {
            return new Batch2D(ctx, js);
        }
    }
    public partial class Batch2D : IAsyncDisposable, IContext2DWithoutGetters
    {
        /// <summary>
        /// If you are used to the javascript naming convention and want to use it in C# too, use context.<see cref="JS"/> instead of context.
        /// </summary>
        public partial struct _JS : IContext2DWithoutGetters.I_JS { }
        private readonly List<Operation> operations = new();
        private readonly string ctx;
        private readonly IJSRuntime js;

        public ValueTask DisposeAsync()
        {
            return js.InvokeVoidAsync("Excubo.Canvas.batch", ctx, operations.Optimize());

        }
        internal Batch2D(string ctx, IJSRuntime js)
        {
            this.ctx = ctx;
            this.js = js;
        }

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        private async ValueTask SetAsync(string identifier, string value)
        {
            operations.Add(new Operation { Type = OperationType.Set, Identifier = identifier, Value = value });
        }

        private async ValueTask SetAsync(string identifier, bool value)
        {
            operations.Add(new Operation { Type = OperationType.Set, Identifier = identifier, Value = value });
        }

        private async ValueTask SetAsync(string identifier, double value)
        {
            operations.Add(new Operation { Type = OperationType.Set, Identifier = identifier, Value = value });
        }

        private async ValueTask SetAsync(string identifier, DOMMatrix value)
        {
            operations.Add(new Operation { Type = OperationType.Set, Identifier = identifier, Value = value });
        }

        private async ValueTask SetAsync<TEnum>(string identifier, TEnum value) where TEnum : Enum
        {
            operations.Add(new Operation { Type = OperationType.Set, Identifier = identifier, Value = value.ToJsEnumValue() });
        }
        private async ValueTask InvokeOnCtxAsync(string identifier)
        {
            operations.Add(new Operation { Type = OperationType.Invocation, Identifier = identifier, Value = null });
        }
        private async ValueTask InvokeOnCtxAsync<TEnum>(string identifier, TEnum value) where TEnum : Enum
        {
            operations.Add(new Operation { Type = OperationType.Invocation, Identifier = identifier, Value = value.ToJsEnumValue() });
        }
        private async ValueTask InvokeOnCtxAsync(string identifier, params object[] values)
        {
            operations.Add(new Operation { Type = OperationType.Invocation, Identifier = identifier, Value = values });
        }
        private async ValueTask InvokeEvalAsync(string identifier, string @object, params object[] values)
        {
            operations.Add(new Operation { Type = OperationType.Complex, Identifier = identifier, Object1 = @object, Value = values });
        }
        private async ValueTask InvokeEvalAsync2(string identifier, string object1, string object2, params object[] values)
        {
            operations.Add(new Operation { Type = OperationType.Complex, Identifier = identifier, Object1 = object1, Object2 = object2, Value = values });
        }
        private enum Gradient
        {
            Linear,
            Radial
        }
        private class ColorStop
        {
            public double Offset { get; set; }
            public string Color { get; set; }
        }
        private async ValueTask GradientAsync(string identifier, Gradient gradient, ColorStop[] color_stops, params double[] values)
        {
            operations.Add(new Operation { Type = OperationType.GradientOrPattern, Identifier = identifier, Object1 = gradient == Gradient.Linear ? "L" : "R", Object2 = color_stops, Value = values });
        }
        private async ValueTask PatternAsync(string identifier, string image, string value)
        {
            operations.Add(new Operation { Type = OperationType.GradientOrPattern, Identifier = identifier, Object1 = "P", Object2 = image, Value = value });
        }
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
    }
}