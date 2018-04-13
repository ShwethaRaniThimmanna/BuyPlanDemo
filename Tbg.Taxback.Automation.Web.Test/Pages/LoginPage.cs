using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Tbg.Automation.Framework.Base;
using Tbg.Automation.Framework.Extensions;

namespace Tbg.Taxback.Automation.Web.Test.Pages
{
    public class LoginPage : BasePage
    {
        private IWebElement TxtUserName => Driver.FindElement(By.Name("Email"));
        private IWebElement TxtPassword => Driver.FindElement(By.Name("password"));
        private IWebElement BtnLogin => Driver.FindElement(By.CssSelector("button.btn"));

        public void Login(string username, string password)
        {
            TxtUserName.SendKeys(username);
            TxtPassword.SendKeys(password);
        }

        public WorkListPage ClickLoginButton()
        {
            BtnLogin.Submit();
            Driver.WaitForPageLoaded();
            Thread.Sleep(3000);
            return new WorkListPage();
        }

      
    }
}
