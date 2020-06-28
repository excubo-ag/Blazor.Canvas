using System;
using System.Threading.Tasks;

namespace Excubo.Blazor.Canvas.Contexts
{
    public partial class Context2D
    {
        /// <summary>
        /// Current transformation matrix
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public ValueTask CurrentTransformAsync(object value) => SetAsync("currentTransform", value);
        /// <summary>
        /// Current transformation matrix
        /// Experimental method. Use at own risk. See https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/resetTransform.
        /// Last checked: 2020-06-28. If you get the "Obsolete" message, but the state is no longer experimental, please contact the library maintainers.
        /// </summary>
        /// <returns></returns>
        [Obsolete("Experimental method. Use at own risk. See https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/resetTransform.")]
        public ValueTask<object> CurrentTransformAsync() => GetObjectAsync("currentTransform");
        /// <summary>
        /// Retrieves the current transformation matrix being applied to the context.
        /// </summary>
        /// <returns></returns>
        public ValueTask<object> GetTransformAsync() => InvokeAsync<object>("getTransform");
        /// <summary>
        /// Adds a rotation to the transformation matrix. The angle argument represents a clockwise rotation angle and is expressed in radians
        /// </summary>
        /// <param name="angle"></param>
        /// <returns></returns>
        public ValueTask RotateAsync(double angle) => InvokeAsync("rotate", angle);
        /// <summary>
        /// Adds a scaling transformation to the canvas units by x horizontally and by y vertically.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public ValueTask ScaleAsync(double x, double y) => InvokeAsync("scale", x, y);
        /// <summary>
        /// Adds a translation transformation by moving the canvas and its origin x horzontally and y vertically on the grid.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public ValueTask TranslateAsync(double x, double y) => InvokeAsync("translate", x, y);
        /// <summary>
        /// Multiplies the current transformation matrix with the matrix described by its arguments.
        /// </summary>
        /// <param name="horizontal_scale"></param>
        /// <param name="vertical_skewing"></param>
        /// <param name="horizontal_skewing"></param>
        /// <param name="vertical_scaling"></param>
        /// <param name="horizontal_translation"></param>
        /// <param name="vertical_translation"></param>
        /// <returns></returns>
        public ValueTask TransformAsync(double horizontal_scale, double vertical_skewing, double horizontal_skewing, double vertical_scaling, double horizontal_translation, double vertical_translation) => InvokeAsync("transform", horizontal_scale, vertical_skewing, horizontal_skewing, vertical_scaling, horizontal_translation, vertical_translation);
        /// <summary>
        /// Resets the current transform to the identity matrix, and then invokes the transform() method with the same arguments.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public ValueTask SetTransformAsync(object values) => InvokeAsync("setTransform", values);
        /// <summary>
        /// Resets the current transform by the identity matrix.
        /// Experimental method. Use at own risk. See https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/resetTransform.
        /// Last checked: 2020-06-28. If you get the "Obsolete" message, but the state is no longer experimental, please contact the library maintainers.
        /// </summary>
        /// <returns></returns>
        [Obsolete("Experimental method. Use at own risk. See https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/resetTransform.")]
        public ValueTask ResetTransformAsync() => InvokeAsync("resetTransform");
    }
}
