using Excubo.Generators.Grouping;
using System.Threading.Tasks;

namespace Excubo.Blazor.Canvas.Contexts
{
    public partial class Context2D
    {
        /// <summary>
        /// <a href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D#The_canvas_state"/>
        /// </summary>
        public partial struct _CanvasState { }
        /// <summary>
        /// Saves the current drawing style state using a stack so you can revert any change you make to it using restore().
        /// </summary>
        /// <returns></returns>
        [Group(typeof(_JS), "save"), Group(typeof(_CanvasState))]
        public ValueTask SaveAsync() => InvokeOnCtxAsync("save");
        /// <summary>
        /// Restores the drawing style state to the last element on the 'state stack' saved by save().
        /// </summary>
        /// <returns></returns>
        [Group(typeof(_JS), "restore"), Group(typeof(_CanvasState))]
        public ValueTask RestoreAsync() => InvokeOnCtxAsync("restore");
    }
    public partial class Batch2D
    {
        /// <summary>
        /// State management. <a href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D#The_canvas_state"/>
        /// </summary>
        public partial struct _CanvasState { }
        /// <summary>
        /// Saves the current drawing style state using a stack so you can revert any change you make to it using restore().
        /// </summary>
        /// <returns></returns>
        [Group(typeof(_JS), "save"), Group(typeof(_CanvasState))]
        public ValueTask SaveAsync() => InvokeOnCtxAsync("save");
        /// <summary>
        /// Restores the drawing style state to the last element on the 'state stack' saved by save().
        /// </summary>
        /// <returns></returns>
        [Group(typeof(_JS), "restore"), Group(typeof(_CanvasState))]
        public ValueTask RestoreAsync() => InvokeOnCtxAsync("restore");
    }
}
