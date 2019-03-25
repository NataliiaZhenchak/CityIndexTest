using System;
using CityIndex.Automation.Pages;
using CityIndex.Automation.Utils;
using TechTalk.SpecFlow;

namespace CityIndex.Automation
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"I am on Login page")]
        public void IAmOnLoginpage()
        {
            var loginPage = ScenarioContext.Current.GetCurrentPage<LoginPage>();
            loginPage.PageHeaderIsDisplayed();
        }
        [When(@"I enter ""(.*)"" in Username field")]
        public void IEnterUsername(string userName)
        {
            var loginPage = ScenarioContext.Current.GetCurrentPage<LoginPage>();

            loginPage.EnterUserName(userName);
        }

        [When(@"I enter ""(.*)"" in Password field")]
        public void IEnterPassword(string password)
        {
            var loginPage = ScenarioContext.Current.GetCurrentPage<LoginPage>();

            loginPage.EnterPassword(password);
        }
        [When(@"I tap Login button")]
        public void ITapLoginButton()
        {
            var loginPage = ScenarioContext.Current.GetCurrentPage<LoginPage>();

            loginPage.TapLoginButton();
        }

        [Then(@"I can see Login Failed pop up")]
        public void LoginPopUpIsShown()
        {
            var loginPage = ScenarioContext.Current.GetCurrentPage<LoginPage>();

            loginPage.LoginFailedPopUpIsDisplayed();
        }
    }
}
