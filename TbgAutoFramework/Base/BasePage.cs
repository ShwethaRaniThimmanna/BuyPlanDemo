using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Tbg.Automation.Framework.Base
{
    public abstract  class BasePage:Base
    {
       // private readonly IWebDriver _driver = null;

        public BasePage()
        {
           // this._driver = DriverContext.Driver ?? throw new NullReferenceException("DriverContext.Driver is not initialized");
        }

        public IWebDriver Driver => DriverContext.Driver;
    }
}
