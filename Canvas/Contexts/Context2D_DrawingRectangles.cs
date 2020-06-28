using System.Threading.Tasks;

namespace Excubo.Blazor.Canvas.Contexts
{
    public partial class Context2D
    {
        /// <summary>
        /// Sets all pixels in the rectangle defined by starting point (x, y) and size (width, height) to transparent black, erasing any previously drawn content.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public ValueTask ClearRectAsync(double x, double y, double width, double height) => InvokeAsync("clearRect", x, y, width, height);
        /// <summary>
        /// Draws a filled rectangle at (x, y) position whose size is determined by width and height.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public ValueTask FillRectAsync(double x, double y, double width, double height) => InvokeAsync("fillRect", x, y, width, height);
        /// <summary>
        /// Paints a rectangle which has a starting point at (x, y) and has a w width and an h height onto the canvas, using the current stroke style.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public ValueTask StrokeRectAsync(double x, double y, double width, double height) => InvokeAsync("strokeRect", x, y, width, height);
    }
}
