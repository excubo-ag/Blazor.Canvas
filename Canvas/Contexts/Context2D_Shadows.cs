using System.Threading.Tasks;

namespace Excubo.Blazor.Canvas.Contexts
{
    public partial class Context2D
    {
        /// <summary>
        /// Specifies the blurring effect. Default: 0
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        public ValueTask ShadowBlurAsync(double level) => SetAsync("shadowBlur", level);
        /// <summary>
        /// Specifies the blurring effect. Default: 0
        /// </summary>
        /// <returns>current value</returns>
        public ValueTask<double> ShadowBlurAsync() => GetDoubleAsync("shadowBlur");
        /// <summary>
        /// Color of the shadow. Default: fully-transparent black.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public ValueTask ShadowColorAsync(string color) => SetAsync("shadowColor", color);
        /// <summary>
        /// Color of the shadow. Default: fully-transparent black.
        /// </summary>
        /// <returns>current value</returns>
        public ValueTask<string> ShadowColorAsync() => GetStringAsync("shadowColor");
        /// <summary>
        /// Horizontal distance the shadow will be offset. Default: 0.
        /// </summary>
        /// <param name="offset"></param>
        /// <returns></returns>
        public ValueTask ShadowOffsetXAsync(double offset) => SetAsync("shadowOffsetX", offset);
        /// <summary>
        /// Horizontal distance the shadow will be offset. Default: 0.
        /// </summary>
        /// <returns>current value</returns>
        public ValueTask<double> ShadowOffsetXAsync() => GetDoubleAsync("shadowOffsetX");
        /// <summary>
        /// Vertical distance the shadow will be offset. Default: 0.
        /// </summary>
        /// <param name="offset"></param>
        /// <returns></returns>
        public ValueTask ShadowOffsetYAsync(double offset) => SetAsync("shadowOffsetY", offset);
        /// <summary>
        /// Vertical distance the shadow will be offset. Default: 0.
        /// </summary>
        /// <returns>current value</returns>
        public ValueTask<double> ShadowOffsetYAsync() => GetDoubleAsync("shadowOffsetY");
    }
}
