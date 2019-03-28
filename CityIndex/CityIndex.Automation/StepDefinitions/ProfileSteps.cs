using System;
using CityIndex.Automation.Pages;
using CityIndex.Automation.Pages.Droid;
using CityIndex.Automation.Utils;
using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace CityIndex.Automation
{
    [Binding]
    public class ProfileSteps
    {

        [Then(@"I can see ""(.*)"" text")]
        public void VerifyLoggedInText(string successLoggedInText)
        {

            var profilePage = ScenarioContext.Current.GetPage<ProfilePage>();
            profilePage.YouAreLoggedInTextIsDisplayed(successLoggedInText);
        }

        [When(@"I tap Logout button")]
        public void ITapLogout()
        {

            var profilePage = ScenarioContext.Current.GetPage<ProfilePage>();
            profilePage.TapLogoutButton();
        }


    }
}
