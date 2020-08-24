using Excubo.Generators.Grouping;
using System.Threading.Tasks;

namespace Excubo.Blazor.Canvas.Contexts
{
    public sealed class Filter
    {
        private Filter() { }
        public static readonly Filter None = default;
    }
    public partial interface IContext2DWithoutGetters
    {
        /// <summary>
        /// If you are used to the javascript naming convention and want to use it in C# too, use context.<see cref="JS"/> instead of context.
        /// </summary>
        public partial interface I_JS { }
        #region CanvasState
        /// <summary>
        /// State management. <a href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D#The_canvas_state"/>
        /// </summary>
        public partial interface I_CanvasState { }
        [Group(typeof(I_JS), "restore"), Group(typeof(I_CanvasState))]
        ValueTask RestoreAsync();
        [Group(typeof(I_JS), "save"), Group(typeof(I_CanvasState))]
        ValueTask SaveAsync();
        #endregion
        #region Compositing
        /// <summary>
        /// <a href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D#Compositing" />
        /// </summary>
        public partial interface I_Compositing { }
        [Group(typeof(I_JS), "globalAlpha"), Group(typeof(I_Compositing))]
        ValueTask GlobalAlphaAsync(double value);
        [Group(typeof(I_JS), "globalCompositeOperation"), Group(typeof(I_Compositing))]
        ValueTask GlobalCompositeOperationAsync(CompositeOperation type);
        #endregion
        #region DrawingImages
        /// <summary>
        /// <a href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D#Drawing_images" />
        /// </summary>
        public partial interface I_DrawingImages { }
        [Group(typeof(I_JS), "drawImage"), Group(typeof(I_DrawingImages))]
        ValueTask DrawImageAsync(string image, double dx, double dy);
        [Group(typeof(I_JS), "drawImage"), Group(typeof(I_DrawingImages))]
        ValueTask DrawImageAsync(string image, double dx, double dy, double dwidth, double dheight);
        [Group(typeof(I_JS), "drawImage"), Group(typeof(I_DrawingImages))]
        ValueTask DrawImageAsync(string image, double sx, double sy, double swidth, double sheight, double dx, double dy, double dwidth, double dheight);
        #endregion
        #region DrawingPaths
        /// <summary>
        /// <a href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D#Drawing_paths" />
        /// </summary>
        public partial interface I_DrawingPaths { }
        [Group(typeof(I_JS), "clip"), Group(typeof(I_DrawingPaths))]
        ValueTask ClipAsync(FillRule fill_rule);
        [Group(typeof(I_JS), "clip"), Group(typeof(I_DrawingPaths))]
        ValueTask ClipAsync(string path, FillRule fill_rule);
        [Group(typeof(I_JS), "drawFocusIfNeeded"), Group(typeof(I_DrawingPaths))]
        ValueTask DrawFocusIfNeededAsync(string element);
        [Group(typeof(I_JS), "drawFocusIfNeeded"), Group(typeof(I_DrawingPaths))]
        ValueTask DrawFocusIfNeededAsync(string path, string element);
        [Group(typeof(I_JS), "fill"), Group(typeof(I_DrawingPaths))]
        ValueTask FillAsync(FillRule fill_rule);
        [Group(typeof(I_JS), "fill"), Group(typeof(I_DrawingPaths))]
        ValueTask FillAsync(string path, FillRule fill_rule);
        [Group(typeof(I_JS), "scrollPathIntoView"), Group(typeof(I_DrawingPaths))]
        ValueTask ScrollPathIntoViewAsync();
        [Group(typeof(I_JS), "scrollPathIntoView"), Group(typeof(I_DrawingPaths))]
        ValueTask ScrollPathIntoViewAsync(string path);
        [Group(typeof(I_JS), "stroke"), Group(typeof(I_DrawingPaths))]
        ValueTask StrokeAsync();
        [Group(typeof(I_JS), "stroke"), Group(typeof(I_DrawingPaths))]
        ValueTask StrokeAsync(string path);
        #endregion
        #region DrawingRectangles
        /// <summary>
        /// <a href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D#Drawing_rectangles" />
        /// </summary>
        public partial interface I_DrawingRectangles { }
        [Group(typeof(I_JS), "clearRect"), Group(typeof(I_DrawingRectangles))]
        ValueTask ClearRectAsync(double x, double y, double width, double height);
        [Group(typeof(I_JS), "fillRect"), Group(typeof(I_DrawingRectangles))]
        ValueTask FillRectAsync(double x, double y, double width, double height);
        [Group(typeof(I_JS), "strokeRect"), Group(typeof(I_DrawingRectangles))]
        ValueTask StrokeRectAsync(double x, double y, double width, double height);
        #endregion
        #region DrawingText
        /// <summary>
        /// <a href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D#Drawing_text" />
        /// </summary>
        public partial interface I_DrawingText { }
        [Group(typeof(I_JS), "fillText"), Group(typeof(I_DrawingText))]
        ValueTask FillTextAsync(string text, double x, double y);
        [Group(typeof(I_JS), "fillText"), Group(typeof(I_DrawingText))]
        ValueTask FillTextAsync(string text, double x, double y, double max_width);
        [Group(typeof(I_JS), "strokeText"), Group(typeof(I_DrawingText))]
        ValueTask StrokeTextAsync(string text, double x, double y);
        [Group(typeof(I_JS), "strokeText"), Group(typeof(I_DrawingText))]
        ValueTask StrokeTextAsync(string text, double x, double y, double max_width);
        #endregion
        #region FillAndStrokeStyles
        /// <summary>
        /// <a href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D#Fill_and_stroke_styles" />
        /// </summary>
        public partial interface I_FillAndStrokeStyles { }
        [Group(typeof(I_JS), "fillStyle"), Group(typeof(I_FillAndStrokeStyles))]
        ValueTask FillStyleAsync(double x0, double y0, double r0, double x1, double y1, double r1, params (double Offset, string Color)[] color_stops);
        [Group(typeof(I_JS), "fillStyle"), Group(typeof(I_FillAndStrokeStyles))]
        ValueTask FillStyleAsync(double x0, double y0, double x1, double y1, params (double Offset, string Color)[] color_stops);
        [Group(typeof(I_JS), "fillStyle"), Group(typeof(I_FillAndStrokeStyles))]
        ValueTask FillStyleAsync(string color);
        [Group(typeof(I_JS), "fillStyle"), Group(typeof(I_FillAndStrokeStyles))]
        ValueTask FillStyleAsync(string image, Repetition repetition);
        [Group(typeof(I_JS), "strokeStyle"), Group(typeof(I_FillAndStrokeStyles))]
        ValueTask StrokeStyleAsync(double x0, double y0, double r0, double x1, double y1, double r1, params (double Offset, string Color)[] color_stops);
        [Group(typeof(I_JS), "strokeStyle"), Group(typeof(I_FillAndStrokeStyles))]
        ValueTask StrokeStyleAsync(double x0, double y0, double x1, double y1, params (double Offset, string Color)[] color_stops);
        [Group(typeof(I_JS), "strokeStyle"), Group(typeof(I_FillAndStrokeStyles))]
        ValueTask StrokeStyleAsync(string color);
        [Group(typeof(I_JS), "strokeStyle"), Group(typeof(I_FillAndStrokeStyles))]
        ValueTask StrokeStyleAsync(string image, Repetition repetition);
        #endregion
        #region Filters
        /// <summary>
        /// <a href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D#Filters" />
        /// </summary>
        public partial interface I_Filters { }
        [Group(typeof(I_JS), "filter"), Group(typeof(I_Filters))]
        ValueTask FilterAsync(Filter none);
        [Group(typeof(I_JS), "filter"), Group(typeof(I_Filters))]
        ValueTask FilterAsync(params string[] filter_functions);
        [Group(typeof(I_JS), "filter"), Group(typeof(I_Filters))]
        ValueTask FilterAsync(string filter);
        #endregion
        #region ImageSmoothing
        /// <summary>
        /// <a href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D#Image_smoothing" />
        /// </summary>
        public partial interface I_ImageSmoothing { }
        [Group(typeof(I_JS), "imageSmoothingEnabled"), Group(typeof(I_ImageSmoothing))]
        ValueTask ImageSmoothingEnabledAsync(bool value);
        [Group(typeof(I_JS), "imageSmoothingQuality"), Group(typeof(I_ImageSmoothing))]
        ValueTask ImageSmoothingQualityAsync(ImageSmoothingQuality value);
        #endregion
        #region LineStyles
        /// <summary>
        /// <a href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D#Line_styles" />
        /// </summary>
        public partial interface I_LineStyles { }
        [Group(typeof(I_JS), "lineWidth"), Group(typeof(I_LineStyles))]
        ValueTask LineWidthAsync(double value);
        [Group(typeof(I_JS), "lineCap"), Group(typeof(I_LineStyles))]
        ValueTask LineCapAsync(LineCap value);
        [Group(typeof(I_JS), "lineJoin"), Group(typeof(I_LineStyles))]
        ValueTask LineJoinAsync(LineJoin value);
        [Group(typeof(I_JS), "miterLimit"), Group(typeof(I_LineStyles))]
        ValueTask MiterLimitAsync(double value);
        [Group(typeof(I_JS), "setLineDash"), Group(typeof(I_LineStyles))]
        ValueTask SetLineDashAsync(double[] segments);
        [Group(typeof(I_JS), "lineDashOffset"), Group(typeof(I_LineStyles))]
        ValueTask LineDashOffsetAsync(double value);
        #endregion
        #region Paths
        /// <summary>
        /// <a href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D#Paths" />
        /// </summary>
        public partial interface I_Paths { }
        [Group(typeof(I_JS), "arc"), Group(typeof(I_Paths))]
        ValueTask ArcAsync(double x, double y, double radius, double start_angle, double end_angle);
        [Group(typeof(I_JS), "arc"), Group(typeof(I_Paths))]
        ValueTask ArcAsync(double x, double y, double radius, double start_angle, double end_angle, bool anticlockwise);
        [Group(typeof(I_JS), "arcTo"), Group(typeof(I_Paths))]
        ValueTask ArcToAsync(double x1, double y1, double x2, double y2, double radius);
        [Group(typeof(I_JS), "beginPath"), Group(typeof(I_Paths))]
        ValueTask BeginPathAsync();
        [Group(typeof(I_JS), "bezierCurveTo"), Group(typeof(I_Paths))]
        ValueTask BezierCurveToAsync(double cp1x, double cp1y, double cp2x, double cp2y, double x, double y);
        [Group(typeof(I_JS), "closePath"), Group(typeof(I_Paths))]
        ValueTask ClosePathAsync();
        [Group(typeof(I_JS), "ellipse"), Group(typeof(I_Paths))]
        ValueTask EllipseAsync(double x, double y, double radius_x, double radius_y, double rotation, double start_angle, double end_angle);
        [Group(typeof(I_JS), "ellipse"), Group(typeof(I_Paths))]
        ValueTask EllipseAsync(double x, double y, double radius_x, double radius_y, double rotation, double start_angle, double end_angle, bool anticlockwise);
        [Group(typeof(I_JS), "lineTo"), Group(typeof(I_Paths))]
        ValueTask LineToAsync(double x, double y);
        [Group(typeof(I_JS), "moveTo"), Group(typeof(I_Paths))]
        ValueTask MoveToAsync(double x, double y);
        [Group(typeof(I_JS), "quadraticCurveTo"), Group(typeof(I_Paths))]
        ValueTask QuadraticCurveToAsync(double cpx, double cpy, double x, double y);
        [Group(typeof(I_JS), "rect"), Group(typeof(I_Paths))]
        ValueTask RectAsync(double x, double y, double width, double height);
        #endregion
        #region PixelManipulation
        /// <summary>
        /// <a href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D#Pixel_manipulation" />
        /// </summary>
        public partial interface I_PixelManipulation { }
        [Group(typeof(I_JS), "putImageData"), Group(typeof(I_PixelManipulation))]
        ValueTask PutImageDataAsync(string id, double dx, double dy);
        [Group(typeof(I_JS), "putImageData"), Group(typeof(I_PixelManipulation))]
        ValueTask PutImageDataAsync(string id, double dx, double dy, double dirty_x, double dirty_y, double dirty_width, double dirty_height);
        #endregion
        #region Shadows
        /// <summary>
        /// <a href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D#Shadows" />
        /// </summary>
        public partial interface I_Shadows { }
        [Group(typeof(I_JS), "shadowBlur"), Group(typeof(I_Shadows), "BlurAsync")]
        ValueTask ShadowBlurAsync(double level);
        [Group(typeof(I_JS), "shadowColor"), Group(typeof(I_Shadows), "ColorAsync")]
        ValueTask ShadowColorAsync(string color);
        [Group(typeof(I_JS), "shadowOffsetX"), Group(typeof(I_Shadows), "OffsetXAsync")]
        ValueTask ShadowOffsetXAsync(double offset);
        [Group(typeof(I_JS), "shadowOffsetY"), Group(typeof(I_Shadows), "OffsetYAsync")]
        ValueTask ShadowOffsetYAsync(double offset);
        #endregion
        #region TextStyles
        /// <summary>
        /// <a href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D#Text_styles" />
        /// </summary>
        public partial interface I_TextStyles { }
        [Group(typeof(I_JS), "direction"), Group(typeof(I_TextStyles))]
        ValueTask DirectionAsync(Direction value);
        [Group(typeof(I_JS), "font"), Group(typeof(I_TextStyles))]
        ValueTask FontAsync(string value);
        [Group(typeof(I_JS), "textAlign"), Group(typeof(I_TextStyles))]
        ValueTask TextAlignAsync(TextAlign value);
        [Group(typeof(I_JS), "textBaseLine"), Group(typeof(I_TextStyles))]
        ValueTask TextBaseLineAsync(TextBaseLine value);
        #endregion
        #region Transformations
        /// <summary>
        /// <a href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D#Transformations" />
        /// </summary>
        public partial interface I_Transformations { }
        [Group(typeof(I_JS), "currentTransform"), Group(typeof(I_Transformations))]
        ValueTask CurrentTransformAsync(DOMMatrix value);
        [Group(typeof(I_JS), "resetTransform"), Group(typeof(I_Transformations))]
        ValueTask ResetTransformAsync();
        [Group(typeof(I_JS), "rotate"), Group(typeof(I_Transformations))]
        ValueTask RotateAsync(double angle);
        [Group(typeof(I_JS), "scale"), Group(typeof(I_Transformations))]
        ValueTask ScaleAsync(double x, double y);
        [Group(typeof(I_JS), "setTransform"), Group(typeof(I_Transformations))]
        ValueTask SetTransformAsync(DOMMatrix values);
        [Group(typeof(I_JS), "setTransform"), Group(typeof(I_Transformations))]
        ValueTask SetTransformAsync(double horizontal_scale, double vertical_skewing, double horizontal_skewing, double vertical_scaling, double horizontal_translation, double vertical_translation);
        [Group(typeof(I_JS), "transform"), Group(typeof(I_Transformations))]
        ValueTask TransformAsync(DOMMatrix values);
        [Group(typeof(I_JS), "transform"), Group(typeof(I_Transformations))]
        ValueTask TransformAsync(double horizontal_scale, double vertical_skewing, double horizontal_skewing, double vertical_scaling, double horizontal_translation, double vertical_translation);
        [Group(typeof(I_JS), "translate"), Group(typeof(I_Transformations))]
        ValueTask TranslateAsync(double x, double y);
        #endregion
    }
}