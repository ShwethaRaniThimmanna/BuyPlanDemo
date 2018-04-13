using System.Threading;
using OpenQA.Selenium;
using Tbg.Automation.Framework.Base;
using Tbg.Automation.Framework.Extensions;
using Tbg.Automation.Framework.Helpers;

namespace Tbg.Taxback.Automation.Web.Test.Pages
{
    public class WorkListPage:BasePage
    {
        private IWebElement LblLoggedInUser => Driver.FindElement(By.CssSelector("#logout>li>label"));

        private IWebElement LnkSignOut => Driver.FindElement(By.ClassName("glyphicon-log-out"));

        private IWebElement LnkUserAccount => Driver.FindElement(By.ClassName("dropdown-toggle"));

        private IWebElement TblWorklist => Driver.FindElement(By.Id("web-regs-defaults-tbl"));

        private IWebElement BtnViewDetails => Driver.FindElement(By.Name("checkCase"));


        public string GetLoggedInUser()
        {
          return  LblLoggedInUser.Text;
        }

        public LoginPage SignOut()
        {
            LnkUserAccount.Click();
            LnkSignOut.Click();
           return PageInstance<LoginPage>();
        }


        public void SelectWorklistTableRow(int row)
        {
            var tableData = HtmlTableHelper.ReadTable(TblWorklist);
           IWebElement td= TblWorklist.FindElement(By.CssSelector($"tbody>tr:nth-child({row})>:first-child"));
           td.Click();
        }

        public ViewWorklistDetailPage ClickViewDetails()
        {
            BtnViewDetails.Click();
            Driver.WaitForPageLoaded();
            return PageInstance<ViewWorklistDetailPage>();
        }
        
    }
}
