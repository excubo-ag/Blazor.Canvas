using System.Threading.Tasks;

namespace Excubo.Blazor.Canvas.Contexts
{
    public partial class Context2D
    {
        /// <summary>
        /// Starts a new path by emptying the list of sub-paths. Call this method when you want to create a new path.
        /// </summary>
        /// <returns></returns>
        public ValueTask BeginPathAsync() => InvokeOnCtxAsync("beginPath");
        /// <summary>
        /// Causes the point of the pen to move back to the start of the current sub-path. It tries to draw a straight line from the current point to the start. If the shape has already been closed or has only one point, this function does nothing.
        /// </summary>
        /// <returns></returns>
        public ValueTask ClosePathAsync() => InvokeOnCtxAsync("closePath");
        /// <summary>
        /// Moves the starting point of a new sub-path to the (x, y) coordinates.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public ValueTask MoveToAsync(double x, double y) => InvokeOnCtxAsync("moveTo", x, y);
        /// <summary>
        /// Connects the last point in the current sub-path to the specified (x, y) coordinates with a straight line.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public ValueTask LineToAsync(double x, double y) => InvokeOnCtxAsync("lineTo", x, y);
        /// <summary>
        /// Adds a cubic Bézier curve to the current path.
        /// </summary>
        /// <param name="cp1x"></param>
        /// <param name="cp1y"></param>
        /// <param name="cp2x"></param>
        /// <param name="cp2y"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public ValueTask BezierCurveToAsync(double cp1x, double cp1y, double cp2x, double cp2y, double x, double y) => InvokeOnCtxAsync("bezierCurveTo", cp1x, cp1y, cp2x, cp2y, x, y);
        /// <summary>
        /// Adds a quadratic Bézier curve to the current path.
        /// </summary>
        /// <param name="cpx"></param>
        /// <param name="cpy"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public ValueTask QuadraticCurveToAsync(double cpx, double cpy, double x, double y) => InvokeOnCtxAsync("quadraticCurveTo", cpx, cpy, x, y);
        /// <summary>
        /// Adds a circular arc to the current path.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="radius"></param>
        /// <param name="start_angle"></param>
        /// <param name="end_angle"></param>
        /// <returns></returns>
        public ValueTask ArcAsync(double x, double y, double radius, double start_angle, double end_angle) => InvokeOnCtxAsync("arc", x, y, radius, start_angle, end_angle);
        /// <summary>
        /// Adds a circular arc to the current path.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="radius"></param>
        /// <param name="start_angle"></param>
        /// <param name="end_angle"></param>
        /// <param name="anticlockwise"></param>
        /// <returns></returns>
        public ValueTask ArcAsync(double x, double y, double radius, double start_angle, double end_angle, bool anticlockwise) => InvokeOnCtxAsync("arc", x, y, radius, start_angle, end_angle, anticlockwise);
        /// <summary>
        /// Adds an arc to the current path with the given control points and radius, connected to the previous point by a straight line.
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <param name="radius"></param>
        /// <returns></returns>
        public ValueTask ArcToAsync(double x1, double y1, double x2, double y2, double radius) => InvokeOnCtxAsync("arcTo", x1, y1, x2, y2, radius);
        /// <summary>
        /// Adds an elliptical arc to the current path.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="radius_x"></param>
        /// <param name="radius_y"></param>
        /// <param name="rotation"></param>
        /// <param name="start_angle"></param>
        /// <param name="end_angle"></param>
        /// <returns></returns>
        public ValueTask EllipseAsync(double x, double y, double radius_x, double radius_y, double rotation, double start_angle, double end_angle) => InvokeOnCtxAsync("ellipse", x, y, radius_x, radius_y, rotation, start_angle, end_angle);
        /// <summary>
        /// Adds an elliptical arc to the current path.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="radius_x"></param>
        /// <param name="radius_y"></param>
        /// <param name="rotation"></param>
        /// <param name="start_angle"></param>
        /// <param name="end_angle"></param>
        /// <param name="anticlockwise"></param>
        /// <returns></returns>
        public ValueTask EllipseAsync(double x, double y, double radius_x, double radius_y, double rotation, double start_angle, double end_angle, bool anticlockwise) => InvokeOnCtxAsync("ellipse", x, y, radius_x, radius_y, rotation, start_angle, end_angle, anticlockwise);
        /// <summary>
        /// Creates a path for a rectangle at position (x, y) with a size that is determined by width and height.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public ValueTask RectAsync(double x, double y, double width, double height) => InvokeOnCtxAsync("rect", x, y, width, height);
    }
    public partial class Batch2D
    {
        /// <summary>
        /// Starts a new path by emptying the list of sub-paths. Call this method when you want to create a new path.
        /// </summary>
        /// <returns></returns>
        public ValueTask BeginPathAsync() => InvokeOnCtxAsync("beginPath");
        /// <summary>
        /// Causes the point of the pen to move back to the start of the current sub-path. It tries to draw a straight line from the current point to the start. If the shape has already been closed or has only one point, this function does nothing.
        /// </summary>
        /// <returns></returns>
        public ValueTask ClosePathAsync() => InvokeOnCtxAsync("closePath");
        /// <summary>
        /// Moves the starting point of a new sub-path to the (x, y) coordinates.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public ValueTask MoveToAsync(double x, double y) => InvokeOnCtxAsync("moveTo", x, y);
        /// <summary>
        /// Connects the last point in the current sub-path to the specified (x, y) coordinates with a straight line.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public ValueTask LineToAsync(double x, double y) => InvokeOnCtxAsync("lineTo", x, y);
        /// <summary>
        /// Adds a cubic Bézier curve to the current path.
        /// </summary>
        /// <param name="cp1x"></param>
        /// <param name="cp1y"></param>
        /// <param name="cp2x"></param>
        /// <param name="cp2y"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public ValueTask BezierCurveToAsync(double cp1x, double cp1y, double cp2x, double cp2y, double x, double y) => InvokeOnCtxAsync("bezierCurveTo", cp1x, cp1y, cp2x, cp2y, x, y);
        /// <summary>
        /// Adds a quadratic Bézier curve to the current path.
        /// </summary>
        /// <param name="cpx"></param>
        /// <param name="cpy"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public ValueTask QuadraticCurveToAsync(double cpx, double cpy, double x, double y) => InvokeOnCtxAsync("quadraticCurveTo", cpx, cpy, x, y);
        /// <summary>
        /// Adds a circular arc to the current path.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="radius"></param>
        /// <param name="start_angle"></param>
        /// <param name="end_angle"></param>
        /// <returns></returns>
        public ValueTask ArcAsync(double x, double y, double radius, double start_angle, double end_angle) => InvokeOnCtxAsync("arc", x, y, radius, start_angle, end_angle);
        /// <summary>
        /// Adds a circular arc to the current path.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="radius"></param>
        /// <param name="start_angle"></param>
        /// <param name="end_angle"></param>
        /// <param name="anticlockwise"></param>
        /// <returns></returns>
        public ValueTask ArcAsync(double x, double y, double radius, double start_angle, double end_angle, bool anticlockwise) => InvokeOnCtxAsync("arc", x, y, radius, start_angle, end_angle, anticlockwise);
        /// <summary>
        /// Adds an arc to the current path with the given control points and radius, connected to the previous point by a straight line.
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <param name="radius"></param>
        /// <returns></returns>
        public ValueTask ArcToAsync(double x1, double y1, double x2, double y2, double radius) => InvokeOnCtxAsync("arcTo", x1, y1, x2, y2, radius);
        /// <summary>
        /// Adds an elliptical arc to the current path.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="radius_x"></param>
        /// <param name="radius_y"></param>
        /// <param name="rotation"></param>
        /// <param name="start_angle"></param>
        /// <param name="end_angle"></param>
        /// <returns></returns>
        public ValueTask EllipseAsync(double x, double y, double radius_x, double radius_y, double rotation, double start_angle, double end_angle) => InvokeOnCtxAsync("ellipse", x, y, radius_x, radius_y, rotation, start_angle, end_angle);
        /// <summary>
        /// Adds an elliptical arc to the current path.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="radius_x"></param>
        /// <param name="radius_y"></param>
        /// <param name="rotation"></param>
        /// <param name="start_angle"></param>
        /// <param name="end_angle"></param>
        /// <param name="anticlockwise"></param>
        /// <returns></returns>
        public ValueTask EllipseAsync(double x, double y, double radius_x, double radius_y, double rotation, double start_angle, double end_angle, bool anticlockwise) => InvokeOnCtxAsync("ellipse", x, y, radius_x, radius_y, rotation, start_angle, end_angle, anticlockwise);
        /// <summary>
        /// Creates a path for a rectangle at position (x, y) with a size that is determined by width and height.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public ValueTask RectAsync(double x, double y, double width, double height) => InvokeOnCtxAsync("rect", x, y, width, height);
    }
}
