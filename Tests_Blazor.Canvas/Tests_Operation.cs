using Excubo.Blazor.Canvas.Contexts;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Tests_Blazor.Canvas
{
    public class Tests_Operation
    {
        [Test]
        public void NoOptimizationPossible()
        {
            var input = new List<Operation>()
            {
                new Operation { Type = OperationType.Set, Identifier = "foo" },
                new Operation { Type = OperationType.Set, Identifier = "foo2" }, // no optimization because different identifier
                new Operation { Type = OperationType.Complex, Identifier = "foo2" },  // no optimization because different type
                new Operation { Type = OperationType.Set, Identifier = "foo" },  // no optimization because different type and identifier
            };
            CollectionAssert.AreEqual(input, input.Optimize().ToList());
        }
        [Test]
        public void SetIgnore()
        {
            var input = new List<Operation>()
            {
                new Operation { Type = OperationType.Set, Identifier = "foo", Value = "1" }, // 0
                new Operation { Type = OperationType.Set, Identifier = "foo", Value = "2" }, // 1
                new Operation { Type = OperationType.Set, Identifier = "foo", Value = "3" }, // 2, this is expected
                new Operation { Type = OperationType.Set, Identifier = "bar", Value = "1" }, // 3, this is expected
                new Operation { Type = OperationType.Set, Identifier = "baz", Value = "2" }, // 4, this is expected
                new Operation { Type = OperationType.Set, Identifier = "bar", Value = "2" }, // 5
                new Operation { Type = OperationType.Set, Identifier = "bar", Value = "3" }, // 6, this is expected
                new Operation { Type = OperationType.Set, Identifier = "fuu", Value = "4" }, // 7, this is expected
            };
            CollectionAssert.AreEqual(new List<Operation> { input[2], input[3], input[4], input[6], input[7] }, input.Optimize().ToList());
        }
        [Test]
        public void GradientIgnore()
        {
            var input = new List<Operation>()
            {
                new Operation { Type = OperationType.GradientOrPattern, Identifier = "foo", Value = "1", Object1 = "1", Object2 = "1" }, // 0
                new Operation { Type = OperationType.GradientOrPattern, Identifier = "foo", Value = "2", Object1 = "1", Object2 = "1" }, // 1
                new Operation { Type = OperationType.GradientOrPattern, Identifier = "foo", Value = "3", Object1 = "1", Object2 = "1" }, // 2, this is expected
                new Operation { Type = OperationType.GradientOrPattern, Identifier = "bar", Value = "1", Object1 = "1", Object2 = "1" }, // 3, this is expected
                new Operation { Type = OperationType.GradientOrPattern, Identifier = "baz", Value = "2", Object1 = "1", Object2 = "1" }, // 4, this is expected
                new Operation { Type = OperationType.GradientOrPattern, Identifier = "bar", Value = "2", Object1 = "1", Object2 = "1" }, // 5
                new Operation { Type = OperationType.GradientOrPattern, Identifier = "bar", Value = "3", Object1 = "1", Object2 = "1" }, // 6, this is expected
                new Operation { Type = OperationType.GradientOrPattern, Identifier = "fuu", Value = "4", Object1 = "1", Object2 = "1" }, // 7, this is expected
            };
            CollectionAssert.AreEqual(new List<Operation> { input[2], input[3], input[4], input[6], input[7] }, input.Optimize().ToList());
        }
        [Test]
        public void BulkInvocation()
        {
            var input = new List<Operation>()
            {
                new Operation { Type = OperationType.Invocation, Identifier = "foo", Value = "1" },
                new Operation { Type = OperationType.Invocation, Identifier = "foo", Value = "2" },
                new Operation { Type = OperationType.Invocation, Identifier = "foo", Value = "3" },

                new Operation { Type = OperationType.Invocation, Identifier = "bar", Value = "1" },

                new Operation { Type = OperationType.Invocation, Identifier = "baz", Value = "2" },

                new Operation { Type = OperationType.Invocation, Identifier = "bar", Value = "2" },
                new Operation { Type = OperationType.Invocation, Identifier = "bar", Value = "3" },

                new Operation { Type = OperationType.Invocation, Identifier = "fuu", Value = "4" },
            };
            List<Operation> output = null;
            Assert.DoesNotThrow(() => output = input.Optimize().ToList());
            Assert.IsNotNull(output);
            CollectionAssert.IsNotEmpty(output);
            Assert.AreEqual(5, output.Count);
            CollectionAssert.AreEqual("foo", output[0].Identifier);
            CollectionAssert.AreEqual(new object[] { "1", "2", "3" }, output[0].Value as List<object>);
            CollectionAssert.AreEqual("bar", output[1].Identifier);
            Assert.AreEqual("1", output[1].Value);
            CollectionAssert.AreEqual("baz", output[2].Identifier);
            Assert.AreEqual("2", output[2].Value);
            CollectionAssert.AreEqual("bar", output[3].Identifier);
            CollectionAssert.AreEqual(new object[] { "2", "3" }, output[3].Value as List<object>);
            CollectionAssert.AreEqual("fuu", output[4].Identifier);
            Assert.AreEqual("4", output[4].Value);
        }
    }
}