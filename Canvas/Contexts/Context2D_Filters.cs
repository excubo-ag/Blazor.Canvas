using System.Threading.Tasks;

namespace Excubo.Blazor.Canvas.Contexts
{
    public partial class Context2D
    {
        /// <summary>
        /// Applies a CSS or SVG filter to the canvas, e.g., to change its brightness or bluriness.
        /// </summary>
        /// <param name="filter_functions">A set of filter functions</param>
        /// <returns></returns>
        public ValueTask FilterAsync(params string[] filter_functions) => SetAsync("filter", string.Join(" ", filter_functions));
        /// <summary>
        /// Applies a CSS or SVG filter to the canvas, e.g., to change its brightness or bluriness.
        /// </summary>
        /// <param name="filter">A single filter function</param>
        /// <returns></returns>
        public ValueTask FilterAsync(string filter) => SetAsync("filter", filter);
        /// <summary>
        /// Applies a CSS or SVG filter to the canvas, e.g., to change its brightness or bluriness.
        /// </summary>
        /// <param name="none">Reset filters to "none"</param>
        /// <returns></returns>
        public ValueTask FilterAsync(Filter none) => SetAsync("filter", "none");
        /// <summary>
        /// Applies a CSS or SVG filter to the canvas, e.g., to change its brightness or bluriness.
        /// </summary>
        /// <returns>current value</returns>
        public ValueTask<string> FilterAsync() => GetStringAsync("filter");
    }
    public partial class Batch2D
    {
        /// <summary>
        /// Applies a CSS or SVG filter to the canvas, e.g., to change its brightness or bluriness.
        /// </summary>
        /// <param name="filter_functions">A set of filter functions</param>
        /// <returns></returns>
        public ValueTask FilterAsync(params string[] filter_functions) => SetAsync("filter", string.Join(" ", filter_functions));
        /// <summary>
        /// Applies a CSS or SVG filter to the canvas, e.g., to change its brightness or bluriness.
        /// </summary>
        /// <param name="filter">A single filter function</param>
        /// <returns></returns>
        public ValueTask FilterAsync(string filter) => SetAsync("filter", filter);
        /// <summary>
        /// Applies a CSS or SVG filter to the canvas, e.g., to change its brightness or bluriness.
        /// </summary>
        /// <param name="none">Reset filters to "none"</param>
        /// <returns></returns>
        public ValueTask FilterAsync(Filter none) => SetAsync("filter", "none");
    }
}
