using System;
using NUnit.Framework;
using Tbg.Automation.Framework.Base;
using Tbg.Automation.Framework.Helpers;
using Tbg.Taxback.Automation.Web.Test.Pages;
using TechTalk.SpecFlow;

namespace Tbg.Taxback.Automation.Web.Test.Steps
{
    [Binding]
    public class WorklistFeatureSteps:BaseStep
    {

        [Given(@"I am in the worklist page")]
        public void GivenIAmInTheWorklistPage()
        {
            CurrentPage = CurrentPage.As<WorkListPage>();
            
        }

        
        [Given(@"I select the '(.*)' row from the worklist")]
        public void GivenISelectTheFirstRowFromTheWorklist(int rowNumber)
        {
           CurrentPage.As<WorkListPage>().SelectWorklistTableRow(rowNumber);
        }
        
        [When(@"I click the View Details button")]
        public void WhenIClickTheViewDetailsButton()
        {
           CurrentPage= CurrentPage.As<WorkListPage>().ClickViewDetails();
        }
        
        [Then(@"the View Details section should be displayed")]
        public void ThenTheViewDetailsSectionShouldBeDisplayed()
        {
            //if page not visible, it will throw exception and test would fail
           CurrentPage.As<ViewWorklistDetailPage>().CheckIfPageVisible();
        }

        [When(@"I click on manual check button")]
        public void WhenIClickOnManualCheckButton()
        {
         CurrentPage=  CurrentPage.As<ViewWorklistDetailPage>().ClickManualCheckButton();
        }

        [Then(@"I should be navigated to customer page")]
        public void ThenIShouldBeNavigatedToCustomerPage()
        {
            Assert.IsTrue(CurrentPage.As<CustomerPage>().IsInCustomerPage());
        }


    }
}
