using System.Threading.Tasks;

namespace Excubo.Blazor.Canvas.Contexts
{
    public partial class Context2D
    {
        /// <summary>
        /// Font setting. Default value 10px sans-serif.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public ValueTask FontAsync(string value) => SetAsync("font", value);
        /// <summary>
        /// Font setting. Default value 10px sans-serif.
        /// </summary>
        /// <returns>current value</returns>
        public ValueTask<string> FontAsync() => GetStringAsync("font");
        /// <summary>
        /// Text alignment setting. Possible values: start (default), end, left, right, center.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public ValueTask TextAlignAsync(TextAlign value) => SetAsync("textAlign", value);
        /// <summary>
        /// Text alignment setting. Possible values: start (default), end, left, right, center.
        /// </summary>
        /// <returns>current value</returns>
        public ValueTask<TextAlign> TextAlignAsync() => GetAsync<TextAlign>("textAlign");
        /// <summary>
        /// Baseline alignment setting. Possible values: top, hanging, middle, alphabetic (default), ideographic, bottom.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public ValueTask TextBaseLineAsync(TextBaseLine value) => SetAsync("textBaseLine", value);
        /// <summary>
        /// Baseline alignment setting. Possible values: top, hanging, middle, alphabetic (default), ideographic, bottom.
        /// </summary>
        /// <returns>current value</returns>
        public ValueTask<TextBaseLine> TextBaseLineAsync() => GetAsync<TextBaseLine>("textBaseLine");
        /// <summary>
        /// Directionality. Possible values: ltr, rtl, inherit (default).
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public ValueTask DirectionAsync(Direction value) => SetAsync("direction", value);
        /// <summary>
        /// Directionality. Possible values: ltr, rtl, inherit (default).
        /// </summary>
        /// <returns>current value</returns>
        public ValueTask<Direction> DirectionAsync() => GetAsync<Direction>("direction");
    }
}
