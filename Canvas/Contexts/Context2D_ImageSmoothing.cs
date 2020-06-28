using System.Threading.Tasks;

namespace Excubo.Blazor.Canvas.Contexts
{
    public partial class Context2D
    {
        /// <summary>
        /// Image smoothing mode; if disabled, images will not be smoothed if scaled.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public ValueTask ImageSmoothingEnabledAsync(bool value) => SetAsync("imageSmoothingEnabled", value);
        /// <summary>
        /// Image smoothing mode; if disabled, images will not be smoothed if scaled.
        /// </summary>
        /// <returns>current value</returns>
        public ValueTask<bool> ImageSmoothingEnabledAsync() => GetBoolAsync("imageSmoothingEnabledAsync");
        /// <summary>
        /// Allows you to set the quality of image smoothing.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public ValueTask ImageSmoothingQualityAsync(ImageSmoothingQuality value) => SetAsync("imageSmoothingQuality", value);
        /// <summary>
        /// Allows you to set the quality of image smoothing.
        /// </summary>
        /// <returns>current value</returns>
        public ValueTask<ImageSmoothingQuality> ImageSmoothingQualityAsync() => GetAsync<ImageSmoothingQuality>("imageSmoothingQuality");
    }
}
