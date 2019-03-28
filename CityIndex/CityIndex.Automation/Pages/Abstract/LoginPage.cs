using System;
using System.Linq;
using CityIndex.Automation.Pages.Droid;
using NUnit.Framework;
using TechTalk.SpecFlow;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace CityIndex.Automation.Pages
{

    public abstract class LoginPage: Page
    {
        protected Func<AppQuery, AppQuery> PageHeader { get; set; }
        protected Func<AppQuery, AppQuery> EmailField { get; set; }
        protected Func<AppQuery, AppQuery> PasswordField { get; set; }
        protected Func<AppQuery, AppQuery> LoginButton { get; set; }
        protected Func<AppQuery, AppQuery> LoginPopUp { get; set; }
        protected Func<AppQuery, AppQuery> OKButton { get; set; }

        public LoginPage(IApp app): base(app)
        {

        }

        public void PageHeaderIsDisplayed()
        {
            var loginHeadertext = App.WaitForElement(PageHeader).FirstOrDefault().Text;
            Assert.AreEqual("City Index", loginHeadertext);
        }

        public void EnterUserName(string userName)
        {
            App.ClearText(EmailField); 
            App.EnterText(EmailField, userName);
            App.DismissKeyboard();
        }

        public void EnterPassword(string password)
        {
            App.ClearText(PasswordField);
            App.EnterText(PasswordField, password);
            App.DismissKeyboard();
        }

        public void TapLoginButton()
        {
            App.Tap(LoginButton);
        }

        public void IsLoginFailedPopUpDisplayed()
        {
            Assert.True(App.WaitForElement(LoginPopUp).Length > 0);
      

        }
        public void IsLoginButtonDisplayed()
        {
            Assert.True(App.WaitForElement(LoginButton).Length > 0);

        }
        public void TapOKButton()
        {
            App.Tap(OKButton);
        }
        public void IsLoginFailedPopUpNotDisplayed()
        {
            App.WaitForNoElement(LoginPopUp);


        }

    }
}
