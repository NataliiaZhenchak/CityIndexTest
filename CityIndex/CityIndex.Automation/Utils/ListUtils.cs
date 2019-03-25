using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityIndex.Automation.Utils
{
    public static class ListUtils
    {
        public static T First<T>(List<T> list)
        {
            return list.First();
        }
    }
}
