namespace TPBrowser.Core;

public sealed class Viewport
{
    public Size Size { get; private set; }
    public Point ScrollOffset { get; private set; }

    public int Width => Size.Width;
    public int Height => Size.Height;

    public Rect VisibleRectInDocument => new(ScrollOffset.X, ScrollOffset.Y, Width, Height);

    public Viewport(Size size)
    {
        Size = size;
        ScrollOffset = new Point(0, 0);
    }

    public void Resize(Size newSize)
    {
        Size = newSize;
    }

    public void SetScroll(int x, int y)
    {
        ScrollOffset = new Point(Math.Max(0, x), Math.Max(0, y));
    }
}