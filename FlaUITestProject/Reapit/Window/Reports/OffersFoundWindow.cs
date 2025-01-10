using FlaUI.Core.AutomationElements;
using FlaUI.Core.Input;
using System.Text.RegularExpressions;
using static AutomationHelper;

namespace FlaUIPoC.Reapit.Window.Reports
{
    public class OffersFoundWindow
    {
        private readonly FlaUI.Core.AutomationElements.Window _window;
        private readonly AutomationElement _offersFoundWindow;
        public OffersFoundWindow(FlaUI.Core.AutomationElements.Window window)
        {
            Wait.UntilResponsive(window);
            _window = window;
            var regex = new Regex(@"\d+ Offers Found");
            var allElements = window.FindAllDescendants();
            _offersFoundWindow = allElements.FirstOrDefault(e => regex.IsMatch(e.Name));
            Assume.That(_offersFoundWindow, Is.Not.Null);
        }

        public string GetBuyerName(string rowNum)
        {
            var buyerName = AutomationHelper.GetTextUsingElementNameProperty(_window, IdentifyElement.byId, $"aid_gridCell_aid_gridRow_{rowNum}_2");
            Console.WriteLine($" The {rowNum} buyer name is {buyerName} from table");
            return buyerName;
        }
    }
}
