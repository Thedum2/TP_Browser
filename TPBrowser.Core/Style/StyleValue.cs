namespace TPBrowser.Core;

public abstract class StyleValue
{
    public abstract StyleProperty.StyleValueKind Kind { get; }
}

public sealed class KeywordStyleValue : StyleValue
{
    public string Value { get; }

    public override StyleProperty.StyleValueKind Kind => StyleProperty.StyleValueKind.Keyword;

    public KeywordStyleValue(string value)
    {
        Value = value;
    }

    public override string ToString() => Value;
}

public sealed class LengthStyleValue : StyleValue
{
    public float Value { get; }
    public StyleProperty.LengthUnit Unit { get; }

    public override StyleProperty.StyleValueKind Kind => StyleProperty.StyleValueKind.Length;

    public LengthStyleValue(float value, StyleProperty.LengthUnit unit)
    {
        Value = value;
        Unit = unit;
    }

    public override string ToString() => $"{Value}{Unit.ToString().ToLower()}";
}

public sealed class ColorStyleValue : StyleValue
{
    public Color Value { get; }

    public override StyleProperty.StyleValueKind Kind => StyleProperty.StyleValueKind.Color;

    public ColorStyleValue(Color value)
    {
        Value = value;
    }

    public override string ToString() => Value.ToString();
}

public sealed class NumberStyleValue : StyleValue
{
    public float Value { get; }

    public override StyleProperty.StyleValueKind Kind => StyleProperty.StyleValueKind.Number;

    public NumberStyleValue(float value)
    {
        Value = value;
    }

    public override string ToString() => Value.ToString();
}

public sealed class StyleDeclaration
{
    public StyleProperty.StylePropertyName Property { get; }
    public StyleValue Value { get; }

    public StyleDeclaration(StyleProperty.StylePropertyName property, StyleValue value)
    {
        Property = property;
        Value = value;
    }
}