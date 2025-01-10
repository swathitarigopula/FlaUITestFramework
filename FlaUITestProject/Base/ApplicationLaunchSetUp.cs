using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.UIA3;
using System.Diagnostics;

namespace FlaUIPoC.Base
{
    public class ApplicationLaunchSetUp
    {
        public static Application Application { get; set; }
        public static UIA3Automation Automation { get; set; }

        public ApplicationLaunchSetUp() { }

        public void Init()
        {
            Automation = new UIA3Automation();
            var processStartInfo = new ProcessStartInfo();
            processStartInfo.LoadUserProfile = false;
            processStartInfo.UseShellExecute = false;
            processStartInfo.FileName = @"C:\\Automation\\Utility\\12_199_0_RC7\\RPS.Bootstrapper.exe";
            Application = Application.AttachOrLaunch(processStartInfo);
            WaitForApplicationLaunch();
        }

        private static void WaitForApplicationLaunch()
        {
            int windowCount = 0;
            int count = 0;
            do
            {
                try
                {
                    windowCount = Application.GetAllTopLevelWindows(Automation).Length;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error while accessing the application :" + ex);
                }

                Thread.Sleep(1000);
                count++;
            }
            while (windowCount < 1 && count < 150);
        }

        public void Cleanup()
        {
            Automation.Dispose();
            Application.Close();
            Application.Kill();
        }

        public Window FindWindow(Func<Window, bool> predicateFunc)
        {
            using (var automation = new UIA3Automation())
            {
                return Application.GetAllTopLevelWindows(automation).FirstOrDefault(predicateFunc);
            }
        }
    }
}
