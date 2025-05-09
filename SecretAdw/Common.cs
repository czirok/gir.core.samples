using Secret;

namespace SecretAdw;

internal static class Common
{
    internal static Gtk.Box CreateContent(Gtk.Orientation orientation)
    {
        var box = Gtk.Box.New(orientation, 20);
        box.MarginBottom = 20;
        box.MarginTop = 20;
        box.MarginStart = 20;
        box.MarginEnd = 20;
        return box;
    }

    internal static Gtk.Box CreateInfoPanel(Gtk.Orientation orientation, string name, string collection, Dictionary<string, string> attributes)
    {
        var box = Gtk.Box.New(orientation, 24);
        box.Halign = Gtk.Align.Fill;
        box.Hexpand = true;

        var storageGroup = CreatePreferencesGroup("Storage");
        storageGroup.Add(CreateActionRow("Name", name));
        storageGroup.Add(CreateActionRow("Collection", collection));

        var attributesGroup = CreatePreferencesGroup("Attributes");
        foreach ((var key, var value) in attributes)
        {
            attributesGroup.Add(CreateActionRow(key, value));
        }

        box.Append(storageGroup);
        box.Append(attributesGroup);

        return box;
    }

    internal static Adw.PreferencesGroup CreatePreferencesGroup(string title)
    {
        var group = Adw.PreferencesGroup.New();
        group.Title = title;
        group.Halign = Gtk.Align.Fill;
        group.Hexpand = true;
        return group;
    }

    internal static Adw.ActionRow CreateActionRow(string title, string subtitle)
    {
        var row = Adw.ActionRow.New();
        row.Title = title;
        row.Subtitle = subtitle;
        row.Activatable = false;
        return row;
    }
}


