using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuyPlan.Automation.Framework.Config;
using BuyPlan.Automation.Framework.Extensions;
using BuyPlan.Automation.Framework.Helpers;

namespace BuyPlan.Automation.Framework.Base
{
    public abstract class BaseStep : Base
    {
        public virtual void NavigateSitePlanner()
        {
            DriverContext.Browser.GoToUrl(AppSettings.AUTPlanner);
            //LogHelpers.Write("Opened the browser !!!");
            DriverContext.Driver.Manage().Window.Maximize();
            DriverContext.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(300);
        }

        public virtual void NavigateSiteKASUser()
        {
            DriverContext.Browser.GoToUrl(AppSettings.AUTKas);
            //LogHelpers.Write("Opened the browser !!!");

            DriverContext.Driver.Manage().Window.Maximize();
            DriverContext.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(150);
        }
    }
}
