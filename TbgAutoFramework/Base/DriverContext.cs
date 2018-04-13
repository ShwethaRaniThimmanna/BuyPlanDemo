using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Tbg.Automation.Framework.Base
{
   public static class DriverContext
    {
        public static IWebDriver Driver { get; set; }

        public static Browser Browser { get; set; }
    }
}
