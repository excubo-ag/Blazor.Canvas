using System.Threading.Tasks;

namespace Excubo.Blazor.Canvas.Contexts
{
    public sealed class Filter
    {
        private Filter() { }
        public static readonly Filter None = default;
    }
    public interface IContext2DWithoutGetters
    {
        ValueTask ArcAsync(double x, double y, double radius, double start_angle, double end_angle);
        ValueTask ArcAsync(double x, double y, double radius, double start_angle, double end_angle, bool anticlockwise);
        ValueTask ArcToAsync(double x1, double y1, double x2, double y2, double radius);
        ValueTask BeginPathAsync();
        ValueTask BezierCurveToAsync(double cp1x, double cp1y, double cp2x, double cp2y, double x, double y);
        ValueTask ClearRectAsync(double x, double y, double width, double height);
        ValueTask ClipAsync(FillRule fill_rule);
        ValueTask ClipAsync(string path, FillRule fill_rule);
        ValueTask ClosePathAsync();
        ValueTask CurrentTransformAsync(DOMMatrix value);
        ValueTask DirectionAsync(Direction value);
        ValueTask DrawFocusIfNeededAsync(string element);
        ValueTask DrawFocusIfNeededAsync(string path, string element);
        ValueTask DrawImageAsync(string image, double dx, double dy);
        ValueTask DrawImageAsync(string image, double dx, double dy, double dwidth, double dheight);
        ValueTask DrawImageAsync(string image, double sx, double sy, double swidth, double sheight, double dx, double dy, double dwidth, double dheight);
        ValueTask EllipseAsync(double x, double y, double radius_x, double radius_y, double rotation, double start_angle, double end_angle);
        ValueTask EllipseAsync(double x, double y, double radius_x, double radius_y, double rotation, double start_angle, double end_angle, bool anticlockwise);
        ValueTask FillAsync(FillRule fill_rule);
        ValueTask FillAsync(string path, FillRule fill_rule);
        ValueTask FillRectAsync(double x, double y, double width, double height);
        ValueTask FillStyleAsync(double x0, double y0, double r0, double x1, double y1, double r1, params (double Offset, string Color)[] color_stops);
        ValueTask FillStyleAsync(double x0, double y0, double x1, double y1, params (double Offset, string Color)[] color_stops);
        ValueTask FillStyleAsync(string color);
        ValueTask FillStyleAsync(string image, Repetition repetition);
        ValueTask FillTextAsync(string text, double x, double y);
        ValueTask FillTextAsync(string text, double x, double y, double max_width);
        ValueTask FilterAsync(Filter none);
        ValueTask FilterAsync(params string[] filter_functions);
        ValueTask FilterAsync(string filter);
        ValueTask FontAsync(string value);
        ValueTask GlobalAlphaAsync(double value);
        ValueTask GlobalCompositeOperationAsync(CompositeOperation type);
        ValueTask ImageSmoothingEnabledAsync(bool value);
        ValueTask ImageSmoothingQualityAsync(ImageSmoothingQuality value);
        ValueTask LineCapAsync(LineCap value);
        ValueTask LineDashOffsetAsync(double value);
        ValueTask LineJoinAsync(LineJoin value);
        ValueTask LineToAsync(double x, double y);
        ValueTask LineWidthAsync(double value);
        ValueTask MiterLimitAsync(double value);
        ValueTask MoveToAsync(double x, double y);
        ValueTask PutImageDataAsync(string id, double dx, double dy);
        ValueTask PutImageDataAsync(string id, double dx, double dy, double dirty_x, double dirty_y, double dirty_width, double dirty_height);
        ValueTask QuadraticCurveToAsync(double cpx, double cpy, double x, double y);
        ValueTask RectAsync(double x, double y, double width, double height);
        ValueTask ResetTransformAsync();
        ValueTask RestoreAsync();
        ValueTask RotateAsync(double angle);
        ValueTask SaveAsync();
        ValueTask ScaleAsync(double x, double y);
        ValueTask ScrollPathIntoViewAsync();
        ValueTask ScrollPathIntoViewAsync(string path);
        ValueTask SetLineDashAsync(double[] segments);
        ValueTask SetTransformAsync(DOMMatrix values);
        ValueTask SetTransformAsync(double horizontal_scale, double vertical_skewing, double horizontal_skewing, double vertical_scaling, double horizontal_translation, double vertical_translation);
        ValueTask ShadowBlurAsync(double level);
        ValueTask ShadowColorAsync(string color);
        ValueTask ShadowOffsetXAsync(double offset);
        ValueTask ShadowOffsetYAsync(double offset);
        ValueTask StrokeAsync();
        ValueTask StrokeAsync(string path);
        ValueTask StrokeRectAsync(double x, double y, double width, double height);
        ValueTask StrokeStyleAsync(double x0, double y0, double r0, double x1, double y1, double r1, params (double Offset, string Color)[] color_stops);
        ValueTask StrokeStyleAsync(double x0, double y0, double x1, double y1, params (double Offset, string Color)[] color_stops);
        ValueTask StrokeStyleAsync(string color);
        ValueTask StrokeStyleAsync(string image, Repetition repetition);
        ValueTask StrokeTextAsync(string text, double x, double y);
        ValueTask StrokeTextAsync(string text, double x, double y, double max_width);
        ValueTask TextAlignAsync(TextAlign value);
        ValueTask TextBaseLineAsync(TextBaseLine value);
        ValueTask TransformAsync(DOMMatrix values);
        ValueTask TransformAsync(double horizontal_scale, double vertical_skewing, double horizontal_skewing, double vertical_scaling, double horizontal_translation, double vertical_translation);
        ValueTask TranslateAsync(double x, double y);
    }
}