using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using BuyPlan.Automation.Framework.Base;

namespace BuyPlan.Automation.Web.Test.Pages
{
    public class FinancialConsolidationPage : BasePage
    {
        //From Date Selector text field
        [FindsBy(How = How.Id, Using = "fStartDate")]
        public IWebElement fromDate { get; set; }

        //To Date Selector text field
        [FindsBy(How = How.Id, Using = "fEndDate")]
        public IWebElement toDate { get; set; }

        public void EnterFromAndToDates(string FromDate, string ToDate)
        {
            fromDate.SendKeys("FromDate");
            toDate.SendKeys("ToDate");
        }
    }
}
