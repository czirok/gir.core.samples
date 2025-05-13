using NotifyAdw;

internal class Program
{
    internal const string ApplicationId = "gir.core.notify";
    private static void Main(string[] _)
    {
        Adw.Module.Initialize();
        Gio.Module.Initialize();
        Rsvg.Module.Initialize();
        Notify07.Module.Initialize();
        Notify07.Functions.Init(ApplicationId);

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

            viewSwitcher.Stack.AddTitledWithIcon(
                Notify.Tab(),
                Guid.NewGuid().ToString(),
                "Notify",
                "preferences-desktop-notification-symbolic"
            );

            window.Content = toolbarView;

            window.SetDefaultSize(300, 300);
            window.Present();
        };
        application.Run(0, null);
        Notify07.Functions.Uninit();
    }
}

