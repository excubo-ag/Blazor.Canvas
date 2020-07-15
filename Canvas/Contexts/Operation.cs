using System.Text.Json.Serialization;

namespace Excubo.Blazor.Canvas.Contexts
{
    internal enum OperationType
    {
        Set,
        Invocation,
        Complex,
    }
    internal class Operation
    {
        public string T => Type switch { OperationType.Set => "S", OperationType.Invocation => "I", OperationType.Complex => "C" };
        public string I => Identifier;
        public object V => Value;
        public string O1 => Object1;
        public string O2 => Object2;
        [JsonIgnore]
        internal OperationType Type { private get; set; }
        [JsonIgnore]
        internal string Identifier { private get; set; }
        [JsonIgnore]
        internal object Value { private get; set; }
        [JsonIgnore]
        internal string Object1 { private get; set; }
        [JsonIgnore]
        internal string Object2 { private get; set; }
    }
}
