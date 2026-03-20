namespace TPBrowser.Core;

public readonly struct Size
{
    // 객체의 크기 표현용
    
    public int Width { get; }

    public int Height { get; }

    public Size(int width, int height)
    {
        Width = width < 0 ? 0 : width;
        Height = height < 0 ? 0 : height;
    }
}