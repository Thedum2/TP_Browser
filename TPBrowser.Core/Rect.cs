namespace TPBrowser.Core;

public readonly struct Rect
{
    public int X { get; }
    public int Y { get; }
    public int Width { get; }
    public int Height { get; }
    
    public Rect(int x, int y, int width, int height)
    {
        X = x;
        Y = y;
        Width = width < 0 ? 0 : width;
        Height = height < 0 ? 0 : height;
    }
}