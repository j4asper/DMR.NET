using System.Globalization;

namespace DMR.NET.Mappers;

internal static class ParsingExtensions
{
    internal static int? ParseNullableInt(this string? value)
        => int.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var result) ? result : null;

    internal static double? ParseNullableDouble(this string? value)
        => double.TryParse(value, NumberStyles.Float, CultureInfo.InvariantCulture, out var result) ? result : null;

    internal static int[]? ParseNullableIntArray(this string? value, char separator = ',')
    {
        if (string.IsNullOrWhiteSpace(value))
            return null;

        var parts = value.Split(separator, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        var result = new List<int>(parts.Length);

        foreach (var part in parts)
        {
            if (int.TryParse(part, NumberStyles.Integer, CultureInfo.InvariantCulture, out var number))
                result.Add(number);
        }

        return result.Count > 0 ? result.ToArray() : null;
    }
}
