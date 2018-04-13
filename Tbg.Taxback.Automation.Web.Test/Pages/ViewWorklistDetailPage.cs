using OpenQA.Selenium;
using Tbg.Automation.Framework.Base;
using Tbg.Automation.Framework.Extensions;

namespace Tbg.Taxback.Automation.Web.Test.Pages
{
    public class ViewWorklistDetailPage:WorkListPage
    {
        private IWebElement DivPageContainer => Driver.FindElement(By.Id("rightMenu"));

        private IWebElement BtnManualCheck => Driver.FindElement(By.Id("customer-search-btn"));
        public void CheckIfPageVisible()
        {
           DivPageContainer.AssertElementPresent();
        }

        public CustomerPage ClickManualCheckButton()
        {
            BtnManualCheck.Click();
            return PageInstance<CustomerPage>();

           
        }
    }
}