using Microsoft.JSInterop;
using System;

namespace Excubo.Blazor.Canvas
{
    internal class BlobCallback : IDisposable
    {
        private Action<Blob> callback { get; set; }

        public BlobCallback(Action<Blob> callback)
        {
            this.callback = callback;
            objRef = DotNetObjectReference.Create(this);
        }

        public DotNetObjectReference<BlobCallback> objRef { get; init; }

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
