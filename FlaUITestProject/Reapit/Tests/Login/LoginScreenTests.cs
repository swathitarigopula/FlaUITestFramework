using FlaUIPoC.Reapit.Pages.Login;


namespace FlaUIPoC.Reapit.Tests.Login
{
    internal class LoginScreenTests : BaseSetup
    {
        private LoginWindow _loginScreenPage;

        [Test]
        public void CheckTheLoginFunctionalityWithValidCredentails()
        {
            var loginPage = MainWindow.LoginScreen;
            loginPage.EnterLoginCredentials("ATT", "password");
            var informationDialogue = MainWindow.InformationDialogue;
            informationDialogue.AssertMessageDetailsAndAccept("rps_demo");
        }

        [Test]
        public void CheckTheLoginFunctionalityWithInValidCredentails()
        {
            var loginPage = MainWindow.LoginScreen;
            loginPage.EnterLoginCredentials("ATT", "wrong");
            var informationDialogue = MainWindow.InformationDialogue;
            informationDialogue.AssertMessageDetailsAndAccept("Incorrect user name or password. Please try again.");
        }
    }
}
