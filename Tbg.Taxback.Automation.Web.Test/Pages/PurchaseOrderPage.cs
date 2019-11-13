using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuyPlan.Automation.Framework.Base;
using BuyPlan.Automation.Framework.Extensions;

namespace BuyPlan.Automation.Web.Test.Pages
{
    public class PurchaseOrderPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = ("/html[1]/body[1]/div[1]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/input[1]"))]
        IWebElement productNumberSearchTextPO { get; set; }

        [FindsBy(How = How.XPath, Using = ("//*[@class='ui-grid-cell-contents ng-scope']//input[@type='checkbox']"))]
        IWebElement readyForPurchaseOrderCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = ("//button[@class='btn btn-primary orderRaiseSubmitBtn']"))]
        IWebElement raiseOrdersButton { get; set; }

        [FindsBy(How = How.XPath, Using = ("//div[@id='page-wrapper']//label[2]"))]
        IWebElement awaitingPoConfirmationtab { get; set; }

        [FindsBy(How = How.XPath, Using = ("//div[@id='page-wrapper']//label[3]"))]
        IWebElement purchaseOrderRaisedTab { get; set; }

        [FindsBy(How = How.XPath, Using = ("//input[@class='ui-grid-filter-input ui-grid-filter-input-0 ng-touched']"))]
        IWebElement dcDueDateTextField { get; set; }

        public void ClickReadyForPurchaseOrderCheckBox()
        {
            readyForPurchaseOrderCheckBox.Click();
        }

        public void VerifyRaiseOrdersButton()
        {
            raiseOrdersButton.AssertElementPresent();
        }

        public void ClickRaiseOrdersButton()
        {
            raiseOrdersButton.Click();
        }

        public void ClickAwaitingPoConfirmationtab()
        {
            awaitingPoConfirmationtab.Click();
        }

        public void ClickPurchaseOrderRaisedTab()
        {
            purchaseOrderRaisedTab.Click();
        }

        public void EnterTextproductNumberSearchTextPO(string ProductNumber)
        {
            productNumberSearchTextPO.Click();
            productNumberSearchTextPO.SendKeys(ProductNumber);
        }

        public void EnterTextDcDueDateTextField(string quantity)
        {
            dcDueDateTextField.Click();
            dcDueDateTextField.SendKeys(quantity);
        }
    }

    
}
