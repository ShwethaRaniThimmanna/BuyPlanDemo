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
    public class CreateDropSteps : BaseStep
    {
        [Given(@"I am on the DropEdit page")]
        public DropEditPage GivenIAmOnTheDropEditPage()
        {
            return GetInstance<DropEditPage>();
        }

    }
}
