using System.Globalization;

namespace Excubo.Blazor.Canvas.Extensions
{
    internal static class DoubleExtension
    {
        public static string ToInvariantString(this double value) => value.ToString(CultureInfo.InvariantCulture);
    }
}
