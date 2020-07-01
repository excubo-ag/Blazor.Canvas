using System.Threading.Tasks;

namespace Excubo.Blazor.Canvas.Contexts
{
    public partial class Context2D
    {
        /// <summary>
        /// Draws (fills) a given text at the given (x, y) position.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public ValueTask FillTextAsync(string text, double x, double y) => InvokeOnCtxAsync("fillText", text, x, y);
        /// <summary>
        /// Draws (fills) a given text at the given (x, y) position.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="max_width"></param>
        /// <returns></returns>
        public ValueTask FillTextAsync(string text, double x, double y, double max_width) => InvokeOnCtxAsync("fillText", text, x, y, max_width);
        /// <summary>
        /// Draws (strokes) a given text at the given (x, y) position.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public ValueTask StrokeTextAsync(string text, double x, double y) => InvokeOnCtxAsync("strokeText", text, x, y);
        /// <summary>
        /// Draws (strokes) a given text at the given (x, y) position.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="max_width"></param>
        /// <returns></returns>
        public ValueTask StrokeTextAsync(string text, double x, double y, double max_width) => InvokeOnCtxAsync("strokeText", text, x, y, max_width);
        /// <summary>
        /// Returns a TextMetrics object.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public ValueTask<TextMetrics> MeasureTextAsync(string text) => InvokeOnCtxAsync<TextMetrics>("measureText", text);
    }
}
