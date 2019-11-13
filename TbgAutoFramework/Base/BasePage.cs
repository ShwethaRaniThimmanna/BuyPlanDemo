using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BuyPlan.Automation.Framework.Base
{
    public abstract class BasePage : Base
    {
        // private readonly IWebDriver _driver = null;

        public BasePage()
        {
            PageFactory.InitElements(DriverContext.Driver, this);
            // this._driver = DriverContext.Driver ?? throw new NullReferenceException("DriverContext.Driver is not initialized");
        }

        public IWebDriver Driver => DriverContext.Driver;
    }
}
