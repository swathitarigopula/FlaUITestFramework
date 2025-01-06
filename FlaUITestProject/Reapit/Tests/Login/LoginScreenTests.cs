using FlaUIPoC.AgencyCloud.Pages.Login;


namespace FlaUIPoC.AgencyCloud.Tests.Login
{
    internal class LoginScreenTests : BaseSetup
    {
        [Test]
        public void CheckTheLoginFunctionalityWithValidCredentails()
        {
            var loginPage = MainWindow.LoginScreen;
            loginPage.EnterLoginCredentials("ATT","password");
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
