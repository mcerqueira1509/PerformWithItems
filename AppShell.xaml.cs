namespace PerformWithItems;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(Page1), new AppShellRouteFactory<Page1>());
        Routing.RegisterRoute(nameof(Page2), new AppShellRouteFactory<Page2>());
        Routing.RegisterRoute(nameof(Page3), new AppShellRouteFactory<Page3>());

        Routing.RegisterRoute("TransientPage1", typeof(Page1));
        Routing.RegisterRoute("TransientPage2", typeof(Page2));

    }
}
