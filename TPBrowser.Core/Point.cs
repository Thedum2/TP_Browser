namespace TPBrowser.Core;

public readonly struct Point
{
    //좌표 1개를 표현하는 가장 기본 타입

    public int X { get; }
    public int Y { get; }

    public Point(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }
}