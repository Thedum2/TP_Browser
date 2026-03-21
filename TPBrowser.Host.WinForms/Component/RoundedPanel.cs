using System.Drawing.Drawing2D;

namespace TPBrowser.Host.WinForms.Component;

public class RoundedPanel : Panel
{
    public int Radius { get; set; } = 20;

    public RoundedPanel()
    {
        this.DoubleBuffered = true;
        this.ResizeRedraw = true;
    }

    protected override void OnResize(EventArgs eventargs)
    {
        base.OnResize(eventargs);
        UpdateRegion();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        using (GraphicsPath path = GetRoundedRectPath(this.ClientRectangle, Radius))
        using (Pen pen = new Pen(Color.Black, 0))
        {
            e.Graphics.DrawPath(pen, path);
        }
    }

    private void UpdateRegion()
    {
        using (GraphicsPath path = GetRoundedRectPath(this.ClientRectangle, Radius))
        {
            this.Region = new Region(path);
        }
    }

    private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
    {
        GraphicsPath path = new GraphicsPath();
        int d = radius * 2;

        path.AddArc(rect.X, rect.Y, d, d, 180, 90);
        path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
        path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
        path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);

        path.CloseFigure();
        return path;
    }
}