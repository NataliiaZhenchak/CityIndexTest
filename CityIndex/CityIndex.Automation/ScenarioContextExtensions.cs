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
        public static void RegisterPage<TAb,TCon>(this ScenarioContext sc, TCon page) where TCon : TAb
        {
            sc.Set<TAb>(page);
        }

        public static TAb GetPage<TAb>(this ScenarioContext sc) where TAb : Page
        {
            return sc.Get<TAb>();
        }
    }
}
