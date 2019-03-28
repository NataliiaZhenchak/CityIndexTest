using System;
using CityIndex.Automation.Pages;
using CityIndex.Automation.Pages.Droid;
using CityIndex.Automation.Utils;
using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace CityIndex.Automation
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"I am on Login page")]
        public void IAmOnLoginpage()
        {
            var loginPage = ScenarioContext.Current.GetPage<LoginPage>();
            loginPage.PageHeaderIsDisplayed();
        }

        [When(@"I enter ""(.*)"" in Username field")]
        public void IEnterUsername(string userName)
        {
            var loginPage = ScenarioContext.Current.GetPage<LoginPage>();

            loginPage.EnterUserName(userName);
        }

        [When(@"I enter ""(.*)"" in Password field")]
        public void IEnterPassword(string password)
        {
            var loginPage = ScenarioContext.Current.GetPage<LoginPage>();

            loginPage.EnterPassword(password);
        }
        [When(@"I tap Login button")]
        public void ITapLoginButton()
        {
            var loginPage = ScenarioContext.Current.GetPage<LoginPage>();

            loginPage.TapLoginButton();
        }

        [Then(@"I can see Login Failed pop up")]
        public void LoginPopUpIsShown()
        {
            var loginPage = ScenarioContext.Current.GetPage<LoginPage>();

            loginPage.IsLoginFailedPopUpDisplayed();

        }
        [Then(@"I am logged out successfully")]
        public void LogoutSuccess()
        {
            var loginPage = ScenarioContext.Current.GetPage<LoginPage>();
            loginPage.IsLoginButtonDisplayed();

        }
        [When(@"I tap OK button")]
        public void ITapOKButton()
        {
            var loginPage = ScenarioContext.Current.GetPage<LoginPage>();
            loginPage.TapOKButton();

        }
        [Then(@"Login Failed pop up is dismissed")]
        public void LoginPopUpDismissed()
        {
            var loginPage = ScenarioContext.Current.GetPage<LoginPage>();
            loginPage.IsLoginFailedPopUpNotDisplayed();

        }

    }
}
