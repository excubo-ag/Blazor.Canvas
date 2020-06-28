using System;

namespace Excubo.Blazor.Canvas.Extensions
{
    internal static class EnumExtension
    {
        public static string ToJsEnumValue<TEnum>(this TEnum value) where TEnum : Enum => Enum.GetName(typeof(TEnum), value).ToLowerInvariant().Replace('_', '-');
    }
}
