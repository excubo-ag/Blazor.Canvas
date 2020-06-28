using Excubo.Blazor.Canvas.Extensions;
using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace Excubo.Blazor.Canvas.Contexts
{
    public partial class Context2D : Context
    {
        public Context2D(string ctx, IJSRuntime js) : base(ctx, js) { }
        #region drawing rectangles
        public ValueTask ClearRectAsync(double x, double y, double width, double height) => InvokeAsync("clearRect", x, y, width, height);
        public ValueTask FillRectAsync(double x, double y, double width, double height) => InvokeAsync("fillRect", x, y, width, height);
        public ValueTask StrokeRectAsync(double x, double y, double width, double height) => InvokeAsync("strokeRect", x, y, width, height);
        #endregion
        #region drawing text
        public ValueTask FillTextAsync(string text, double x, double y) => InvokeAsync("fillText", text, x, y);
        public ValueTask FillTextAsync(string text, double x, double y, double max_width) => InvokeAsync("fillText", text, x, y, max_width);
        public ValueTask StrokeTextAsync(string text, double x, double y) => InvokeAsync("strokeText", text, x, y);
        public ValueTask StrokeTextAsync(string text, double x, double y, double max_width) => InvokeAsync("strokeText", text, x, y, max_width);
        //public ValueTask MeasureTextAsync(string text) => throw new NotImplementedException("returns a TextMetrics object");
        #endregion
        #region line styles
        public ValueTask LineWidthAsync(double value) => SetAsync("lineWidth", value);
        public ValueTask LineCapAsync(LineCap value) => SetAsync("lineCap", value);
        public ValueTask LineJoinAsync(LineJoin value) => SetAsync("lineJoin", value);
        public ValueTask MiterLimitAsync(double value) => SetAsync("miterLimit", value);
        public ValueTask<double[]> GetLineDashAsync() => InvokeAsync<double[]>(ctx + ".getLineDash");
        public ValueTask SetLineDashAsync(double[] segments) => InvokeAsync("setLineDash", segments);
        public ValueTask LineDashOffsetAsync(double value) => SetAsync("lineDashOffset", value);
        #endregion
        #region text styles
        public ValueTask FontAsync(string value) => SetAsync("font", value);
        public ValueTask TextAlignAsync(TextAlign value) => SetAsync("textAlign", value);
        public ValueTask TextBaseLineAsync(TextBaseLine value) => SetAsync("textBaseLine", value);
        public ValueTask DirectionAsync(Direction value) => SetAsync("direction", value);
        #endregion
        #region fill and stroke styles
        /// <summary>
        /// Sets the fill style to the specified CSS color
        /// </summary>
        /// <param name="color">CSS color</param>
        /// <returns></returns>
        public ValueTask FillStyleAsync(string color) => SetAsync("fillStyle", color);
        /// <summary>
        /// Sets the fill style with a linear gradient
        /// </summary>
        public ValueTask FillStyleAsync(double x0, double y0, double x1, double y1) => InvokeEvalAsync("fillStyle", $"{ctx}.createLinearGradient(${x0.ToInvariantString()}, ${y0.ToInvariantString()}, ${x1.ToInvariantString()}, ${y1.ToInvariantString()})");
        /// <summary>
        /// Sets the fill style with a radial gradient
        /// </summary>
        public ValueTask FillStyleAsync(double x0, double y0, double r0, double x1, double y1, double r1) => InvokeEvalAsync("fillStyle", $"{ctx}.createLinearGradient(${x0.ToInvariantString()}, ${y0.ToInvariantString()}, ${r0.ToInvariantString()}, ${x1.ToInvariantString()}, ${y1.ToInvariantString()}, ${r1.ToInvariantString()})");
        public ValueTask FillStyleCanvasPatternAsync() => throw new NotImplementedException("assignment ctx.fillStyle = pattern");
        /// <summary>
        /// Sets the stroke style to the specified CSS color
        /// </summary>
        /// <param name="color">CSS color</param>
        /// <returns></returns>
        public ValueTask StrokeStyleAsync(string color) => SetAsync("strokeStyle", color);
        /// <summary>
        /// Sets the stroke style with a linear gradient
        /// </summary>
        public ValueTask StrokeStyleAsync(double x0, double y0, double x1, double y1) => InvokeEvalAsync("strokeStyle", $"{ctx}.createLinearGradient(${x0.ToInvariantString()}, ${y0.ToInvariantString()}, ${x1.ToInvariantString()}, ${y1.ToInvariantString()})");
        /// <summary>
        /// Sets the stroke style with a radial gradient
        /// </summary>
        public ValueTask StrokeStyleAsync(double x0, double y0, double r0, double x1, double y1, double r1) => InvokeEvalAsync("strokeStyle", $"{ctx}.createLinearGradient(${x0.ToInvariantString()}, ${y0.ToInvariantString()}, ${r0.ToInvariantString()}, ${x1.ToInvariantString()}, ${y1.ToInvariantString()}, ${r1.ToInvariantString()})");
        public ValueTask StrokeStyleCanvasPatternAsync() => throw new NotImplementedException("assignment ctx.strokeStyle = pattern");
        #endregion
        #region gradients and patterns
        // no API call here, as the APIs are merged with the FillStyle / StrokeStyle APIs.
        #endregion
        #region shadows
        public ValueTask ShadowBlurAsync(double level) => SetAsync("shadowBlur", level);
        public ValueTask ShadowColorAsync(string color) => SetAsync("shadowColor", color);
        public ValueTask ShadowOffsetXAsync(double offset) => SetAsync("shadowOffsetX", offset);
        public ValueTask ShadowOffsetYAsync(double offset) => SetAsync("shadowOffsetY", offset);
        #endregion
        #region paths
        public ValueTask BeginPathAsync() => InvokeAsync("beginPath");
        public ValueTask ClosePathAsync() => InvokeAsync("closePath");
        public ValueTask MoveToAsync(double x, double y) => InvokeAsync("moveTo", x, y);
        public ValueTask LineToAsync(double x, double y) => InvokeAsync("lineTo", x, y);
        public ValueTask BezierCurveToAsync(double cp1x, double cp1y, double cp2x, double cp2y, double x, double y) => InvokeAsync("bezierCurveTo", cp1x, cp1y, cp2x, cp2y, x, y);
        public ValueTask QuadraticCurveToAsync(double cpx, double cpy, double x, double y) => InvokeAsync("quadraticCurveTo", cpx, cpy, x, y);
        public ValueTask ArcAsync(double x, double y, double radius, double start_angle, double end_angle) => InvokeAsync("arc", x, y, radius, start_angle, end_angle);
        public ValueTask ArcAsync(double x, double y, double radius, double start_angle, double end_angle, bool anticlockwise) => InvokeAsync("arc", x, y, radius, start_angle, end_angle, anticlockwise);
        public ValueTask ArcToAsync(double x1, double y1, double x2, double y2, double radius) => InvokeAsync("arcTo", x1, y1, x2, y2, radius);
        public ValueTask EllipseAsync(double x, double y, double radius_x, double radius_y, double rotation, double start_angle, double end_angle) => InvokeAsync("ellipse", x, y, radius_x, radius_y, rotation, start_angle, end_angle);
        public ValueTask EllipseAsync(double x, double y, double radius_x, double radius_y, double rotation, double start_angle, double end_angle, bool anticlockwise) => InvokeAsync("ellipse", x, y, radius_x, radius_y, rotation, start_angle, end_angle, anticlockwise);
        public ValueTask RectAsync(double x, double y, double width, double height) => InvokeAsync("rect", x, y, width, height);
        #endregion
        #region drawing paths
        public ValueTask FillAsync(FillRule fill_rule) => SetAsync("fill", fill_rule);
        //NYI: fill Path path, FillRule fillRule
        public ValueTask StrokeAsync() => InvokeAsync("stroke");
        //NYI: stroke Path path
        //NYI: drawFocusIfNeeded Element element
        //NYI: drawFocusIfNeeded Path path, Element element
        //Still experimental public ValueTask ScrollPathIntoViewAsync() => InvokeAsync("scrollPathIntoView");
        //Still experimental NYI: scrollPathIntoView Path path
        public ValueTask ClipAsync(FillRule fill_rule) => SetAsync("clip", fill_rule);
        //NYI: clip Path path, FillRule fillRule
        public ValueTask<bool> IsPointInPathAsync(double x, double y, FillRule fill_rule) => InvokeAsync<bool>("isPointInPath", x, y, fill_rule.ToJsEnumValue());
        //NYI: isPointInPath Path path, double x, double y, FillRule fillRule
        public ValueTask<bool> IsPointInStrokeAsync(double x, double y) => InvokeAsync<bool>("isPointInStroke", x, y);
        //NYI: isPointInStroke Path path, double x, double y
        #endregion
        #region transformations
        public ValueTask<object> GetTransformAsync() => InvokeAsync<object>("getTransform");
        //public ValueTask SetTransformAsync(double[,] values) => InvokeAsync("setTransform", values);
        public ValueTask RotateAsync(double angle) => InvokeAsync("rotate", angle);
        public ValueTask ScaleAsync(double x, double y) => InvokeAsync("scale", x, y);
        public ValueTask TranslateAsync(double x, double y) => InvokeAsync("translate", x, y);
        public ValueTask TransformAsync(double horizontal_scale, double vertical_skewing, double horizontal_skewing, double vertical_scaling, double horizontal_translation, double vertical_translation) => InvokeAsync("transform", horizontal_scale, vertical_skewing, horizontal_skewing, vertical_scaling, horizontal_translation, vertical_translation);
        //resetTransform
        #endregion
        #region compositing
        public ValueTask GlobalAlphaAsync(double value) => SetAsync("globalAlpha", value);
        public ValueTask GlobalCompositeOperationAsync(CompositeOperation type) => SetAsync("globalCompositeOperation", type);
        #endregion
        #region drawing images
        //NYI: drawImage Image image, double destionation_x, double destionation_y
        //NYI: drawImage Image image, double destionation_x, double destionation_y, double destionation_width, double destionation_height
        //NYI: drawImage Image image, double source_x, double source_y, double source_width, double source_height, double destionation_x, double destionation_y, double destionation_width, double destionation_height
        #endregion
        #region pixel manipulation
        #endregion
        #region image smoothing
        public ValueTask ImageSmoothingEnabledAsync(bool value = true) => SetAsync("imageSmoothingEnabled", value);
        public ValueTask ImageSmoothingQualityAsync(ImageSmoothingQuality value) => SetAsync("imageSmoothingQuality", value);
        #endregion
        #region the canvas state
        public ValueTask SaveAsync() => InvokeAsync("save");
        public ValueTask RestoreAsync() => InvokeAsync("restore");
        #endregion
        #region hit regions
        // experimental and likely discontinued, so no impl.
        #endregion
        #region filters
        //NYI: public ValueTask Filter(params string[] filter_functions) => InvokeEvalAsync("filter", value); // TODO
        public ValueTask FilterAsync(string filter) => SetAsync("filter", filter);
        public ValueTask FilterAsync() => SetAsync("filter", "none");
        #endregion
    }
}
