using Microsoft.JSInterop;

namespace Excubo.Blazor.Canvas
{
    public class Blob
    {
        internal Blob(IJSObjectReference jSObjectReference)
        {
            this.JSObjectReference = jSObjectReference;
        }
        public IJSObjectReference JSObjectReference { get; init; }
    }
}
