namespace TPBrowser.Core;

public class StyleProperty
{
    public enum StylePropertyName
    {
        Width,
        Height,
        Display,
        Color,
        BackgroundColor,
        MarginTop,
        MarginRight,
        MarginBottom,
        MarginLeft,
        //TODO :: 추가예정
    }

    public enum StyleValueKind
    {
        Keyword,
        Length,
        Color,
        Number
    }

    public enum LengthUnit
    {
        Px
    }
    

}