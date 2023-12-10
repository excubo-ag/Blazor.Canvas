using Excubo.Blazor.Canvas.Contexts;
using NUnit.Framework;
using NUnit.Framework.Legacy;
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
			Assert.That(input, Is.EquivalentTo(input.Optimize().ToList()));
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
			Assert.That(new List<Operation> { input[2], input[3], input[4], input[6], input[7] }, Is.EquivalentTo(input.Optimize().ToList()));
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
			Assert.That(new List<Operation> { input[2], input[3], input[4], input[6], input[7] }, Is.EquivalentTo(input.Optimize().ToList()));
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
			Assert.That(output, Is.Not.Null);
			Assert.That(output, Is.Not.Empty);
			Assert.That(5, Is.EqualTo(output.Count));
			Assert.That("foo", Is.EqualTo(output[0].Identifier));
			Assert.That(new object[] { "1", "2", "3" }, Is.EquivalentTo(output[0].Value as List<object>));
			Assert.That("bar", Is.EqualTo(output[1].Identifier));
			Assert.That("1", Is.EqualTo(output[1].Value));
			Assert.That("baz", Is.EqualTo(output[2].Identifier));
			Assert.That("2", Is.EqualTo(output[2].Value));
			Assert.That("bar", Is.EqualTo(output[3].Identifier));
			Assert.That(new object[] { "2", "3" }, Is.EquivalentTo(output[3].Value as List<object>));
			Assert.That("fuu", Is.EqualTo(output[4].Identifier));
			Assert.That("4", Is.EqualTo(output[4].Value));
		}
	}
}