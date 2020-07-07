using Excubo.Blazor.Canvas.Extensions;
using System;
using System.Threading.Tasks;

namespace Excubo.Blazor.Canvas.Contexts
{
    public partial class Context2D
    {
        /// <summary>
        /// Creates a new, blank ImageData object with the specified dimensions. All of the pixels in the new object are transparent black.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns>the name of the ImageData object</returns>
        public async ValueTask<string> CreateImageDataAsync(double width, double height)
        {
            var id = "img_" + Guid.NewGuid().ToString().Replace('-', '_');
            await InvokeEvalAsync($"window.{id} = {ctx}.createImageData({width.ToInvariantString()}, {height.ToInvariantString()})");
            return id;
        }
        /// <summary>
        /// Returns an ImageData object representing the underlying pixel data for the area of the canvas denoted by the rectangle which starts at (x, y) and has an width and height.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns>the name of the ImageData object</returns>
        public async ValueTask<string> GetImageDataAsync(double x, double y, double width, double height)
        {
            var id = "img_" + Guid.NewGuid().ToString().Replace('-', '_');
            await InvokeEvalAsync($"window.{id} = {ctx}.getImageData({x.ToInvariantString()}, {y.ToInvariantString()}, {width.ToInvariantString()}, {height.ToInvariantString()})");
            return id;
        }
        /// <summary>
        /// Paints data from the given ImageData object onto the bitmap.
        /// </summary>
        /// <param name="id">the name of the ImageData object</param>
        /// <param name="dx"></param>
        /// <param name="dy"></param>
        /// <returns></returns>
        public ValueTask PutImageDataAsync(string id, double dx, double dy) => InvokeEvalAsync($"image_data = window.{id}; {ctx}.putImageData(image_data, {dx.ToInvariantString()}, {dy.ToInvariantString()})");
        /// <summary>
        /// Paints data from the given ImageData object onto the bitmap. Only the pixels from the dirty rectangle are painted.
        /// </summary>
        /// <param name="id">the name of the ImageData object</param>
        /// <param name="dx"></param>
        /// <param name="dy"></param>
        /// <param name="dirty_x"></param>
        /// <param name="dirty_y"></param>
        /// <param name="dirty_width"></param>
        /// <param name="dirty_height"></param>
        /// <returns></returns>
        public ValueTask PutImageDataAsync(string id, double dx, double dy, double dirty_x, double dirty_y, double dirty_width, double dirty_height) => InvokeEvalAsync($"image_data = window.{id}; {ctx}.putImageData(image_data, {dx.ToInvariantString()}, {dy.ToInvariantString()}, {dirty_x.ToInvariantString()}, {dirty_y.ToInvariantString()}, {dirty_width.ToInvariantString()}, {dirty_height.ToInvariantString()})");
    }
}
