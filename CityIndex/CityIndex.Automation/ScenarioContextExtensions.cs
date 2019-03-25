using CityIndex.Automation.Pages;
using CityIndex.Automation.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace CityIndex.Automation
{
    public static class ScenarioContextExtensions
    {
        public static void SetCurrentPage(this ScenarioContext sc, Page page)
        {
            sc.Set(page, Consts.CurrentPageKey);
        }

        public static TPage GetCurrentPage<TPage>(this ScenarioContext sc) where TPage : Page
        {
            return sc.Get<TPage>(Consts.CurrentPageKey);
        }
    }
}
