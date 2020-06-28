using Excubo.Blazor.Canvas.Extensions;
using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace Excubo.Blazor.Canvas.Contexts
{
    public class Context
    {
        protected readonly string ctx;
        private readonly IJSRuntime js;
        public Context(string ctx, IJSRuntime js)
        {
            this.ctx = ctx;
            this.js = js;
        }
        protected ValueTask InvokeAsync(string method_name, params object[] parameters) => js.InvokeVoidAsync(ctx + "." + method_name, parameters);
        protected ValueTask<T> InvokeAsync<T>(string method_name, params object[] parameters) => js.InvokeAsync<T>(ctx + "." + method_name, parameters);
        protected ValueTask InvokeEvalAsync(string field, string calculation) => js.InvokeVoidAsync("eval", $"{ctx}.{field} = {calculation}");
        protected ValueTask SetAsync(string field, string value) => InvokeEvalAsync(field, "\"" + value + "\"");
        protected ValueTask SetAsync(string field, bool value) => SetAsync(field, value.ToString());
        protected ValueTask SetAsync(string field, double value) => InvokeEvalAsync(field, value.ToInvariantString());
        protected ValueTask SetAsync<TEnum>(string field, TEnum value) where TEnum : Enum => SetAsync(field, value.ToJsEnumValue());
    }
}
