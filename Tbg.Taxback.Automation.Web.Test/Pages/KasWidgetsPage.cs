using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuyPlan.Automation.Framework.Base;
using BuyPlan.Automation.Framework.Extensions;

namespace BuyPlan.Automation.Web.Test.Pages
{
    public class KasWidgetsPage : BasePage
    {
        internal FactoryCapacityPlanningPage NavigateToFactoryCapacityPlanning()
        {
            
            DriverContext.Browser.GoToUrl("http://buyplan-test.kmtltd.net.au:84/KasMgmt/FactoryCapacityPlanning");
            return GetInstance<FactoryCapacityPlanningPage>();
        }


    }
}
