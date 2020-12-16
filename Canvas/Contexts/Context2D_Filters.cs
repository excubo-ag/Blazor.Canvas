using Excubo.Generators.Grouping;
using System.Threading.Tasks;

namespace Excubo.Blazor.Canvas.Contexts
{
    public partial class Context2D
    {
        /// <summary>
        /// <a href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D#Filters" />
        /// </summary>
        public partial struct _Filters : IContext2DWithoutGetters.I_Filters { }
        /// <summary>
        /// Applies a CSS or SVG filter to the canvas, e.g., to change its brightness or bluriness.
        /// </summary>
        /// <param name="filter_functions">A set of filter functions</param>
        /// <returns></returns>
        [Group(typeof(_JS), "filter"), Group(typeof(_Filters))]
        public ValueTask FilterAsync(params string[] filter_functions) => SetAsync("filter", string.Join(" ", filter_functions));
        /// <summary>
        /// Applies a CSS or SVG filter to the canvas, e.g., to change its brightness or bluriness.
        /// </summary>
        /// <param name="filter">A single filter function</param>
        /// <returns></returns>
        [Group(typeof(_JS), "filter"), Group(typeof(_Filters))]
        public ValueTask FilterAsync(string filter) => SetAsync("filter", filter);
        /// <summary>
        /// Applies a CSS or SVG filter to the canvas, e.g., to change its brightness or bluriness.
        /// </summary>
        /// <param name="none">Reset filters to "none"</param>
        /// <returns></returns>
        [Group(typeof(_JS), "filter"), Group(typeof(_Filters))]
        public ValueTask FilterAsync(Filter none) => SetAsync("filter", "none");
        /// <summary>
        /// Applies a CSS or SVG filter to the canvas, e.g., to change its brightness or bluriness.
        /// </summary>
        /// <returns>current value</returns>
        [Group(typeof(_JS), "filter"), Group(typeof(_Filters))]
        public ValueTask<string> FilterAsync() => GetStringAsync("filter");
    }
    public partial class Batch2D
    {
        /// <summary>
        /// <a href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D#Filters" />
        /// </summary>
        public partial struct _Filters : IContext2DWithoutGetters.I_Filters { }
        /// <summary>
        /// Applies a CSS or SVG filter to the canvas, e.g., to change its brightness or bluriness.
        /// </summary>
        /// <param name="filter_functions">A set of filter functions</param>
        /// <returns></returns>
        [Group(typeof(_JS), "filter"), Group(typeof(_Filters))]
        public ValueTask FilterAsync(params string[] filter_functions) => SetAsync("filter", string.Join(" ", filter_functions));
        /// <summary>
        /// Applies a CSS or SVG filter to the canvas, e.g., to change its brightness or bluriness.
        /// </summary>
        /// <param name="filter">A single filter function</param>
        /// <returns></returns>
        [Group(typeof(_JS), "filter"), Group(typeof(_Filters))]
        public ValueTask FilterAsync(string filter) => SetAsync("filter", filter);
        /// <summary>
        /// Applies a CSS or SVG filter to the canvas, e.g., to change its brightness or bluriness.
        /// </summary>
        /// <param name="none">Reset filters to "none"</param>
        /// <returns></returns>
        [Group(typeof(_JS), "filter"), Group(typeof(_Filters))]
        public ValueTask FilterAsync(Filter none) => SetAsync("filter", "none");
    }
}