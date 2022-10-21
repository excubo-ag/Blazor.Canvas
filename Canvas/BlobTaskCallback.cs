using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace Excubo.Blazor.Canvas
{
    internal class BlobTaskCallback : IDisposable
    {
        private Func<Blob, Task> callback { get; set; }

        public BlobTaskCallback(Func<Blob, Task> callback)
        {
            this.callback = callback;
            objRef = DotNetObjectReference.Create(this);
        }

        public DotNetObjectReference<BlobTaskCallback> objRef { get; init; }

        public void Dispose()
        {
            objRef.Dispose();
        }

        [JSInvokable("Callback")]
        public void InvokeCallback(IJSObjectReference jSBlob)
        {
            var blob = new Blob(jSBlob);
            callback.Invoke(blob);
            Dispose();
        }
    }
}
