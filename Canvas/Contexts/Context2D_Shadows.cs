using Excubo.Generators.Grouping;
using System.Threading.Tasks;

namespace Excubo.Blazor.Canvas.Contexts
{
    public partial class Context2D
    {
        /// <summary>
        /// <a href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D#Shadows" />
        /// </summary>
        public partial struct _Shadows { }
        /// <summary>
        /// Specifies the blurring effect. Default: 0
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "shadowBlur"), Group(typeof(_Shadows), "BlurAsync")]
        public ValueTask ShadowBlurAsync(double level) => SetAsync("shadowBlur", level);
        /// <summary>
        /// Specifies the blurring effect. Default: 0
        /// </summary>
        /// <returns>current value</returns>
        [Group(typeof(_JS), "shadowBlur"), Group(typeof(_Shadows), "BlurAsync")]
        public ValueTask<double> ShadowBlurAsync() => GetDoubleAsync("shadowBlur");
        /// <summary>
        /// Color of the shadow. Default: fully-transparent black.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "shadowColor"), Group(typeof(_Shadows), "ColorAsync")]
        public ValueTask ShadowColorAsync(string color) => SetAsync("shadowColor", color);
        /// <summary>
        /// Color of the shadow. Default: fully-transparent black.
        /// </summary>
        /// <returns>current value</returns>
        [Group(typeof(_JS), "shadowColor"), Group(typeof(_Shadows), "ColorAsync")]
        public ValueTask<string> ShadowColorAsync() => GetStringAsync("shadowColor");
        /// <summary>
        /// Horizontal distance the shadow will be offset. Default: 0.
        /// </summary>
        /// <param name="offset"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "shadowOffsetX"), Group(typeof(_Shadows), "OffsetXAsync")]
        public ValueTask ShadowOffsetXAsync(double offset) => SetAsync("shadowOffsetX", offset);
        /// <summary>
        /// Horizontal distance the shadow will be offset. Default: 0.
        /// </summary>
        /// <returns>current value</returns>
        [Group(typeof(_JS), "shadowOffsetX"), Group(typeof(_Shadows), "OffsetXAsync")]
        public ValueTask<double> ShadowOffsetXAsync() => GetDoubleAsync("shadowOffsetX");
        /// <summary>
        /// Vertical distance the shadow will be offset. Default: 0.
        /// </summary>
        /// <param name="offset"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "shadowOffsetY"), Group(typeof(_Shadows), "OffsetYAsync")]
        public ValueTask ShadowOffsetYAsync(double offset) => SetAsync("shadowOffsetY", offset);
        /// <summary>
        /// Vertical distance the shadow will be offset. Default: 0.
        /// </summary>
        /// <returns>current value</returns>
        [Group(typeof(_JS), "shadowOffsetY"), Group(typeof(_Shadows), "OffsetYAsync")]
        public ValueTask<double> ShadowOffsetYAsync() => GetDoubleAsync("shadowOffsetY");
    }
    public partial class Batch2D
    {
        /// <summary>
        /// <a href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D#Shadows" />
        /// </summary>
        public partial struct _Shadows { }
        /// <summary>
        /// Specifies the blurring effect. Default: 0
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "shadowBlur"), Group(typeof(_Shadows), "BlurAsync")]
        public ValueTask ShadowBlurAsync(double level) => SetAsync("shadowBlur", level);
        /// <summary>
        /// Color of the shadow. Default: fully-transparent black.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "shadowColor"), Group(typeof(_Shadows), "ColorAsync")]
        public ValueTask ShadowColorAsync(string color) => SetAsync("shadowColor", color);
        /// <summary>
        /// Horizontal distance the shadow will be offset. Default: 0.
        /// </summary>
        /// <param name="offset"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "shadowOffsetX"), Group(typeof(_Shadows), "OffsetXAsync")]
        public ValueTask ShadowOffsetXAsync(double offset) => SetAsync("shadowOffsetX", offset);
        /// <summary>
        /// Vertical distance the shadow will be offset. Default: 0.
        /// </summary>
        /// <param name="offset"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "shadowOffsetY"), Group(typeof(_Shadows), "OffsetYAsync")]
        public ValueTask ShadowOffsetYAsync(double offset) => SetAsync("shadowOffsetY", offset);
    }
}
