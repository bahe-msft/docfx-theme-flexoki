namespace Flexoki.Sample;

/// <summary>One named color from a documentation color palette.</summary>
/// <param name="Name">A human-readable color name.</param>
/// <param name="Hex">A CSS-compatible hexadecimal color value.</param>
public sealed record Swatch(string Name, string Hex)
{
    /// <summary>The warm background used by the light colorway.</summary>
    public static Swatch Paper { get; } = new("Paper", "#FFFCF0");

    /// <summary>The dark ink used for light-mode text and backgrounds in dark mode.</summary>
    public static Swatch Ink { get; } = new("Ink", "#100F0F");

    /// <summary>Get the color value for use in a CSS rule.</summary>
    /// <returns>A CSS hex color.</returns>
    public override string ToString() => Hex;
}
