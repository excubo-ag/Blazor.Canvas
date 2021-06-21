using Excubo.Generators.Grouping;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Excubo.Blazor.Canvas.Contexts
{
    public partial class Context2D
    {
        /// <summary>
        /// <a href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D#Drawing_text" />
        /// </summary>
        public partial struct _DrawingText : IContext2DWithoutGetters.I_DrawingText { }
        /// <summary>
        /// Draws (fills) a given text at the given (x, y) position.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "fillText"), Group(typeof(_DrawingText))]
        public ValueTask FillTextAsync(string text, double x, double y) => InvokeOnCtxAsync("fillText", text, x, y);
        /// <summary>
        /// Draws (fills) a given text at the given (x, y) position.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="max_width"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "fillText"), Group(typeof(_DrawingText))]
        public ValueTask FillTextAsync(string text, double x, double y, double max_width) => InvokeOnCtxAsync("fillText", text, x, y, max_width);
        /// <summary>
        /// Draws (strokes) a given text at the given (x, y) position.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "strokeText"), Group(typeof(_DrawingText))]
        public ValueTask StrokeTextAsync(string text, double x, double y) => InvokeOnCtxAsync("strokeText", text, x, y);
        /// <summary>
        /// Draws (strokes) a given text at the given (x, y) position.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="max_width"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "strokeText"), Group(typeof(_DrawingText))]
        public ValueTask StrokeTextAsync(string text, double x, double y, double max_width) => InvokeOnCtxAsync("strokeText", text, x, y, max_width);
        /// <summary>
        /// Returns a TextMetrics object.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "measureText"), Group(typeof(_DrawingText))]
        public ValueTask<TextMetrics> MeasureTextAsync(string text) => js.InvokeAsync<TextMetrics>("Excubo.Canvas.measureText", ctx, text);
    }
    public partial class Batch2D
    {
        /// <summary>
        /// <a href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D#Drawing_text" />
        /// </summary>
        public partial struct _DrawingText : IContext2DWithoutGetters.I_DrawingText { }
        /// <summary>
        /// Draws (fills) a given text at the given (x, y) position.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "fillText"), Group(typeof(_DrawingText))]
        public ValueTask FillTextAsync(string text, double x, double y) => InvokeOnCtxAsync("fillText", text, x, y);
        /// <summary>
        /// Draws (fills) a given text at the given (x, y) position.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="max_width"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "fillText"), Group(typeof(_DrawingText))]
        public ValueTask FillTextAsync(string text, double x, double y, double max_width) => InvokeOnCtxAsync("fillText", text, x, y, max_width);
        /// <summary>
        /// Draws (strokes) a given text at the given (x, y) position.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "strokeText"), Group(typeof(_DrawingText))]
        public ValueTask StrokeTextAsync(string text, double x, double y) => InvokeOnCtxAsync("strokeText", text, x, y);
        /// <summary>
        /// Draws (strokes) a given text at the given (x, y) position.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="max_width"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "strokeText"), Group(typeof(_DrawingText))]
        public ValueTask StrokeTextAsync(string text, double x, double y, double max_width) => InvokeOnCtxAsync("strokeText", text, x, y, max_width);
    }
}