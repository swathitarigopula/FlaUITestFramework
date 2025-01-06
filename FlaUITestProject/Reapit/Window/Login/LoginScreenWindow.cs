using FlaUI.Core.AutomationElements;
using FlaUI.Core.Input;
using FlaUIPoC.AgencyCloud.Window.Login;
using static AutomationHelper;

namespace FlaUIPoC.AgencyCloud.Pages.Login
{
    public class LoginScreenWindow
    {
        private readonly FlaUI.Core.AutomationElements.Window _window;
        private readonly AutomationElement _loginWindow;
        private readonly InformationWindow _informationWindow;

        public LoginScreenWindow(FlaUI.Core.AutomationElements.Window window)
        {
            Wait.UntilResponsive(window);
            _window = window;
            _loginWindow = window.FindFirstDescendant(cf => cf.ByName("Reapit"));
            Assume.That(_loginWindow, Is.Not.Null);
            _informationWindow = new InformationWindow(window);
        }

        public void EnterLoginCredentials(string userName, string password)
        {
            AutomationHelper.EnterText(_window, IdentifyElement.byId, "txtLogin", userName);
            AutomationHelper.EnterText(_window, IdentifyElement.byId, "txtPassword", password);
            AutomationHelper.ClickButton(_window, IdentifyElement.byId, "btnLogin");            
        }

        //Reusable wrapper methods
        public void EnterValidCredentialsAndLogin()
        {
            AutomationHelper.EnterText(_window, IdentifyElement.byId, "txtLogin", "ATT");
            AutomationHelper.EnterText(_window, IdentifyElement.byId, "txtPassword", "password");
            AutomationHelper.ClickButton(_window, IdentifyElement.byId, "btnLogin");
            _informationWindow.AssertMessageDetailsAndAccept("rps_demo");
        }
    }
}