using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuyPlan.Automation.Framework.Base;
using BuyPlan.Automation.Web.Test.Pages;
using TechTalk.SpecFlow;

namespace BuyPlan.Automation.Web.Test.Steps
{
    [Binding]
    public class KasWidgetsSteps : BaseStep
    {

        [Given(@"I Login to BuyPlanApplication as KAS user")]
        public void GivenILoginToBuyPlanApplicationAsKASUser()
        {
            NavigateSiteKASUser();
            CurrentPage = GetInstance<KasWidgetsPage>();
        }

        [Given(@"I navigate to (.*) page as KAS user")]
        public void GivenINavigateToPageAsKASUser(string pageName)
        {
            DriverContext.Driver.Manage().Window.Maximize();
            DriverContext.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(300);

            if (pageName == "FactoryCapacityPlanning")
            {
                CurrentPage = GetInstance<KasWidgetsPage>();
                CurrentPage = CurrentPage.As<KasWidgetsPage>().NavigateToFactoryCapacityPlanning();
            }
        }



    }
}
