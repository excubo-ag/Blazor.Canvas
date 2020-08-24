using Excubo.Generators.Grouping;
using System;
using System.Threading.Tasks;

namespace Excubo.Blazor.Canvas.Contexts
{
    public partial class Context2D
    {
        /// <summary>
        /// <a href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D#Transformations" />
        /// </summary>
        public partial struct _Transformations : IContext2DWithoutGetters.I_Transformations { }
        /// <summary>
        /// Current transformation matrix
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "currentTransform"), Group(typeof(_Transformations))]
        public ValueTask CurrentTransformAsync(DOMMatrix value) => SetAsync("currentTransform", value);
        /// <summary>
        /// Current transformation matrix
        /// Experimental method. Use at own risk. See https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/currentTransform.
        /// Last checked: 2020-06-28. If you get the "Obsolete" message, but the state is no longer experimental, please contact the library maintainers.
        /// </summary>
        /// <returns></returns>
        [Obsolete("Experimental method. Use at own risk. See https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/currentTransform.")]
        [Group(typeof(_JS), "currentTransform"), Group(typeof(_Transformations))]
        public ValueTask<DOMMatrix> CurrentTransformAsync() => GetObjectAsync<DOMMatrix>("currentTransform");
        /// <summary>
        /// Retrieves the current transformation matrix being applied to the context.
        /// </summary>
        /// <returns></returns>
        [Group(typeof(_JS), "getTransform"), Group(typeof(_Transformations))]
        public ValueTask<DOMMatrix> GetTransformAsync() => InvokeOnCtxAsync<DOMMatrix>("getTransform");
        /// <summary>
        /// Adds a rotation to the transformation matrix. The angle argument represents a clockwise rotation angle and is expressed in radians
        /// </summary>
        /// <param name="angle"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "rotate"), Group(typeof(_Transformations))]
        public ValueTask RotateAsync(double angle) => InvokeOnCtxAsync("rotate", angle);
        /// <summary>
        /// Adds a scaling transformation to the canvas units by x horizontally and by y vertically.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "scale"), Group(typeof(_Transformations))]
        public ValueTask ScaleAsync(double x, double y) => InvokeOnCtxAsync("scale", x, y);
        /// <summary>
        /// Adds a translation transformation by moving the canvas and its origin x horzontally and y vertically on the grid.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "translate"), Group(typeof(_Transformations))]
        public ValueTask TranslateAsync(double x, double y) => InvokeOnCtxAsync("translate", x, y);
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
        [Group(typeof(_JS), "transform"), Group(typeof(_Transformations))]
        public ValueTask TransformAsync(double horizontal_scale, double vertical_skewing, double horizontal_skewing, double vertical_scaling, double horizontal_translation, double vertical_translation) => InvokeOnCtxAsync("transform", horizontal_scale, vertical_skewing, horizontal_skewing, vertical_scaling, horizontal_translation, vertical_translation);
        /// <summary>
        /// Resets the current transform to the identity matrix, and then invokes the transform() method with the same arguments.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "transform"), Group(typeof(_Transformations))]
        public ValueTask TransformAsync(DOMMatrix values) => InvokeOnCtxAsync("transform", values);
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
        [Group(typeof(_JS), "setTransform"), Group(typeof(_Transformations))]
        public ValueTask SetTransformAsync(double horizontal_scale, double vertical_skewing, double horizontal_skewing, double vertical_scaling, double horizontal_translation, double vertical_translation) => InvokeOnCtxAsync("setTransform", horizontal_scale, vertical_skewing, horizontal_skewing, vertical_scaling, horizontal_translation, vertical_translation);
        /// <summary>
        /// Resets the current transform to the identity matrix, and then invokes the transform() method with the same arguments.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "setTransform"), Group(typeof(_Transformations))]
        public ValueTask SetTransformAsync(DOMMatrix values) => InvokeOnCtxAsync("setTransform", values);
        /// <summary>
        /// Resets the current transform by the identity matrix.
        /// Experimental method. Use at own risk. See https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/resetTransform.
        /// Last checked: 2020-06-28. If you get the "Obsolete" message, but the state is no longer experimental, please contact the library maintainers.
        /// </summary>
        /// <returns></returns>
        [Obsolete("Experimental method. Use at own risk. See https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/resetTransform.")]
        [Group(typeof(_JS), "resetTransform"), Group(typeof(_Transformations))]
        public ValueTask ResetTransformAsync() => InvokeOnCtxAsync("resetTransform");
    }
    public partial class Batch2D
    {
        /// <summary>
        /// <a href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D#Transformations" />
        /// </summary>
        public partial struct _Transformations : IContext2DWithoutGetters.I_Transformations { }
        /// <summary>
        /// Current transformation matrix
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "currentTransform"), Group(typeof(_Transformations))]
        public ValueTask CurrentTransformAsync(DOMMatrix value) => SetAsync("currentTransform", value);
        /// <summary>
        /// Adds a rotation to the transformation matrix. The angle argument represents a clockwise rotation angle and is expressed in radians
        /// </summary>
        /// <param name="angle"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "rotate"), Group(typeof(_Transformations))]
        public ValueTask RotateAsync(double angle) => InvokeOnCtxAsync("rotate", angle);
        /// <summary>
        /// Adds a scaling transformation to the canvas units by x horizontally and by y vertically.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "scale"), Group(typeof(_Transformations))]
        public ValueTask ScaleAsync(double x, double y) => InvokeOnCtxAsync("scale", x, y);
        /// <summary>
        /// Adds a translation transformation by moving the canvas and its origin x horzontally and y vertically on the grid.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "translate"), Group(typeof(_Transformations))]
        public ValueTask TranslateAsync(double x, double y) => InvokeOnCtxAsync("translate", x, y);
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
        [Group(typeof(_JS), "transform"), Group(typeof(_Transformations))]
        public ValueTask TransformAsync(double horizontal_scale, double vertical_skewing, double horizontal_skewing, double vertical_scaling, double horizontal_translation, double vertical_translation) => InvokeOnCtxAsync("transform", horizontal_scale, vertical_skewing, horizontal_skewing, vertical_scaling, horizontal_translation, vertical_translation);
        /// <summary>
        /// Resets the current transform to the identity matrix, and then invokes the transform() method with the same arguments.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "transform"), Group(typeof(_Transformations))]
        public ValueTask TransformAsync(DOMMatrix values) => InvokeOnCtxAsync("transform", values);
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
        [Group(typeof(_JS), "setTransform"), Group(typeof(_Transformations))]
        public ValueTask SetTransformAsync(double horizontal_scale, double vertical_skewing, double horizontal_skewing, double vertical_scaling, double horizontal_translation, double vertical_translation) => InvokeOnCtxAsync("setTransform", horizontal_scale, vertical_skewing, horizontal_skewing, vertical_scaling, horizontal_translation, vertical_translation);
        /// <summary>
        /// Resets the current transform to the identity matrix, and then invokes the transform() method with the same arguments.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "setTransform"), Group(typeof(_Transformations))]
        public ValueTask SetTransformAsync(DOMMatrix values) => InvokeOnCtxAsync("setTransform", values);
        /// <summary>
        /// Resets the current transform by the identity matrix.
        /// Experimental method. Use at own risk. See https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/resetTransform.
        /// Last checked: 2020-06-28. If you get the "Obsolete" message, but the state is no longer experimental, please contact the library maintainers.
        /// </summary>
        /// <returns></returns>
        [Obsolete("Experimental method. Use at own risk. See https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/resetTransform.")]
        [Group(typeof(_JS), "resetTransform"), Group(typeof(_Transformations))]
        public ValueTask ResetTransformAsync() => InvokeOnCtxAsync("resetTransform");
    }
}
