using Excubo.Generators.Grouping;
using System.Threading.Tasks;

namespace Excubo.Blazor.Canvas.Contexts
{
    public partial class Context2D
    {
        /// <summary>
        /// <a href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D#Line_styles" />
        /// </summary>
        public partial struct _LineStyles { }
        /// <summary>
        /// Width of lines. Default 1.0.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "lineWidth"), Group(typeof(_LineStyles))]
        public ValueTask LineWidthAsync(double value) => SetAsync("lineWidth", value);
        /// <summary>
        /// Width of lines. Default 1.0.
        /// </summary>
        /// <returns>current value</returns>
        [Group(typeof(_JS), "lineWidth"), Group(typeof(_LineStyles))]
        public ValueTask<double> LineWidthAsync() => GetDoubleAsync("lineWidth");
        /// <summary>
        /// Type of endings on the end of lines. Possible values: butt (default), round, square.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "lineCap"), Group(typeof(_LineStyles))]
        public ValueTask LineCapAsync(LineCap value) => SetAsync("lineCap", value);
        /// <summary>
        /// Type of endings on the end of lines. Possible values: butt (default), round, square.
        /// </summary>
        /// <returns>current value</returns>
        [Group(typeof(_JS), "lineCap"), Group(typeof(_LineStyles))]
        public ValueTask<LineCap> LineCapAsync() => GetAsync<LineCap>("lineCap");
        /// <summary>
        /// Defines the type of corners where two lines meet. Possible values: round, bevel, miter (default).
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "lineJoin"), Group(typeof(_LineStyles))]
        public ValueTask LineJoinAsync(LineJoin value) => SetAsync("lineJoin", value);
        /// <summary>
        /// Defines the type of corners where two lines meet. Possible values: round, bevel, miter (default).
        /// </summary>
        /// <returns>current value</returns>
        [Group(typeof(_JS), "lineJoin"), Group(typeof(_LineStyles))]
        public ValueTask<LineJoin> LineJoinAsync() => GetAsync<LineJoin>("lineJoin");
        /// <summary>
        /// Miter limit ratio. Default 10.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "miterLimit"), Group(typeof(_LineStyles))]
        public ValueTask MiterLimitAsync(double value) => SetAsync("miterLimit", value);
        /// <summary>
        /// Miter limit ratio. Default 10.
        /// </summary>
        /// <returns>current value</returns>
        [Group(typeof(_JS), "miterLimit"), Group(typeof(_LineStyles))]
        public ValueTask<double> MiterLimitAsync() => GetDoubleAsync("miterLimit");
        /// <summary>
        /// Returns the current line dash pattern array containing an even number of non-negative numbers.
        /// </summary>
        /// <returns>current value</returns>
        [Group(typeof(_JS), "getLineDash"), Group(typeof(_LineStyles))]
        public ValueTask<double[]> GetLineDashAsync() => InvokeOnCtxAsync<double[]>(ctx + ".getLineDash");
        /// <summary>
        /// Sets the current line dash pattern.
        /// </summary>
        /// <param name="segments"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "setLineDash"), Group(typeof(_LineStyles))]
        public ValueTask SetLineDashAsync(double[] segments) => InvokeOnCtxAsync("setLineDash", segments);
        /// <summary>
        /// Specifies where to start a dash array on a line.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "lineDashOffset"), Group(typeof(_LineStyles))]
        public ValueTask LineDashOffsetAsync(double value) => SetAsync("lineDashOffset", value);
        /// <summary>
        /// Specifies where to start a dash array on a line.
        /// </summary>
        /// <returns>current value</returns>
        [Group(typeof(_JS), "lineDashOffset"), Group(typeof(_LineStyles))]
        public ValueTask<double> LineDashOffsetAsync() => GetDoubleAsync("lineDashOffset");
    }
    public partial class Batch2D
    {
        /// <summary>
        /// <a href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D#Line_styles" />
        /// </summary>
        public partial struct _LineStyles { }
        /// <summary>
        /// Width of lines. Default 1.0.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "lineWidth"), Group(typeof(_LineStyles))]
        public ValueTask LineWidthAsync(double value) => SetAsync("lineWidth", value);
        /// <summary>
        /// Type of endings on the end of lines. Possible values: butt (default), round, square.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "lineCap"), Group(typeof(_LineStyles))]
        public ValueTask LineCapAsync(LineCap value) => SetAsync("lineCap", value);
        /// <summary>
        /// Defines the type of corners where two lines meet. Possible values: round, bevel, miter (default).
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "lineJoin"), Group(typeof(_LineStyles))]
        public ValueTask LineJoinAsync(LineJoin value) => SetAsync("lineJoin", value);
        /// <summary>
        /// Miter limit ratio. Default 10.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "miterLimit"), Group(typeof(_LineStyles))]
        public ValueTask MiterLimitAsync(double value) => SetAsync("miterLimit", value);
        /// <summary>
        /// Sets the current line dash pattern.
        /// </summary>
        /// <param name="segments"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "setLineDash"), Group(typeof(_LineStyles))]
        public ValueTask SetLineDashAsync(double[] segments) => InvokeOnCtxAsync("setLineDash", segments);
        /// <summary>
        /// Specifies where to start a dash array on a line.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "lineDashOffset"), Group(typeof(_LineStyles))]
        public ValueTask LineDashOffsetAsync(double value) => SetAsync("lineDashOffset", value);
    }
}
