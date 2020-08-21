using System;
using System.Text.Json.Serialization;

namespace Excubo.Blazor.Canvas.Contexts
{
    internal enum OperationType
    {
        Set,
        Invocation,
        Complex,
        GradientOrPattern,
    }
    internal class Operation
    {
        public string T => Type switch 
        {
            OperationType.Set => "S",
            OperationType.Invocation => "I",
            OperationType.Complex => "C",
            OperationType.GradientOrPattern => "G", 
            _ => throw new ArgumentException("Impossible situation. The OperationType cannot exist!") 
        };
        public string I => Identifier;
        public object V => Value;
        public string O1 => Object1;
        public object O2 => Object2;
        [JsonIgnore]
        internal OperationType Type { private get; set; }
        [JsonIgnore]
        internal string Identifier { private get; set; }
        [JsonIgnore]
        internal object Value { private get; set; }
        [JsonIgnore]
        internal string Object1 { private get; set; }
        [JsonIgnore]
        internal object Object2 { private get; set; }
    }
}
