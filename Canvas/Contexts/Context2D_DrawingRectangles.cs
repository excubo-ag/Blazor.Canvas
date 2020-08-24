using Excubo.Generators.Grouping;
using System.Threading.Tasks;

namespace Excubo.Blazor.Canvas.Contexts
{
    public partial class Context2D
    {
        /// <summary>
        /// <a href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D#Drawing_rectangles" />
        /// </summary>
        public partial struct _DrawingRectangles : IContext2DWithoutGetters.I_DrawingRectangles { }
        /// <summary>
        /// Sets all pixels in the rectangle defined by starting point (x, y) and size (width, height) to transparent black, erasing any previously drawn content.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "clearRect"), Group(typeof(_DrawingRectangles))]
        public ValueTask ClearRectAsync(double x, double y, double width, double height) => InvokeOnCtxAsync("clearRect", x, y, width, height);
        /// <summary>
        /// Draws a filled rectangle at (x, y) position whose size is determined by width and height.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "fillRect"), Group(typeof(_DrawingRectangles))]
        public ValueTask FillRectAsync(double x, double y, double width, double height) => InvokeOnCtxAsync("fillRect", x, y, width, height);
        /// <summary>
        /// Paints a rectangle which has a starting point at (x, y) and has a w width and an h height onto the canvas, using the current stroke style.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "strokeRect"), Group(typeof(_DrawingRectangles))]
        public ValueTask StrokeRectAsync(double x, double y, double width, double height) => InvokeOnCtxAsync("strokeRect", x, y, width, height);
    }
    public partial class Batch2D
    {
        /// <summary>
        /// <a href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D#Drawing_rectangles" />
        /// </summary>
        public partial struct _DrawingRectangles : IContext2DWithoutGetters.I_DrawingRectangles { }
        /// <summary>
        /// Sets all pixels in the rectangle defined by starting point (x, y) and size (width, height) to transparent black, erasing any previously drawn content.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "clearRect"), Group(typeof(_DrawingRectangles))]
        public ValueTask ClearRectAsync(double x, double y, double width, double height) => InvokeOnCtxAsync("clearRect", x, y, width, height);
        /// <summary>
        /// Draws a filled rectangle at (x, y) position whose size is determined by width and height.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "fillRect"), Group(typeof(_DrawingRectangles))]
        public ValueTask FillRectAsync(double x, double y, double width, double height) => InvokeOnCtxAsync("fillRect", x, y, width, height);
        /// <summary>
        /// Paints a rectangle which has a starting point at (x, y) and has a w width and an h height onto the canvas, using the current stroke style.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "strokeRect"), Group(typeof(_DrawingRectangles))]
        public ValueTask StrokeRectAsync(double x, double y, double width, double height) => InvokeOnCtxAsync("strokeRect", x, y, width, height);
    }
}
