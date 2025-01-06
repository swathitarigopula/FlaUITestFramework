using FlaUI.Core.Input;
using FlaUIPoC.AgencyCloud.Pages.Login;
using FlaUIPoC.AgencyCloud.Window.Contact;
using FlaUIPoC.AgencyCloud.Window.HomeScreen;
using FlaUIPoC.AgencyCloud.Window.Login;
using FlaUIPoC.Base;

namespace FlaUIPoC.AgencyCloud.Window.MainLoginWindow
{
    public class MainLoginWindow: WindowAdaptor
    {

        public LoginScreenWindow LoginScreen
        {
            get { return _LoginScreen ??= new LoginScreenWindow(Window);}
        }

        public InformationWindow InformationDialogue
        {
            get { return _InformationDialogue ??= new InformationWindow(Window); }
        }

        public HomeScreenWindow HomeScreen
        {
            get { return _HomeScreen ??= new HomeScreenWindow(Window); }
        }

        public RecentSearchPanelWindow RecentSearchPanel
        {
            get { return _RecentSearchPanel ??= new RecentSearchPanelWindow(Window); }
        }

        public AddingNewContactDialogueWindow AddingNewContactDialogue
        {
            get { return _AddingNewContactDialogueWindow ??= new AddingNewContactDialogueWindow(Window); }
        }

        public AddingNewContactScreenWindow AddingNewContactScreen
        {
            get { return _AddingNewContactScreen ??= new AddingNewContactScreenWindow(Window); }
        }

        LoginScreenWindow _LoginScreen;
        ApplicationLaunchSetUp _Application;
        InformationWindow _InformationDialogue;
        HomeScreenWindow _HomeScreen;
        RecentSearchPanelWindow _RecentSearchPanel;
        AddingNewContactDialogueWindow _AddingNewContactDialogueWindow;
        AddingNewContactScreenWindow _AddingNewContactScreen;

        public MainLoginWindow(ApplicationLaunchSetUp app): base(app, "MainWindow")
        {
            Wait.UntilResponsive(Window);
            _Application = app;
            Window.Focus();
            Wait.UntilResponsive(Window);
        }
    }
}
