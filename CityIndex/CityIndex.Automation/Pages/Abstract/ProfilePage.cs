using System;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace CityIndex.Automation.Pages
{
    public abstract class ProfilePage : Page
    {
        protected Func<AppQuery, AppQuery> LoginText { get; set; }
        protected Func<AppQuery, AppQuery> LogoutButton { get; set; }

        public ProfilePage(IApp app): base(app)
        {
        
        }

        public void YouAreLoggedInTextIsDisplayed(string successLoggedInText)
        {
            var loginText = App.WaitForElement(LoginText).FirstOrDefault().Text;
            Assert.AreEqual(successLoggedInText, loginText);

        }

        public void TapLogoutButton()
        {
            App.Tap(LogoutButton);

        }

    }
}
