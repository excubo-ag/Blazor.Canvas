using Excubo.Blazor.Canvas.Extensions;
using Excubo.Generators.Grouping;
using System.Linq;
using System.Threading.Tasks;

namespace Excubo.Blazor.Canvas.Contexts
{
    public partial class Context2D
    {
        /// <summary>
        /// <a href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D#Fill_and_stroke_styles" />
        /// </summary>
        public partial struct _FillAndStrokeStyles : IContext2DWithoutGetters.I_FillAndStrokeStyles { }
        /// <summary>
        /// Color or style to use inside shapes. Default #000 (black).
        /// </summary>
        /// <param name="color">CSS color</param>
        /// <returns></returns>
        [Group(typeof(_JS), "fillStyle"), Group(typeof(_FillAndStrokeStyles))]
        public ValueTask FillStyleAsync(string color) => SetAsync("fillStyle", color);
        /// <summary>
        /// Color or style to use inside shapes. Default #000 (black).
        /// </summary>
        /// <returns>current value</returns>
        [Group(typeof(_JS), "fillStyle"), Group(typeof(_FillAndStrokeStyles))]
        public ValueTask<string> FillStyleAsync() => GetStringAsync("fillStyle");
        /// <summary>
        /// Color or style to use inside shapes.
        /// Sets the fill style with a linear gradient.
        /// </summary>
        [Group(typeof(_JS), "fillStyle"), Group(typeof(_FillAndStrokeStyles))]
        public ValueTask FillStyleAsync(double x0, double y0, double x1, double y1, params (double Offset, string Color)[] color_stops) => InvokeEvalAsync(
            $"let gradient = {ctx}.createLinearGradient({x0.ToInvariantString()}, {y0.ToInvariantString()}, {x1.ToInvariantString()}, {y1.ToInvariantString()});" + // create gradient
            string.Join("", color_stops.Select(cs => $"gradient.addColorStop({cs.Offset.ToInvariantString()}, '{cs.Color}');")) + // add color stops
            $"{ctx}.fillStyle = gradient;"); // set gradient
        /// <summary>
        /// Color or style to use inside shapes.
        /// Sets the fill style with a radial gradient.
        /// </summary>
        [Group(typeof(_JS), "fillStyle"), Group(typeof(_FillAndStrokeStyles))]
        public ValueTask FillStyleAsync(double x0, double y0, double r0, double x1, double y1, double r1, params (double Offset, string Color)[] color_stops) => InvokeEvalAsync(
            $"let gradient = {ctx}.createRadialGradient({x0.ToInvariantString()}, {y0.ToInvariantString()}, {r0.ToInvariantString()}, {x1.ToInvariantString()}, {y1.ToInvariantString()}, {r1.ToInvariantString()});" +
            string.Join("", color_stops.Select(cs => $"gradient.addColorStop({cs.Offset.ToInvariantString()}, '{cs.Color}');")) + // add color stops
            $"{ctx}.fillStyle = gradient;"); // set gradient
        /// <summary>
        /// Color or style to use inside shapes.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="repetition"></param>
        [Group(typeof(_JS), "fillStyle"), Group(typeof(_FillAndStrokeStyles))]
        public ValueTask FillStyleAsync(string image, Repetition repetition) => InvokeEvalAsync(
            $"let image = {image};" +
            $"let pattern = {ctx}.createPattern(image, '{repetition.ToJsEnumValue()}');" +
            $"{ctx}.fillStyle = pattern;");
        /// <summary>
        /// Color or style to use for the lines around shapes. Default #000 (black).
        /// </summary>
        /// <param name="color">CSS color</param>
        /// <returns></returns>
        [Group(typeof(_JS), "strokeStyle"), Group(typeof(_FillAndStrokeStyles))]
        public ValueTask StrokeStyleAsync(string color) => SetAsync("strokeStyle", color);
        /// <summary>
        /// Color or style to use inside shapes. Default #000 (black).
        /// </summary>
        /// <returns>current value</returns>
        [Group(typeof(_JS), "strokeStyle"), Group(typeof(_FillAndStrokeStyles))]
        public ValueTask<string> StrokeStyleAsync() => GetStringAsync("strokeStyle");
        /// <summary>
        /// Color or style to use for the lines around shapes.
        /// Sets the fill style with a linear gradient.
        /// </summary>
        [Group(typeof(_JS), "strokeStyle"), Group(typeof(_FillAndStrokeStyles))]
        public ValueTask StrokeStyleAsync(double x0, double y0, double x1, double y1, params (double Offset, string Color)[] color_stops) => InvokeEvalAsync(
            $"let gradient = {ctx}.createLinearGradient({x0.ToInvariantString()}, {y0.ToInvariantString()}, {x1.ToInvariantString()}, {y1.ToInvariantString()});" + // create gradient
            string.Join("", color_stops.Select(cs => $"gradient.addColorStop({cs.Offset.ToInvariantString()}, '{cs.Color}');")) + // add color stops
            $"{ctx}.strokeStyle = gradient;"); // set gradient
        /// <summary>
        /// Color or style to use for the lines around shapes.
        /// Sets the fill style with a radial gradient.
        /// </summary>
        [Group(typeof(_JS), "strokeStyle"), Group(typeof(_FillAndStrokeStyles))]
        public ValueTask StrokeStyleAsync(double x0, double y0, double r0, double x1, double y1, double r1, params (double Offset, string Color)[] color_stops) => InvokeEvalAsync(
            $"let gradient = {ctx}.createRadialGradient({x0.ToInvariantString()}, {y0.ToInvariantString()}, {r0.ToInvariantString()}, {x1.ToInvariantString()}, {y1.ToInvariantString()}, {r1.ToInvariantString()});" +
            string.Join("", color_stops.Select(cs => $"gradient.addColorStop({cs.Offset.ToInvariantString()}, '{cs.Color}');")) + // add color stops
            $"{ctx}.strokeStyle = gradient;"); // set gradient
        /// <summary>
        /// Color or style to use inside shapes.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="repetition"></param>
        [Group(typeof(_JS), "strokeStyle"), Group(typeof(_FillAndStrokeStyles))]
        public ValueTask StrokeStyleAsync(string image, Repetition repetition) => InvokeEvalAsync(
            $"let image = {image};" +
            $"let pattern = {ctx}.createPattern(image, {repetition.ToJsEnumValue()});" +
            $"{ctx}.strokeStyle = pattern;");
        // gradients and patterns:
        // no API call here, as the APIs are merged with the FillStyle / StrokeStyle APIs.
    }
    public partial class Batch2D
    {
        /// <summary>
        /// <a href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D#Fill_and_stroke_styles" />
        /// </summary>
        public partial struct _FillAndStrokeStyles : IContext2DWithoutGetters.I_FillAndStrokeStyles { }
        /// <summary>
        /// Color or style to use inside shapes. Default #000 (black).
        /// </summary>
        /// <param name="color">CSS color</param>
        /// <returns></returns>
        [Group(typeof(_JS), "fillStyle"), Group(typeof(_FillAndStrokeStyles))]
        public ValueTask FillStyleAsync(string color) => SetAsync("fillStyle", color);
        /// <summary>
        /// Color or style to use inside shapes.
        /// Sets the fill style with a linear gradient.
        /// </summary>
        [Group(typeof(_JS), "fillStyle"), Group(typeof(_FillAndStrokeStyles))]
        public ValueTask FillStyleAsync(double x0, double y0, double x1, double y1, params (double Offset, string Color)[] color_stops) => GradientAsync(
            "fillStyle",
            Gradient.Linear,
            color_stops.Select(kv => new ColorStop { Offset = kv.Offset, Color = kv.Color }).ToArray(),
            x0, y0, x1, y1);
        /// <summary>
        /// Color or style to use inside shapes.
        /// Sets the fill style with a radial gradient.
        /// </summary>
        [Group(typeof(_JS), "fillStyle"), Group(typeof(_FillAndStrokeStyles))]
        public ValueTask FillStyleAsync(double x0, double y0, double r0, double x1, double y1, double r1, params (double Offset, string Color)[] color_stops) => GradientAsync(
            "fillStyle",
            Gradient.Radial,
            color_stops.Select(kv => new ColorStop { Offset = kv.Offset, Color = kv.Color }).ToArray(),
            x0, y0, r0, x1, y1, r1);
        /// <summary>
        /// Color or style to use inside shapes.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="repetition"></param>
        [Group(typeof(_JS), "fillStyle"), Group(typeof(_FillAndStrokeStyles))]
        public ValueTask FillStyleAsync(string image, Repetition repetition) => PatternAsync("fillStyle", image, repetition.ToJsEnumValue());
        /// <summary>
        /// Color or style to use for the lines around shapes. Default #000 (black).
        /// </summary>
        /// <param name="color">CSS color</param>
        /// <returns></returns>
        [Group(typeof(_JS), "strokeStyle"), Group(typeof(_FillAndStrokeStyles))]
        public ValueTask StrokeStyleAsync(string color) => SetAsync("strokeStyle", color);
        /// <summary>
        /// Color or style to use for the lines around shapes.
        /// Sets the fill style with a linear gradient.
        /// </summary>
        [Group(typeof(_JS), "strokeStyle"), Group(typeof(_FillAndStrokeStyles))]
        public ValueTask StrokeStyleAsync(double x0, double y0, double x1, double y1, params (double Offset, string Color)[] color_stops) => GradientAsync(
            "strokeStyle",
            Gradient.Linear,
            color_stops.Select(kv => new ColorStop { Offset = kv.Offset, Color = kv.Color }).ToArray(),
            x0, y0, x1, y1);
        /// <summary>
        /// Color or style to use for the lines around shapes.
        /// Sets the fill style with a radial gradient.
        /// </summary>
        [Group(typeof(_JS), "strokeStyle"), Group(typeof(_FillAndStrokeStyles))]
        public ValueTask StrokeStyleAsync(double x0, double y0, double r0, double x1, double y1, double r1, params (double Offset, string Color)[] color_stops) => GradientAsync(
            "strokeStyle",
            Gradient.Radial,
            color_stops.Select(kv => new ColorStop { Offset = kv.Offset, Color = kv.Color }).ToArray(),
            x0, y0, r0, x1, y1, r1);
        /// <summary>
        /// Color or style to use inside shapes.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="repetition"></param>
        [Group(typeof(_JS), "strokeStyle"), Group(typeof(_FillAndStrokeStyles))]
        public ValueTask StrokeStyleAsync(string image, Repetition repetition) => PatternAsync("strokeStyle", image, repetition.ToJsEnumValue());
        // gradients and patterns:
        // no API call here, as the APIs are merged with the FillStyle / StrokeStyle APIs.
    }
}
