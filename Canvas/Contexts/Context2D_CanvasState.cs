using System.Threading.Tasks;

namespace Excubo.Blazor.Canvas.Contexts
{
    public partial class Context2D
    {
        /// <summary>
        /// Saves the current drawing style state using a stack so you can revert any change you make to it using restore().
        /// </summary>
        /// <returns></returns>
        public ValueTask SaveAsync() => InvokeOnCtxAsync("save");
        /// <summary>
        /// Restores the drawing style state to the last element on the 'state stack' saved by save().
        /// </summary>
        /// <returns></returns>
        public ValueTask RestoreAsync() => InvokeOnCtxAsync("restore");
    }
    public partial class Batch2D
    {
        /// <summary>
        /// Saves the current drawing style state using a stack so you can revert any change you make to it using restore().
        /// </summary>
        /// <returns></returns>
        public ValueTask SaveAsync() => InvokeOnCtxAsync("save");
        /// <summary>
        /// Restores the drawing style state to the last element on the 'state stack' saved by save().
        /// </summary>
        /// <returns></returns>
        public ValueTask RestoreAsync() => InvokeOnCtxAsync("restore");
    }
}
