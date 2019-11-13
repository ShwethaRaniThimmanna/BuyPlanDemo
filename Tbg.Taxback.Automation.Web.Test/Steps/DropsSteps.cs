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
    public class DropsSteps : BaseStep
    {
        [Given(@"I am on the CreateDrops page")]
        public CreateDropPage GivenIAmOnTheCreateDropsPage()
        {
            return GetInstance<CreateDropPage>();
        }

        [Given(@"I verify drop is in (.*) state")]
        public void GivenIVerifyDropIsInReleasedState(string status)
        {
            if(status == "Released")
            {
                CurrentPage = GetInstance<DropsPage>();
                CurrentPage.As<DropsPage>().VerifyDropLocatorReleasedStatus();
            }
                

            else if (status == "Purchaseorder")
                CurrentPage.As<DropsPage>().VerifyDropLocatorPurchaseOrderStatus();
        }

        
    }
}
