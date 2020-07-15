using Excubo.Blazor.Canvas.Extensions;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Excubo.Blazor.Canvas.Contexts
{
    public partial class Context2D : Context, IContext2DWithoutGetters
    {
        internal Context2D(string ctx, IJSRuntime js) : base(ctx, js) { }
        public async Task<Batch2D> CreateBatchAsync()
        {
            await js.InvokeVoidAsync("eval", "window.Excubo=window.Excubo||{};window.Excubo.Canvas=window.Excubo.Canvas||{batch:(n,t)=>{n=window[`${n}`];for(let i of t)switch(i.t){case\"S\":n[i.i]=i.v;break;case\"I\":i.v==undefined?n[i.i]():n[i.i](...i.v);break;case\"C\":d=n=>{let t=window;for(const e of n.split(\".\"))t=t[e];return t};i.o2==undefined?n[i.i](d(i.o1),...i.v):n[i.i](d(i.o1),d(i.o2),...i.v)}}};");
            return new Batch2D(ctx, js);
        }
    }
    public partial class Batch2D : IAsyncDisposable, IContext2DWithoutGetters
    {
        private readonly List<Operation> operations = new List<Operation>();
        private readonly string ctx;
        private readonly IJSRuntime js;

        public ValueTask DisposeAsync()
        {
            return js.InvokeVoidAsync("Excubo.Canvas.batch", ctx, operations);

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
        [Obsolete]
        private async ValueTask InvokeEvalAsync(string v)
        {
            // TODO
        }
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
    }
}
