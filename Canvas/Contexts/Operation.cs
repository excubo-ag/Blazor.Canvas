using System;
using System.Collections.Generic;
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
        public object O1 => Object1;
        public object O2 => Object2;
        // Bulk operation
        public bool B { get; set; }
        [JsonIgnore]
        internal OperationType Type { get; set; }
        [JsonIgnore]
        internal string Identifier { get; set; }
        [JsonIgnore]
        internal object Value { get; set; }
        [JsonIgnore]
        internal object Object1 { get; set; }
        [JsonIgnore]
        internal object Object2 { get; set; }
    }
    internal static class OperationListExtension
    {
        public static IEnumerable<Operation> Optimize(this List<Operation> operations)
        {
            Operation current_operation = null;
            foreach (var operation in operations)
            {
                if (current_operation == null)
                {
                    current_operation = operation;
                }
                else
                {
                    // let's see whether the current operation and next operation are of same type and identifier
                    if (current_operation.Type == operation.Type && current_operation.Identifier == operation.Identifier)
                    {
                        // this is a potentially improvable situation: we make this a bulk operation!
                        if (current_operation.Type == OperationType.Set
                            || current_operation.Type == OperationType.GradientOrPattern)
                        {
                            // this is a bulk op that actually just overrides the last op. We can therefore simply ignore the last op
                            current_operation = operation;
                        }
                        else
                        {
                            // this is a true bulk op
                            if (current_operation.B)
                            {
                                // this is already a bulk op.
                                if (current_operation.Value is List<object> values)
                                {
                                    values.Add(operation.Value);
                                }
                                if (current_operation.Object1 is List<object> object1s)
                                {
                                    object1s.Add(operation.Object1);
                                }
                                if (current_operation.Object2 is List<object> object2s)
                                {
                                    object2s.Add(operation.Object2);
                                }
                            }
                            else
                            {
                                current_operation.B = true;
                                current_operation.Value = new List<object> { current_operation.Value, operation.Value };
                                current_operation.Object1 = new List<object> { current_operation.Object1, operation.Object1 };
                                current_operation.Object2 = new List<object> { current_operation.Object2, operation.Object2 };
                            }
                        }
                    }
                    else
                    {
                        yield return current_operation;
                        current_operation = operation;
                    }
                }
            }
            if (current_operation != null)
            {
                yield return current_operation;
            }
        }
    }
}
