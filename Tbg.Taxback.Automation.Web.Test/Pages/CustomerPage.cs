using OpenQA.Selenium;
using Tbg.Automation.Framework.Base;
using Tbg.Automation.Framework.Helpers;

namespace Tbg.Taxback.Automation.Web.Test.Pages
{
    public class CustomerPage:BasePage
    {
      
        public bool IsInCustomerPage()
        {
         

          return  Driver.Title.StartsWith("Customer search");
        }
    }
}