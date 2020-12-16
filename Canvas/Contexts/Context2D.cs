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
        public async Task<Batch2D> CreateBatchAsync()
        {
            await js.InvokeVoidAsync("eval", "window.Excubo=window.Excubo||{};window.Excubo.Canvas=window.Excubo.Canvas||{batch:(n,t)=>{n=window[`${n}`];d=n=>{let t=window;for(let e of n.split('.'))t=t[e];return t};for(let i of t)switch(i.t){case'S':n[i.i]=i.v;break;case'G':if(i.o1=='P')n[i.i]=n.createPattern(d(i.o2),i.v);else{let t=n[`create${i.o1=='L'?'Linear':'Radial'}Gradient`](...i.v);for(let n of i.o2)t.addColorStop(n.offset,n.color);n[i.i]=t}break;case'I':if(i.b)for(let t of i.v)t==undefined?n[i.i]():Array.isArray(t)?n[i.i](...t):n[i.i](t);else{let t=i.v;t==undefined?n[i.i]():Array.isArray(t)?n[i.i](...t):n[i.i](t)}break;case'C':if(i.b){const t=i.o1.length;for(let r=0;r<t;r++){let t=i.v[r],u=i.o1[r],f=i.o2[r];f==undefined?t==undefined?n[i.i](d(u)):Array.isArray(t)?n[i.i](d(u),...t):n[i.i](d(u),t):t==undefined?n[i.i](d(u),d(f)):Array.isArray(t)?n[i.i](d(u),d(f),...t):n[i.i](d(u),d(f),t)}}else{let t=i.v,r=i.o1,u=i.o2;u==undefined?t==undefined?n[i.i](d(r)):Array.isArray(t)?n[i.i](d(r),...t):n[i.i](d(r),t):t==undefined?n[i.i](d(r),d(u)):Array.isArray(t)?n[i.i](d(r),d(u),...t):n[i.i](d(r),d(u),t)}}}};");
            return new Batch2D(ctx, js);
        }
    }
    public partial class Batch2D : IAsyncDisposable, IContext2DWithoutGetters
    {
        /// <summary>
        /// If you are used to the javascript naming convention and want to use it in C# too, use context.<see cref="JS"/> instead of context.
        /// </summary>
        public partial struct _JS : IContext2DWithoutGetters.I_JS { }
        private readonly List<Operation> operations = new List<Operation>();
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