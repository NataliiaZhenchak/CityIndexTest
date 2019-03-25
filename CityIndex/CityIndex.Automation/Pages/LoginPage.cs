using System;
using System.Linq;
using NUnit.Framework;
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
        public void LoginFailedPopUpIsDisplayed()
        {
            var loginPopUptext = App.WaitForElement(LoginPopUp).FirstOrDefault().Text;
            Assert.AreEqual("Login Failed", loginPopUptext);

        }
    }
}
