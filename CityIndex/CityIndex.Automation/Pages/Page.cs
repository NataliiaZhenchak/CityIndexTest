using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace CityIndex.Automation.Pages
{
    public abstract class Page
    {
        protected IApp App;

        public Page(IApp app)
        {
            App = app;
        }
    }
}
