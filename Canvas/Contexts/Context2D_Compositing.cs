using Excubo.Generators.Grouping;
using System.Threading.Tasks;

namespace Excubo.Blazor.Canvas.Contexts
{
    public partial class Context2D
    {
        /// <summary>
        /// <a href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D#Compositing" />
        /// </summary>
        public partial struct _Compositing { }
        /// <summary>
        /// Alpha value that is applied to shapes and images before they are composited onto the canvas. Default 1.0 (opaque).
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "globalAlpha"), Group(typeof(_Compositing))] 
        public ValueTask GlobalAlphaAsync(double value) => SetAsync("globalAlpha", value);
        /// <summary>
        /// Alpha value that is applied to shapes and images before they are composited onto the canvas. Default 1.0 (opaque).
        /// </summary>
        /// <returns>current value</returns>
        [Group(typeof(_JS), "globalAlpha"), Group(typeof(_Compositing))]
        public ValueTask<double> GlobalAlphaAsync() => GetDoubleAsync("globalAlpha");
        /// <summary>
        /// With globalAlpha applied this sets how shapes and images are drawn onto the existing bitmap.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "globalCompositeOperation"), Group(typeof(_Compositing))]
        public ValueTask GlobalCompositeOperationAsync(CompositeOperation type) => SetAsync("globalCompositeOperation", type);
        /// <summary>
        /// With globalAlpha applied this sets how shapes and images are drawn onto the existing bitmap.
        /// </summary>
        /// <returns>current value</returns>
        [Group(typeof(_JS), "globalCompositeOperation"), Group(typeof(_Compositing))]
        public ValueTask<CompositeOperation> GlobalCompositeOperationAsync() => GetAsync<CompositeOperation>("globalCompositeOperation");
    }
    public partial class Batch2D
    {
        /// <summary>
        /// <a href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D#Compositing" />
        /// </summary>
        public partial struct _Compositing { }
        /// <summary>
        /// Alpha value that is applied to shapes and images before they are composited onto the canvas. Default 1.0 (opaque).
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "globalAlpha"), Group(typeof(_Compositing))]
        public ValueTask GlobalAlphaAsync(double value) => SetAsync("globalAlpha", value);
        /// <summary>
        /// With globalAlpha applied this sets how shapes and images are drawn onto the existing bitmap.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        [Group(typeof(_JS), "globalCompositeOperation"), Group(typeof(_Compositing))]
        public ValueTask GlobalCompositeOperationAsync(CompositeOperation type) => SetAsync("globalCompositeOperation", type);
    }
}
