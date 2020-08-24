using Excubo.Generators.Grouping;
using System.Threading.Tasks;

namespace Excubo.Blazor.Canvas.Contexts
{
    public partial class Context2D
    {
        /// <summary>
        /// <a href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D#Text_styles" />
        /// </summary>
        public partial struct _TextStyles : IContext2DWithoutGetters.I_TextStyles { }
        /// <summary>
        /// Font setting. Default value 10px sans-serif.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "font"), Group(typeof(_TextStyles))]
        public ValueTask FontAsync(string value) => SetAsync("font", value);
        /// <summary>
        /// Font setting. Default value 10px sans-serif.
        /// </summary>
        /// <returns>current value</returns>
        [Group(typeof(_JS), "font"), Group(typeof(_TextStyles))]
        public ValueTask<string> FontAsync() => GetStringAsync("font");
        /// <summary>
        /// Text alignment setting. Possible values: start (default), end, left, right, center.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "textAlign"), Group(typeof(_TextStyles))]
        public ValueTask TextAlignAsync(TextAlign value) => SetAsync("textAlign", value);
        /// <summary>
        /// Text alignment setting. Possible values: start (default), end, left, right, center.
        /// </summary>
        /// <returns>current value</returns>
        [Group(typeof(_JS), "textAlign"), Group(typeof(_TextStyles))]
        public ValueTask<TextAlign> TextAlignAsync() => GetAsync<TextAlign>("textAlign");
        /// <summary>
        /// Baseline alignment setting. Possible values: top, hanging, middle, alphabetic (default), ideographic, bottom.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "textBaseLine"), Group(typeof(_TextStyles))]
        public ValueTask TextBaseLineAsync(TextBaseLine value) => SetAsync("textBaseLine", value);
        /// <summary>
        /// Baseline alignment setting. Possible values: top, hanging, middle, alphabetic (default), ideographic, bottom.
        /// </summary>
        /// <returns>current value</returns>
        [Group(typeof(_JS), "textBaseLine"), Group(typeof(_TextStyles))]
        public ValueTask<TextBaseLine> TextBaseLineAsync() => GetAsync<TextBaseLine>("textBaseLine");
        /// <summary>
        /// Directionality. Possible values: ltr, rtl, inherit (default).
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "direction"), Group(typeof(_TextStyles))]
        public ValueTask DirectionAsync(Direction value) => SetAsync("direction", value);
        /// <summary>
        /// Directionality. Possible values: ltr, rtl, inherit (default).
        /// </summary>
        /// <returns>current value</returns>
        [Group(typeof(_JS), "direction"), Group(typeof(_TextStyles))]
        public ValueTask<Direction> DirectionAsync() => GetAsync<Direction>("direction");
    }
    public partial class Batch2D
    {
        /// <summary>
        /// <a href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D#Text_styles" />
        /// </summary>
        public partial struct _TextStyles : IContext2DWithoutGetters.I_TextStyles { }
        /// <summary>
        /// Font setting. Default value 10px sans-serif.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "font"), Group(typeof(_TextStyles))]
        public ValueTask FontAsync(string value) => SetAsync("font", value);
        /// <summary>
        /// Text alignment setting. Possible values: start (default), end, left, right, center.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "textAlign"), Group(typeof(_TextStyles))]
        public ValueTask TextAlignAsync(TextAlign value) => SetAsync("textAlign", value);
        /// <summary>
        /// Baseline alignment setting. Possible values: top, hanging, middle, alphabetic (default), ideographic, bottom.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "textBaseLine"), Group(typeof(_TextStyles))]
        public ValueTask TextBaseLineAsync(TextBaseLine value) => SetAsync("textBaseLine", value);
        /// <summary>
        /// Directionality. Possible values: ltr, rtl, inherit (default).
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "direction"), Group(typeof(_TextStyles))]
        public ValueTask DirectionAsync(Direction value) => SetAsync("direction", value);
    }
}
