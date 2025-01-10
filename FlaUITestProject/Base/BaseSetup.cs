using FlaUI.Core.Input;
using FlaUIPoC.Reapit.Window.MainLoginWindow;
using FlaUIPoC.Base;
using FlaUIPoC.Reapit.Window.MainLoginWindow;
using static AutomationHelper;

public class BaseSetup
{
    public ApplicationLaunchSetUp App { get; private set; }

    public MainLoginWindow MainWindow { get; private set; }

    [SetUp]
    public void Setup()
    {
        App = new ApplicationLaunchSetUp();
        App.Init();

        // Create main login window
        MainWindow = new MainLoginWindow(App);
        Wait.UntilResponsive(MainWindow.Window);
        MaximiseWindow();
    }

    [TearDown]
    public void TearDown()
    {
        // App?.Cleanup();
    }

    private void MaximiseWindow()
    {
        AutomationHelper.ClickButton(MainWindow.Window, IdentifyElement.byId, "btnMaximise");
    }
}
