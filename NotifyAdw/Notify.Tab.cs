namespace NotifyAdw;

internal static class Notify
{
    internal static Gtk.Box Tab()
    {
        var buttonsBox = Gtk.Box.New(Gtk.Orientation.Vertical, 20);
        buttonsBox.Valign = Gtk.Align.Fill;
        buttonsBox.Vexpand = true;

        var tigerButton = Gtk.Button.NewWithLabel("Notify with svg");
        tigerButton.OnClicked += (s, e) =>
        {
            var pixbuf = GdkPixbuf.Pixbuf.NewFromFile("Ghostscript_Tiger.svg");
            if (pixbuf == null)
            {
                var failed = Notify07.Notification.New("SVG Icon", "Failed to load SVG file.", null);
                failed.Show();
                return;
            }

            var notification = Notify07.Notification.New("SVG Icon", "Rendered from Ghostscript_Tiger.svg", null);
            notification.SetIconFromPixbuf(pixbuf);
            notification.SetImageFromPixbuf(pixbuf);
            notification.Show();
        };

        var htmlButton = Gtk.Button.NewWithLabel("Notify with HTML body");
        htmlButton.OnClicked += (s, e) =>
        {
            var notification = Notify07.Notification.New("HTML", "Rendered <i>from</i> <b>HTML</b>", null);
            notification.Show();
        };

        var importatntButton = Gtk.Button.NewWithLabel("Notify with important");
        importatntButton.OnClicked += (s, e) =>
        {
            var notification = Notify07.Notification.New("Important", "This is an <b>important</b> notification", null);
            notification.SetUrgency(Notify07.Urgency.Critical);
            notification.Show();
        };

        buttonsBox.Append(tigerButton);
        buttonsBox.Append(htmlButton);
        buttonsBox.Append(importatntButton);

        return buttonsBox;
    }
}
