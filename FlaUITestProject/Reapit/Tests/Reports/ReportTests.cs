namespace FlaUIPoC.Reapit.Tests.Reports
{
    internal class ReportTests : BaseSetup
    {

        [Test]
        public void RPT_33_Run_the_Offers_Report_and_open_a_result_from_the_report_output()
        {
            DateTime startTime = DateTime.Now;
            Console.WriteLine("Start time : " + startTime);

            // step	1. Given I am logged in as Test User	AC is open with the Home screen showing
            var loginPage = MainWindow.LoginScreen;
            loginPage.EnterValidCredentialsAndLogin();

            // step	2. And I click the Reports menu button	Then the Reports menu opens	
            var homeScreen = MainWindow.HomeScreen;
            homeScreen.ClickMainMenuItem("Reports");

            //step	3. And I click the MI Analysis header	Then the MI Analysis section expands
            var searchPanel = MainWindow.RecentSearchPanel;
			searchPanel.ClickSubMenuItem("MI analysis");

            //step	4. And I click the option 'Offers & Pipeline Reports'	
            //Then the Reports menu closes And the Offer Reporting screen opens									
			searchPanel.ClickSubMenuItem("Offers & Pipeline Reports");

			//step  5.And I click the Offer Report radiobutton Then the Offer Report radiobutton shows as selected
			var offerReporting = MainWindow.OfferReportingWindow;
			offerReporting.ClickOfferReportRadioButton();
			offerReporting.CheckOfferReportRadioButtonIsSelected();

			// step	6. When I click the Report button bottom right	
			// Then the Offer results window opens And results are listed in the pane with Property addresses and Buyer names in the first two columns respectively									
			offerReporting.ClickReportButton();
			var offerFoundWindow = MainWindow.OffersFoundWindow;
			var firstBuyerName = offerFoundWindow.GetBuyerName("0");





            /*
																
						
step	6. When I click the Report button bottom right	Then the Offer results window opens And results are listed in the pane with Property addresses and Buyer names in the first two columns respectively									
	window	control	timeout(second)								
wait for control	OfferReportingScreen	report	80								
	window	control	click type	x	y						
click	OfferReportingScreen	report	left								
	window	time out									
wait for window	OffersFound	50									
	window	control	property	variable							
get control property	OffersFound	recentbuyername	name	recentBuyerNameVar							
	window	control	property	variable							
get control property	OffersFound	recentpropertyname	name	recentPropertyNameVar							
step	7. When I double-click the first entry in the listing	Then the Property screen opens And the Offers screen opens And the Buyer name for that row in the listing shows selected in the Offers screen listing									
	window	control	timeout(second)								
wait for control	OffersFound	recentbuyername	90								
	window	control	click type	x	y						
click	OffersFound	recentbuyername	left								
	milliseconds										
sleep	400										
	window	control	click type	x	y						
click	OffersFound	recentbuyername	double								
	window	time out									
wait for window	ReportsOfferScreen	90									
	window	control	rect	text	index	text color					
check text exists				#recentBuyerNameVar							
step	8. And I click the Exit button	Then the Offers screen closes And I return to the Property screen And the Property address for that row in the listing shows in the Address field of the Property									
	window	control	click type	x	y						
click	ReportsOfferScreen	btnexit	left								
	window	control	property	variable							
get control property	Propertyscreen	housename	text	propertyHouseName							
	text	fragment									
check text contains	# recentPropertyNameVar	# propertyHouseName									
	window	control	property	variable							
get control property	Propertyscreen	houseaddress	text	propertyHouseAddress							
	text	fragment									
check text contains	# recentPropertyNameVar	# propertyHouseAddress									
step	9. And I click the Exit button	Then the Property screen closes And I return to the Offer results window									
	window	control	click type	x	y						
click	Propertyscreen	aid_btnexit	left								
	window	time out									
wait for window	OffersFound	30									
step	10. And I click the Exit button	Then the Offer results window closes And I return to the Offer Reporting screen									
	window	control	click type	x	y						
click	OffersFound	btnexit	left								
	window	time out									
wait for window	OfferReportingScreen	30									
step	11. And I click the Exit button	Then the Offer Reporting screen closes And I return to the Home screen									
	window	control	click type	x	y						
click	OfferReportingScreen	btnclose	left								
	window	time out									
wait for window	HomeScreen	30									
             */
        }
    }
}
