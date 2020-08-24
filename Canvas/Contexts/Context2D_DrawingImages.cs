using Excubo.Blazor.Canvas.Extensions;
using Excubo.Generators.Grouping;
using System.Threading.Tasks;

namespace Excubo.Blazor.Canvas.Contexts
{
    public partial class Context2D
    {
        /// <summary>
        /// <a href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D#Drawing_images" />
        /// </summary>
        public partial struct _DrawingImages : IContext2DWithoutGetters.I_DrawingImages { }
        /// <summary>
        /// Draws the specified image. This method is available in multiple formats, providing a great deal of flexibility in its use.
        /// </summary>
        /// <param name="image">the name of the image element</param>
        /// <param name="dx">The x-axis coordinate in the destination canvas at which to place the top-left corner of the source image.</param>
        /// <param name="dy">The y-axis coordinate in the destination canvas at which to place the top-left corner of the source image.</param>
        /// <returns></returns>
        [Group(typeof(_JS), "drawImage"), Group(typeof(_DrawingImages))]
        public ValueTask DrawImageAsync(string image, double dx, double dy) => InvokeEvalAsync($"let image_data = {image}; {ctx}.drawImage(image_data, {dx.ToInvariantString()}, {dy.ToInvariantString()})");
        /// <summary>
        /// Draws the specified image. This method is available in multiple formats, providing a great deal of flexibility in its use.
        /// </summary>
        /// <param name="image">the name of the image element</param>
        /// <param name="dx">The x-axis coordinate in the destination canvas at which to place the top-left corner of the source image.</param>
        /// <param name="dy">The y-axis coordinate in the destination canvas at which to place the top-left corner of the source image.</param>
        /// <param name="dwidth">The width to draw the image in the destination canvas. This allows scaling of the drawn image. If not specified, the image is not scaled in width when drawn.</param>
        /// <param name="dheight">The height to draw the image in the destination canvas. This allows scaling of the drawn image. If not specified, the image is not scaled in height when drawn.</param>
        /// <returns></returns>
        [Group(typeof(_JS), "drawImage"), Group(typeof(_DrawingImages))]
        public ValueTask DrawImageAsync(string image, double dx, double dy, double dwidth, double dheight) => InvokeEvalAsync($"let image_data = {image}; {ctx}.drawImage(image_data, {dx.ToInvariantString()}, {dy.ToInvariantString()}, {dwidth.ToInvariantString()}, {dheight.ToInvariantString()})");

        /// <summary>
        /// Draws the specified image. This method is available in multiple formats, providing a great deal of flexibility in its use.
        /// </summary>
        /// <param name="image">the name of the image element</param>
        /// <param name="sx">The x-axis coordinate of the top left corner of the sub-rectangle of the source image to draw into the destination context.</param>
        /// <param name="sy">The y-axis coordinate of the top left corner of the sub-rectangle of the source image to draw into the destination context.</param>
        /// <param name="swidth">The width of the sub-rectangle of the source image to draw into the destination context. If not specified, the entire rectangle from the coordinates specified by sx and sy to the bottom-right corner of the image is used.</param>
        /// <param name="sheight">The height of the sub-rectangle of the source image to draw into the destination context.</param>
        /// <param name="dx">The x-axis coordinate in the destination canvas at which to place the top-left corner of the source image.</param>
        /// <param name="dy">The y-axis coordinate in the destination canvas at which to place the top-left corner of the source image.</param>
        /// <param name="dwidth">The width to draw the image in the destination canvas. This allows scaling of the drawn image. If not specified, the image is not scaled in width when drawn.</param>
        /// <param name="dheight">The height to draw the image in the destination canvas. This allows scaling of the drawn image. If not specified, the image is not scaled in height when drawn.</param>
        /// <returns></returns>
        [Group(typeof(_JS), "drawImage"), Group(typeof(_DrawingImages))]
        public ValueTask DrawImageAsync(string image, double sx, double sy, double swidth, double sheight, double dx, double dy, double dwidth, double dheight) => InvokeEvalAsync($"let image_data = {image}; {ctx}.drawImage(image_data, {sx.ToInvariantString()}, {sy.ToInvariantString()}, {swidth.ToInvariantString()}, {sheight.ToInvariantString()}, {dx.ToInvariantString()}, {dy.ToInvariantString()}, {dwidth.ToInvariantString()}, {dheight.ToInvariantString()})");
    }
    public partial class Batch2D
    {
        /// <summary>
        /// <a href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D#Drawing_images" />
        /// </summary>
        public partial struct _DrawingImages : IContext2DWithoutGetters.I_DrawingImages { }
        /// <summary>
        /// Draws the specified image. This method is available in multiple formats, providing a great deal of flexibility in its use.
        /// </summary>
        /// <param name="image">the name of the image element</param>
        /// <param name="dx">The x-axis coordinate in the destination canvas at which to place the top-left corner of the source image.</param>
        /// <param name="dy">The y-axis coordinate in the destination canvas at which to place the top-left corner of the source image.</param>
        /// <returns></returns>
        [Group(typeof(_JS), "drawImage"), Group(typeof(_DrawingImages))]
        public ValueTask DrawImageAsync(string image, double dx, double dy) => InvokeEvalAsync("drawImage", image, dx, dy);
        /// <summary>
        /// Draws the specified image. This method is available in multiple formats, providing a great deal of flexibility in its use.
        /// </summary>
        /// <param name="image">the name of the image element</param>
        /// <param name="dx">The x-axis coordinate in the destination canvas at which to place the top-left corner of the source image.</param>
        /// <param name="dy">The y-axis coordinate in the destination canvas at which to place the top-left corner of the source image.</param>
        /// <param name="dwidth">The width to draw the image in the destination canvas. This allows scaling of the drawn image. If not specified, the image is not scaled in width when drawn.</param>
        /// <param name="dheight">The height to draw the image in the destination canvas. This allows scaling of the drawn image. If not specified, the image is not scaled in height when drawn.</param>
        /// <returns></returns>
        [Group(typeof(_JS), "drawImage"), Group(typeof(_DrawingImages))]
        public ValueTask DrawImageAsync(string image, double dx, double dy, double dwidth, double dheight) => InvokeEvalAsync("drawImage", image, dx, dy, dwidth, dheight);

        /// <summary>
        /// Draws the specified image. This method is available in multiple formats, providing a great deal of flexibility in its use.
        /// </summary>
        /// <param name="image">the name of the image element</param>
        /// <param name="sx">The x-axis coordinate of the top left corner of the sub-rectangle of the source image to draw into the destination context.</param>
        /// <param name="sy">The y-axis coordinate of the top left corner of the sub-rectangle of the source image to draw into the destination context.</param>
        /// <param name="swidth">The width of the sub-rectangle of the source image to draw into the destination context. If not specified, the entire rectangle from the coordinates specified by sx and sy to the bottom-right corner of the image is used.</param>
        /// <param name="sheight">The height of the sub-rectangle of the source image to draw into the destination context.</param>
        /// <param name="dx">The x-axis coordinate in the destination canvas at which to place the top-left corner of the source image.</param>
        /// <param name="dy">The y-axis coordinate in the destination canvas at which to place the top-left corner of the source image.</param>
        /// <param name="dwidth">The width to draw the image in the destination canvas. This allows scaling of the drawn image. If not specified, the image is not scaled in width when drawn.</param>
        /// <param name="dheight">The height to draw the image in the destination canvas. This allows scaling of the drawn image. If not specified, the image is not scaled in height when drawn.</param>
        /// <returns></returns>
        [Group(typeof(_JS), "drawImage"), Group(typeof(_DrawingImages))]
        public ValueTask DrawImageAsync(string image, double sx, double sy, double swidth, double sheight, double dx, double dy, double dwidth, double dheight) => InvokeEvalAsync("drawImage", image, sx, sy, swidth, sheight, dx, dy, dwidth, dheight);
    }
}
