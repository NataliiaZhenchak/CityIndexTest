using Xamarin.UITest;

namespace CityIndex.Automation.Pages
{
    public abstract class ProfilePage : Page
    {
        public ProfilePage(IApp app): base(app)
        {

        }

        public abstract void Logout();
    }
}
