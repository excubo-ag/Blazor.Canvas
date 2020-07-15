using Excubo.Blazor.Canvas.Extensions;
using System;
using System.Threading.Tasks;

namespace Excubo.Blazor.Canvas.Contexts
{
    public partial class Context2D
    {
        /// <summary>
        /// Fills the current sub-paths with the current fill style.
        /// </summary>
        /// <param name="fill_rule"></param>
        /// <returns></returns>
        public ValueTask FillAsync(FillRule fill_rule) => InvokeOnCtxAsync("fill", fill_rule.ToJsEnumValue());
        /// <summary>
        /// Fills the current sub-paths with the current fill style.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="fill_rule"></param>
        public ValueTask FillAsync(string path, FillRule fill_rule) => InvokeEvalAsync($"path = {path}; {ctx}.stroke(path, {fill_rule.ToJsEnumValue()});");
        /// <summary>
        /// Strokes the current sub-paths with the current stroke style.
        /// </summary>
        /// <returns></returns>
        public ValueTask StrokeAsync() => InvokeOnCtxAsync("stroke");
        /// <summary>
        /// Strokes the current sub-paths with the current stroke style.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public ValueTask StrokeAsync(string path) => InvokeEvalAsync($"path = {path}; {ctx}.stroke(path);");
        /// <summary>
        /// If a given element is focused, this method draws a focus ring around the current path.
        /// </summary>
        /// <param name="element"></param>
        public ValueTask DrawFocusIfNeededAsync(string element) => InvokeEvalAsync($"el = {element}; {ctx}.drawFocusIfNeeded(el);");
        /// <summary>
        /// If a given element is focused, this method draws a focus ring around the current path.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="element"></param>
        public ValueTask DrawFocusIfNeededAsync(string path, string element) => InvokeEvalAsync($"path = {path}; el = {element}; {ctx}.drawFocusIfNeeded(path, el);");
        /// <summary>
        /// Scrolls the current path or a given path into the view.
        /// Experimental method. Use at own risk. See https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/scrollPathIntoView.
        /// Last checked: 2020-06-28. If you get the "Obsolete" message, but the state is no longer experimental, please contact the library maintainers.
        /// </summary>
        /// <returns></returns>
        [Obsolete("Experimental method. Use at own risk. See https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/scrollPathIntoView.")]
        /// </summary>
        public ValueTask ScrollPathIntoViewAsync() => InvokeOnCtxAsync("scrollPathIntoView");
        /// <summary>
        /// Scrolls the current path or a given path into the view.
        /// Experimental method. Use at own risk. See https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/scrollPathIntoView.
        /// Last checked: 2020-06-28. If you get the "Obsolete" message, but the state is no longer experimental, please contact the library maintainers.
        /// </summary>
        /// <returns></returns>
        [Obsolete("Experimental method. Use at own risk. See https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/scrollPathIntoView.")]
        public ValueTask ScrollPathIntoViewAsync(string path) => InvokeEvalAsync($"path = {path}; {ctx}.scrollPathIntoView(path);");
        /// <summary>
        /// Creates a clipping path from the current sub-paths. Everything drawn after clip() is called appears inside the clipping path only. For an example, see Clipping paths in the Canvas tutorial.
        /// </summary>
        /// <param name="fill_rule"></param>
        /// <returns></returns>
        public ValueTask ClipAsync(FillRule fill_rule) => SetAsync("clip", fill_rule);
        /// <summary>
        /// Creates a clipping path from the current sub-paths. Everything drawn after clip() is called appears inside the clipping path only. For an example, see Clipping paths in the Canvas tutorial.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="fill_rule"></param>
        public ValueTask ClipAsync(string path, FillRule fill_rule) => InvokeEvalAsync($"path = {path}; {ctx}.clip(path, {fill_rule.ToJsEnumValue()});");
        /// <summary>
        /// Reports whether or not the specified point is contained in the current path.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="fill_rule"></param>
        /// <returns></returns>
        public ValueTask<bool> IsPointInPathAsync(double x, double y, FillRule fill_rule) => InvokeOnCtxAsync<bool>("isPointInPath", x, y, fill_rule.ToJsEnumValue());
        /// <summary>
        /// Reports whether or not the specified point is contained in the current path.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="fill_rule"></param>
        public ValueTask<bool> IsPointInPathAsync(string path, double x, double y, FillRule fill_rule) => InvokeEvalAsync<bool>($"path = {path}; {ctx}.isPointInPath(path, {x.ToInvariantString()}, {y.ToInvariantString()}, {fill_rule.ToJsEnumValue()});");
        /// <summary>
        /// Reports whether or not the specified point is inside the area contained by the stroking of a path.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public ValueTask<bool> IsPointInStrokeAsync(double x, double y) => InvokeOnCtxAsync<bool>("isPointInStroke", x, y);
        /// <summary>
        /// Reports whether or not the specified point is inside the area contained by the stroking of a path.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public ValueTask<bool> IsPointInStrokeAsync(string path, double x, double y) => InvokeEvalAsync<bool>($"path = {path}; {ctx}.isPointInStroke(path, {x.ToInvariantString()}, {y.ToInvariantString()});");
    }
    public partial class Batch2D
    {
        /// <summary>
        /// Fills the current sub-paths with the current fill style.
        /// </summary>
        /// <param name="fill_rule"></param>
        /// <returns></returns>
        public ValueTask FillAsync(FillRule fill_rule) => InvokeOnCtxAsync("fill", fill_rule);
        /// <summary>
        /// Fills the current sub-paths with the current fill style.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="fill_rule"></param>
        public ValueTask FillAsync(string path, FillRule fill_rule) => InvokeEvalAsync("stroke", path, fill_rule.ToJsEnumValue());
        /// <summary>
        /// Strokes the current sub-paths with the current stroke style.
        /// </summary>
        /// <returns></returns>
        public ValueTask StrokeAsync() => InvokeOnCtxAsync("stroke");
        /// <summary>
        /// Strokes the current sub-paths with the current stroke style.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public ValueTask StrokeAsync(string path) => InvokeEvalAsync("stroke", path);
        /// <summary>
        /// If a given element is focused, this method draws a focus ring around the current path.
        /// </summary>
        /// <param name="element"></param>
        public ValueTask DrawFocusIfNeededAsync(string element) => InvokeEvalAsync("drawFocusIfNeeded", element);
        /// <summary>
        /// If a given element is focused, this method draws a focus ring around the current path.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="element"></param>
        public ValueTask DrawFocusIfNeededAsync(string path, string element) => InvokeEvalAsync2("drawFocusIfNeeded", path, element);
        /// <summary>
        /// Scrolls the current path or a given path into the view.
        /// Experimental method. Use at own risk. See https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/scrollPathIntoView.
        /// Last checked: 2020-06-28. If you get the "Obsolete" message, but the state is no longer experimental, please contact the library maintainers.
        /// </summary>
        /// <returns></returns>
        [Obsolete("Experimental method. Use at own risk. See https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/scrollPathIntoView.")]
        /// </summary>
        public ValueTask ScrollPathIntoViewAsync() => InvokeOnCtxAsync("scrollPathIntoView");
        /// <summary>
        /// Scrolls the current path or a given path into the view.
        /// Experimental method. Use at own risk. See https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/scrollPathIntoView.
        /// Last checked: 2020-06-28. If you get the "Obsolete" message, but the state is no longer experimental, please contact the library maintainers.
        /// </summary>
        /// <returns></returns>
        [Obsolete("Experimental method. Use at own risk. See https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/scrollPathIntoView.")]
        public ValueTask ScrollPathIntoViewAsync(string path) => InvokeEvalAsync("scrollPathIntoView", path);
        /// <summary>
        /// Creates a clipping path from the current sub-paths. Everything drawn after clip() is called appears inside the clipping path only. For an example, see Clipping paths in the Canvas tutorial.
        /// </summary>
        /// <param name="fill_rule"></param>
        /// <returns></returns>
        public ValueTask ClipAsync(FillRule fill_rule) => SetAsync("clip", fill_rule);
        /// <summary>
        /// Creates a clipping path from the current sub-paths. Everything drawn after clip() is called appears inside the clipping path only. For an example, see Clipping paths in the Canvas tutorial.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="fill_rule"></param>
        public ValueTask ClipAsync(string path, FillRule fill_rule) => InvokeEvalAsync("clip", path, fill_rule.ToJsEnumValue());
    }
}
