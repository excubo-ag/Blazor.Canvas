using Excubo.Blazor.Canvas.Extensions;
using System.Linq;
using System.Threading.Tasks;

namespace Excubo.Blazor.Canvas.Contexts
{
    public partial class Context2D
    {
        /// <summary>
        /// Color or style to use inside shapes. Default #000 (black).
        /// </summary>
        /// <param name="color">CSS color</param>
        /// <returns></returns>
        public ValueTask FillStyleAsync(string color) => SetAsync("fillStyle", color);
        /// <summary>
        /// Color or style to use inside shapes. Default #000 (black).
        /// </summary>
        /// <returns>current value</returns>
        public ValueTask<string> FillStyleAsync() => GetStringAsync("fillStyle");
        /// <summary>
        /// Color or style to use inside shapes.
        /// Sets the fill style with a linear gradient.
        /// </summary>
        public ValueTask FillStyleAsync(double x0, double y0, double x1, double y1, params (double Offset, string Color)[] color_stops) => InvokeEvalAsync(
            $"gradient = {ctx}.createLinearGradient({x0.ToInvariantString()}, {y0.ToInvariantString()}, {x1.ToInvariantString()}, {y1.ToInvariantString()});" + // create gradient
            string.Join("", color_stops.Select(cs => $"gradient.addColorStop({cs.Offset.ToInvariantString()}, '{cs.Color}');")) + // add color stops
            $"{ctx}.fillStyle = gradient;"); // set gradient
        /// <summary>
        /// Color or style to use inside shapes.
        /// Sets the fill style with a radial gradient.
        /// </summary>
        public ValueTask FillStyleAsync(double x0, double y0, double r0, double x1, double y1, double r1, params (double Offset, string Color)[] color_stops) => InvokeEvalAsync(
            $"gradient = {ctx}.createRadialGradient({x0.ToInvariantString()}, {y0.ToInvariantString()}, {r0.ToInvariantString()}, {x1.ToInvariantString()}, {y1.ToInvariantString()}, {r1.ToInvariantString()});" +
            string.Join("", color_stops.Select(cs => $"gradient.addColorStop({cs.Offset.ToInvariantString()}, '{cs.Color}');")) + // add color stops
            $"{ctx}.fillStyle = gradient;"); // set gradient
        /// <summary>
        /// Color or style to use inside shapes.
        /// // TODO pattern
        /// </summary>
        /// <param name="pattern"></param>
        private void FillStyleAsync(object pattern)
        {
            //TODO FillStyleAsync
        }
        /// <summary>
        /// Color or style to use for the lines around shapes. Default #000 (black).
        /// </summary>
        /// <param name="color">CSS color</param>
        /// <returns></returns>
        public ValueTask StrokeStyleAsync(string color) => SetAsync("strokeStyle", color);
        /// <summary>
        /// Color or style to use inside shapes. Default #000 (black).
        /// </summary>
        /// <returns>current value</returns>
        public ValueTask<string> StrokeStyleAsync() => GetStringAsync("strokeStyle");
        /// <summary>
        /// Color or style to use for the lines around shapes.
        /// Sets the fill style with a linear gradient.
        /// </summary>
        public ValueTask StrokeStyleAsync(double x0, double y0, double x1, double y1, params (double Offset, string Color)[] color_stops) => InvokeEvalAsync(
            $"gradient = {ctx}.createLinearGradient({x0.ToInvariantString()}, {y0.ToInvariantString()}, {x1.ToInvariantString()}, {y1.ToInvariantString()});" + // create gradient
            string.Join("", color_stops.Select(cs => $"gradient.addColorStop({cs.Offset.ToInvariantString()}, '{cs.Color}');")) + // add color stops
            $"{ctx}.strokeStyle = gradient;"); // set gradient
        /// <summary>
        /// Color or style to use for the lines around shapes.
        /// Sets the fill style with a radial gradient.
        /// </summary>
        public ValueTask StrokeStyleAsync(double x0, double y0, double r0, double x1, double y1, double r1, params (double Offset, string Color)[] color_stops) => InvokeEvalAsync(
            $"gradient = {ctx}.createRadialGradient({x0.ToInvariantString()}, {y0.ToInvariantString()}, {r0.ToInvariantString()}, {x1.ToInvariantString()}, {y1.ToInvariantString()}, {r1.ToInvariantString()});" +
            string.Join("", color_stops.Select(cs => $"gradient.addColorStop({cs.Offset.ToInvariantString()}, '{cs.Color}');")) + // add color stops
            $"{ctx}.strokeStyle = gradient;"); // set gradient
        /// <summary>
        /// Color or style to use inside shapes.
        /// // TODO pattern
        /// </summary>
        /// <param name="pattern"></param>
        private void StrokeStyleAsync(object pattern)
        {
            //TODO StrokeStyleAsync
        }
        // gradients and patterns:
        // no API call here, as the APIs are merged with the FillStyle / StrokeStyle APIs.
    }
}
