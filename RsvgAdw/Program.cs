using RsvgAdw;

internal class Program
{
    internal const string ApplicationId = "gir.core.tiger";
    private static void Main(string[] _)
    {
        Adw.Module.Initialize();
        Rsvg.Module.Initialize();

        var application = Adw.Application.New(ApplicationId, Gio.ApplicationFlags.FlagsNone);
        application.OnActivate += (sender, args) =>
        {
            var window = Adw.ApplicationWindow.New((Adw.Application)sender);

            var viewSwitcher = Adw.ViewSwitcher.New();

            viewSwitcher.Stack = Adw.ViewStack.New();
            viewSwitcher.Stack.Vexpand = true;
            viewSwitcher.Stack.Hexpand = true;
            viewSwitcher.Policy = Adw.ViewSwitcherPolicy.Wide;

            var headerBar = Adw.HeaderBar.New();
            headerBar.SetTitleWidget(viewSwitcher);

            var toolbarView = Adw.ToolbarView.New();
            toolbarView.AddTopBar(headerBar);
            toolbarView.Content = viewSwitcher.Stack;

            viewSwitcher.Stack.AddTitled(
                Tiger.Tab(),
                Guid.NewGuid().ToString(),
                "Ghostscript Tiger"
            );

            window.Content = toolbarView;

            window.SetDefaultSize(500, 500);
            window.Present();
        };
        application.RunWithSynchronizationContext(null);
    }
}

