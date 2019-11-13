using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuyPlan.Automation.Framework.Base;
using BuyPlan.Automation.Framework.Extensions;
using OpenQA.Selenium.Support.UI;

namespace BuyPlan.Automation.Web.Test.Pages
{
    public class DropsPage : BasePage
    {
        //Product number search text field
        [FindsBy(How = How.Id, Using = ("styleNoText"))]
        IWebElement productNumberSearchTextField { get; set; }

        //Search Icon
        [FindsBy(How = How.XPath, Using = ("//button[@id='searchBtn']"))]
        IWebElement searchButton { get; set; }

        //Drop Locator - No Status
        [FindsBy(How = How.XPath, Using = "(//div[@data-calname='PD08WK03F20' and @data-oid='66800'])")]
        IWebElement dropLocatorNoStatus { get; set; }

        //Drop Locator - No Status
        [FindsBy(How = How.XPath, Using = "(//div[@data-calname='PD08WK02F20' and @data-oid='66892'])")]
        IWebElement dropLocatorNoStatusMoveDCDueDate { get; set; }

        //Drop Locator - Planned Status
        [FindsBy(How = How.XPath, Using = "(//div[@data-calname='PD08WK02F20' and @data-oid='66892'])//div[contains(@class,'plannedBackground')]")]
        IWebElement dropLocatorPlannedStatusMoveDCDueDate { get; set; }


        //Drop Locator - Released Status
        [FindsBy(How = How.XPath, Using = "//div[@data-calname='PD08WK03F20' and @data-oid='66800']/div[contains(@class,'releasedBackground')]//span[contains(text(),'1,000')]")]
        IWebElement dropLocatorReleasedStatus { get; set; }

        //Drop Locator - PurchaseOrder Status
        [FindsBy(How = How.XPath, Using = "//div[@data-calname='PD08WK03F20' and @data-oid='66800']/div[contains(@class,'raisedBackground')]")]
        IWebElement dropLocatorPurchaseOrderStatus { get; set; }

        //What If button
        [FindsBy(How = How.XPath, Using = "//button[@class='btn-white btn-sm btn btn-rounded btn-wi']")]
        IWebElement whatIfButton { get; set; }

        //What If Submit Icon
        [FindsBy(How = How.XPath, Using = "//i[@class='fa fa-unlock btnUnlock']")]
        IWebElement whatIfSubmitIcon { get; set; }

        //Requested By dropdown - Whatif Change Reason
        [FindsBy(How = How.XPath, Using = "//*[@ng-model='selectedRequest']")]
        IWebElement requestedByDropdown { get; set; }

        //Requested By dropdown - option Kmart
        [FindsBy(How = How.XPath, Using = "//option[@label='Kmart']")]
        IWebElement requestedByDropdownOptionKmart { get; set; }

        //Requested By dropdown - option Vendor
        [FindsBy(How = How.XPath, Using = "//option[@label='Vendor']")]
        IWebElement requestedByDropdownOptionVendor { get; set; }

        //Submit button - Change Reason window
        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-primary']")]
        IWebElement submitButtonChangeReasonWindow { get; set; }

        //Half year selector
        [FindsBy(How = How.LinkText, Using = "2-2020")]
        IWebElement halfYearDrops { get; set; }

        //MultiSelect button
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Multi Select')]")]
        IWebElement multiSelectButton { get; set; }

        //Planned Drop - After move
       [FindsBy(How = How.XPath, Using = " //*[@data-calname='PD08WK04F20' and @data-oid='66892']/div[contains(@class,'plannedBackground')]")]
       IWebElement plannedDropAfterMove { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-calname='PD08WK02F20' and @data-oid='66892']/div[contains(@class,'greigeBackground')]")]
        IWebElement moveGreigeDropDcDueDate { get; set; }

        //Need to update
        [FindsBy(How = How.XPath, Using = "//*[@data-calname='PD08WK04F20' and @data-oid='66892']/div[contains(@class,'greigeBackground')]")]
        IWebElement greigeDropAfterMove { get; set; }



 //============================================== Methods ==================================================

        //Click on Product number search text field
        public void ClickProductNumberSearchTextField()
        {
            productNumberSearchTextField.Click();
        }

        public void ClickGreigeDropAfterMove()
        {
            greigeDropAfterMove.Click();
        }

        public void ClickMoveGreigeDropDcDueDate()
        {
            moveGreigeDropDcDueDate.Click();
        }

        public void ClickDropLocatorPlannedStatusMoveDCDueDate()
        {
            dropLocatorPlannedStatusMoveDCDueDate.Click();
        }
        

        public void ClickMultiSelectButton()
        {
            multiSelectButton.Click();
        }

        public void ClickHalfYearDrops()
        {
            halfYearDrops.Click();
        }

        public void ClickPlannedDropAfterMove()
        {
            plannedDropAfterMove.Click();
        }

        //Enter text into Product number search text field
        public void EnterTextDropsProductNumberTextField(string product)
        {
            productNumberSearchTextField.SendKeys(product);
        }

        public void ClickDropsQuerySearchbutton()
        {
            searchButton.Click();
        }

        public void ClickDropLocatorNoStatus()
        {
            dropLocatorNoStatus.Click();
        }

        public void ClickdropLocatorNoStatusMoveDCDueDate()
        {
            dropLocatorNoStatusMoveDCDueDate.Click();
        }

        public void VerifyDropLocatorReleasedStatus()
        {
            dropLocatorReleasedStatus.AssertElementPresent();
        }

        public void VerifyDropLocatorPurchaseOrderStatus()
        {
            dropLocatorPurchaseOrderStatus.AssertElementPresent();
        }

        public void ClickDropLocatorPurchaseOrderStatus()
        {
            dropLocatorPurchaseOrderStatus.Click();
        }

        public void ClickWhatIfButton()
        {
            whatIfButton.Click();
        }

        public void ClickwhatIfSubmitIcon()
        {
            whatIfSubmitIcon.Click();
        }

        public void selectFromRequestedByDropDown(string option)
        {
            SelectElement slc = new SelectElement(requestedByDropdown);
            slc.SelectByText(option);
        }

        public void ClicksubmitButtonChangeReasonWindow()
        {
            submitButtonChangeReasonWindow.Click();
        }

        public void VerifyPresentDropLocatorPlannedStatusMoveDCDueDate()
        {
            dropLocatorPlannedStatusMoveDCDueDate.AssertElementPresent();
        }

        public void VerifyDropLocatorPlannedStatusMoveDCDueDate()
        {
            dropLocatorPlannedStatusMoveDCDueDate.AssertElementNotPresent();
        }

        public void VerifyPlannedDropAfterMove()
        {
            plannedDropAfterMove.AssertElementPresent();
        }

        public void VerifyGreigeDropBeforeMove()
        {
            moveGreigeDropDcDueDate.AssertElementPresent();
        }

        public void VerifyGreigeDropBeforeMoveNotPresent()
        {
            moveGreigeDropDcDueDate.AssertElementNotPresent();
        }

        public void VerifyGreigeDropAfterMove()
        {
            greigeDropAfterMove.AssertElementNotPresent();
        }

    }
}
