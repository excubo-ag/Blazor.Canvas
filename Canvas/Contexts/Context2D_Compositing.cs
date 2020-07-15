using System.Threading.Tasks;

namespace Excubo.Blazor.Canvas.Contexts
{
    public partial class Context2D
    {
        /// <summary>
        /// Alpha value that is applied to shapes and images before they are composited onto the canvas. Default 1.0 (opaque).
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public ValueTask GlobalAlphaAsync(double value) => SetAsync("globalAlpha", value);
        /// <summary>
        /// Alpha value that is applied to shapes and images before they are composited onto the canvas. Default 1.0 (opaque).
        /// </summary>
        /// <returns>current value</returns>
        public ValueTask<double> GlobalAlphaAsync() => GetDoubleAsync("globalAlpha");
        /// <summary>
        /// With globalAlpha applied this sets how shapes and images are drawn onto the existing bitmap.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public ValueTask GlobalCompositeOperationAsync(CompositeOperation type) => SetAsync("globalCompositeOperation", type);
        /// <summary>
        /// With globalAlpha applied this sets how shapes and images are drawn onto the existing bitmap.
        /// </summary>
        /// <returns>current value</returns>
        public ValueTask<CompositeOperation> GlobalCompositeOperationAsync() => GetAsync<CompositeOperation>("globalCompositeOperation");
    }
    public partial class Batch2D
    {
        /// <summary>
        /// Alpha value that is applied to shapes and images before they are composited onto the canvas. Default 1.0 (opaque).
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public ValueTask GlobalAlphaAsync(double value) => SetAsync("globalAlpha", value);
        /// <summary>
        /// With globalAlpha applied this sets how shapes and images are drawn onto the existing bitmap.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public ValueTask GlobalCompositeOperationAsync(CompositeOperation type) => SetAsync("globalCompositeOperation", type);
    }
}
