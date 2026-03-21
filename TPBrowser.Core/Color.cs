namespace TPBrowser.Core;

public readonly struct Color
{
    public byte R { get; }
    public byte G { get; }
    public byte B { get; }
    public byte A { get; }

    public Color(byte r, byte g, byte b, byte a = 255)
    {
        R = r;
        G = g;
        B = b;
        A = a;
    }

    public Color(string hex)
    {
        if (hex == null)
            throw new ArgumentNullException(nameof(hex));

        if (string.IsNullOrEmpty(hex))
            throw new ArgumentException("Hex string cannot be empty.", nameof(hex));

        hex = hex.TrimStart('#');

        if (hex.Length != 6 && hex.Length != 8)
            throw new ArgumentException("Hex string must be 6 or 8 characters long (excluding '#').", nameof(hex));

        // Validate all characters are valid hex digits
        foreach (char c in hex)
        {
            if (!((c >= '0' && c <= '9') || (c >= 'A' && c <= 'F') || (c >= 'a' && c <= 'f')))
            {
                throw new ArgumentException($"Invalid hex character '{c}' in hex string.", nameof(hex));
            }
        }

        // Parse with safe error handling
        if (!byte.TryParse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber, null, out byte r))
            throw new ArgumentException("Failed to parse red component.", nameof(hex));
        if (!byte.TryParse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber, null, out byte g))
            throw new ArgumentException("Failed to parse green component.", nameof(hex));
        if (!byte.TryParse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber, null, out byte b))
            throw new ArgumentException("Failed to parse blue component.", nameof(hex));

        byte a = 255;
        if (hex.Length == 8)
        {
            if (!byte.TryParse(hex.Substring(6, 2), System.Globalization.NumberStyles.HexNumber, null, out a))
                throw new ArgumentException("Failed to parse alpha component.", nameof(hex));
        }

        R = r;
        G = g;
        B = b;
        A = a;
    }

    public override string ToString()
    {
        if (A != 255)
        {
            return $"#{R:X2}{G:X2}{B:X2}{A:X2}";
        }
        return $"#{R:X2}{G:X2}{B:X2}";
    }

    public static readonly Color Transparent = new(0, 0, 0, 0);
    public static readonly Color Black = new(0, 0, 0, 255);
    public static readonly Color White = new(255, 255, 255, 255);
}