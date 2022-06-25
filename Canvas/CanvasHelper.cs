using Excubo.Blazor.Canvas.Contexts;
using Excubo.Blazor.Canvas.Extensions;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;
using static System.Text.Json.JsonSerializer;

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
        /// <summary>
        /// Creates a callback for getting a Blob from a given canvas.
        /// </summary>
        /// <param name="js">The JS runtime, usually injected into a component.</param>
        /// <param name="canvas">An ElementReference to the &lt;canvas&gt; tag in a component.</param>
        /// <param name="callback">Cction that should be executed once the callback is invoked.</param>
        /// <param name="type">The type of image format for the Blob.</param>
        /// <param name="quality">Quality of the Blob given to the callback in the range between 0 and 1.</param>
        /// <returns></returns>
        public static async Task ToBlobAsync(this IJSRuntime js, ElementReference canvas, Action<Blob> callback, string type = "image/png", double? quality = null)
        {
            if (js is not IJSInProcessRuntime)
            {
                throw new PlatformNotSupportedException("ToBlobAsync is not supported for Blazor Server");
            }
            var query = $"document.querySelector('[_bl_{canvas.Id}=\"\"]')";
            var toBlobWrapper = $"var blobWrapper = {{}};{query}.toBlob((blob)=>{{blobWrapper.blob = blob;blobCallback.objRef.invokeMethodAsync('Callback');}},'{type}'{(quality == null ? "" : ", " + quality.Value)});blobWrapper;";
            var blobCallback = new BlobCallback(js, callback);
            var jsBlobCallback = await js.InvokeAsync<IJSObjectReference>("eval", "var blobCallback = {}; blobCallback;");
            await js.InvokeVoidAsync("Object.assign", jsBlobCallback, blobCallback);
            blobCallback.BlobWrapper = await js.InvokeAsync<IJSObjectReference>("eval", toBlobWrapper);
        }
        /// <summary>
        /// Returns a 2D context for a given canvas.
        /// </summary>
        /// <param name="js">The JS runtime, usually injected into a component.</param>
        /// <param name="canvas">An ElementReference to the &lt;canvas&gt; tag in a component.</param>
        public static async Task<Context2D> GetContext2DAsync(this IJSRuntime js, ElementReference canvas, bool alpha = true, bool desynchronized = false)
        {
            await LoadExcuboCanvasCodeAsync(js);
            var arguments = PrepareArguments(alpha, desynchronized);
            var (context_id, command) = BuildEvalCommand(canvas, "2d", arguments);
            await js.InvokeVoidAsync("eval", command);
            return new Context2D(context_id, js);
        }
        /// <summary>
        /// Returns a 2D context for a given canvas.
        /// </summary>
        /// <param name="js">The JS runtime, usually injected into a component.</param>
        /// <param name="js_canvas_object_reference">The variable name of the canvas, e.g. window.myOffscreenCanvas</param>
        public static async Task<Context2D> GetContext2DAsync(this IJSRuntime js, string js_canvas_object_reference, bool alpha = true, bool desynchronized = false)
        {
            await LoadExcuboCanvasCodeAsync(js);
            var arguments = PrepareArguments(alpha, desynchronized);
            var (context_id, command) = BuildEvalCommand(js_canvas_object_reference, "2d", arguments);
            await js.InvokeVoidAsync("eval", command);
            return new Context2D(context_id, js);
        }
        [Obsolete("Sorry, not yet implemented")]
        public static async Task<ContextImageBitmapRendering> GetContextImageBitmapRenderingAsync(this IJSRuntime js, ElementReference canvas)
        {
            throw new NotImplementedException("Sorry, not yet implemented");
            await LoadExcuboCanvasCodeAsync(js);
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
            await LoadExcuboCanvasCodeAsync(js);
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
            await LoadExcuboCanvasCodeAsync(js);
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
        private static (string Id, string Command) BuildEvalCommand(string js_canvas_object_reference, string type, string arguments = null)
        {
            var get = $"{js_canvas_object_reference}.getContext('{type}'{(arguments == null ? "" : ", " + arguments)})";
            var context_id = "ctx_" + Guid.NewGuid().ToString().Replace('-', '_');
            var lhs = $"window.{context_id}";
            var assignment = $"{lhs} = {get}";
            return (Id: context_id, Command: assignment);
        }
        private static ValueTask LoadExcuboCanvasCodeAsync(IJSRuntime js)
        {
            return js.InvokeVoidAsync("eval", "window.Excubo=window.Excubo||{};window.Excubo.Canvas=window.Excubo.Canvas||{measureText:(n,t)=>{n=window[`${n}`];var i=n.measureText(t),r=Object.entries(Object.getOwnPropertyDescriptors(TextMetrics.prototype)).filter(([,n])=>typeof n.get=='function'),u=r.map(([n])=>[n,i[n]]);return u.reduce(function(n,t){return n[t[0]]=t[1],n},{})},batch:(n,t)=>{n=window[`${n}`];d=n=>{let t=window;for(let i of n.split('.'))t=t[i];return t};for(let i of t)switch(i.t){case'S':n[i.i]=i.v;break;case'G':if(i.o1=='P')n[i.i]=n.createPattern(d(i.o2),i.v);else{let t=n[`create${i.o1=='L'?'Linear':'Radial'}Gradient`](...i.v);for(let n of i.o2)t.addColorStop(n.offset,n.color);n[i.i]=t}break;case'I':if(i.b)for(let t of i.v)t==undefined?n[i.i]():Array.isArray(t)?n[i.i](...t):n[i.i](t);else{let t=i.v;t==undefined?n[i.i]():Array.isArray(t)?n[i.i](...t):n[i.i](t)}break;case'C':if(i.b){const t=i.o1.length;for(let r=0;r<t;r++){let t=i.v[r],u=i.o1[r],f=i.o2[r];f==undefined?t==undefined?n[i.i](d(u)):Array.isArray(t)?n[i.i](d(u),...t):n[i.i](d(u),t):t==undefined?n[i.i](d(u),d(f)):Array.isArray(t)?n[i.i](d(u),d(f),...t):n[i.i](d(u),d(f),t)}}else{let t=i.v,r=i.o1,u=i.o2;u==undefined?t==undefined?n[i.i](d(r)):Array.isArray(t)?n[i.i](d(r),...t):n[i.i](d(r),t):t==undefined?n[i.i](d(r),d(u)):Array.isArray(t)?n[i.i](d(r),d(u),...t):n[i.i](d(r),d(u),t)}}}};");
        }
    }
}