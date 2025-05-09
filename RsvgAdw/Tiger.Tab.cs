namespace RsvgAdw;

internal static class Tiger
{
    internal static Gtk.DrawingArea Tab()
    {
        return new DrawingTiger();
    }
}

internal class DrawingTiger : Gtk.DrawingArea
{
    internal DrawingTiger()
    {
        Rsvg.Handle svg =
            Rsvg.Handle.NewFromData(
                System.Text.Encoding.UTF8.GetBytes(
                    File.ReadAllText("Ghostscript_Tiger.svg")))!;

        SetVexpand(true);
        SetHexpand(true);
        SetDrawFunc((area, ctx, width, height) =>
                {
                    svg.RenderDocument(ctx, new Rsvg.Rectangle
                    {
                        X = 0,
                        Y = 0,
                        Width = width,
                        Height = height
                    });
                });
    }
}
