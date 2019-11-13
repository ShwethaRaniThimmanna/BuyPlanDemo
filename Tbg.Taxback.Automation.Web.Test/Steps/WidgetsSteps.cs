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
    public class WidgetsSteps : BaseStep
    {
        [Given(@"I Login to BuyPlanApplication as Planner")]
        public void GivenIHaveNavigatedToTheBuyPlanApplicationAsPlanner()
        {
            NavigateSitePlanner();
            CurrentPage = GetInstance<WidgetsPage>();
        }
    
        [Given(@"I verify SearchButton is Present")]
        public void GivenIVerifySearchButtonIsPresent()
        {
            CurrentPage.As<WidgetsPage>().CheckIfSearchButtonPresent();
        }

        [Given(@"I navigate to (.*) page as Planner")]
        public void GivenINavigateToPage(string pageName)
        {
            DriverContext.Driver.Manage().Window.Maximize();
            DriverContext.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(300);

            if (pageName == "ProductSummary")
            {
                CurrentPage = GetInstance<WidgetsPage>();
                CurrentPage = CurrentPage.As<WidgetsPage>().NavigateToProductSummary();
            }

            else if (pageName == "Drops")
            {
                CurrentPage = GetInstance<WidgetsPage>();
                CurrentPage = CurrentPage.As<WidgetsPage>().NavigateToDropsPage();
            }

            else if(pageName == "PurchaseOrder")
            {
                CurrentPage = GetInstance<WidgetsPage>();
                CurrentPage = CurrentPage.As<WidgetsPage>().NavigateToPurchaseOrderPage();
            }
        }

        [Given(@"I see application opened")]
        public void GivenISeeApplicationOpened()
        {
            CurrentPage.As<WidgetsPage>().CheckIfChangeLogDownloadButtonPresent();
        }


    }
}
