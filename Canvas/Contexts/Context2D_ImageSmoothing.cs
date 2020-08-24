using Excubo.Generators.Grouping;
using System.Threading.Tasks;

namespace Excubo.Blazor.Canvas.Contexts
{
    public partial class Context2D
    {
        /// <summary>
        /// <a href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D#Image_smoothing" />
        /// </summary>
        public partial struct _ImageSmoothing : IContext2DWithoutGetters.I_ImageSmoothing { }
        /// <summary>
        /// Image smoothing mode; if disabled, images will not be smoothed if scaled.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "imageSmoothingEnabled"), Group(typeof(_ImageSmoothing))]
        public ValueTask ImageSmoothingEnabledAsync(bool value) => SetAsync("imageSmoothingEnabled", value);
        /// <summary>
        /// Image smoothing mode; if disabled, images will not be smoothed if scaled.
        /// </summary>
        /// <returns>current value</returns>
        [Group(typeof(_JS), "imageSmoothingEnabled"), Group(typeof(_ImageSmoothing))]
        public ValueTask<bool> ImageSmoothingEnabledAsync() => GetBoolAsync("imageSmoothingEnabled");
        /// <summary>
        /// Allows you to set the quality of image smoothing.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "imageSmoothingQuality"), Group(typeof(_ImageSmoothing))]
        public ValueTask ImageSmoothingQualityAsync(ImageSmoothingQuality value) => SetAsync("imageSmoothingQuality", value);
        /// <summary>
        /// Allows you to set the quality of image smoothing.
        /// </summary>
        /// <returns>current value</returns>
        [Group(typeof(_JS), "imageSmoothingQuality"), Group(typeof(_ImageSmoothing))]
        public ValueTask<ImageSmoothingQuality> ImageSmoothingQualityAsync() => GetAsync<ImageSmoothingQuality>("imageSmoothingQuality");
    }
    public partial class Batch2D
    {
        /// <summary>
        /// <a href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D#Image_smoothing" />
        /// </summary>
        public partial struct _ImageSmoothing : IContext2DWithoutGetters.I_ImageSmoothing { }
        /// <summary>
        /// Image smoothing mode; if disabled, images will not be smoothed if scaled.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "imageSmoothingEnabled"), Group(typeof(_ImageSmoothing))]
        public ValueTask ImageSmoothingEnabledAsync(bool value) => SetAsync("imageSmoothingEnabled", value);
        /// <summary>
        /// Allows you to set the quality of image smoothing.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "imageSmoothingQuality"), Group(typeof(_ImageSmoothing))]
        public ValueTask ImageSmoothingQualityAsync(ImageSmoothingQuality value) => SetAsync("imageSmoothingQuality", value);
    }
}
