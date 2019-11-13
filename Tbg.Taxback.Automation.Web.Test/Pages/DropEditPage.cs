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
    public class DropEditPage : BasePage
    {

        //[FindsBy(How = How.XPath, Using = ("//input[@type='checkbox'][@ng-model='orderPack.Selected'][contains(@class,'ng-touched')]"))]
        [FindsBy(How = How.XPath, Using = ("//div[@id='63802']//div[@class='table-fixed']//tr[1]//td[1]"))]
        
        IWebElement firstRatioPackAus { get; set; }

        [FindsBy(How = How.XPath, Using = ("//a[contains(text(),'New Zealand - #')]"))]
        IWebElement newZealandTab { get; set; }

        [FindsBy(How = How.XPath, Using = ("//div[@id='63791']//tr[1]//td[1]//input[1]"))]
        IWebElement ratiopackNZ { get; set; }

        [FindsBy(How = How.XPath, Using = ("//div[@id='63791']//div[@class='table-fixed']//tr[2]//td[1]//input[1]"))]
        IWebElement singlepackNZ { get; set; }

        [FindsBy(How = How.XPath, Using = ("//button[@class='btn btn-primary']"))]
        IWebElement saveChangesButton { get; set; }

        [FindsBy(How = How.XPath, Using = ("//button[@id='closeModalBtn']"))]
        IWebElement dropEditCloseButton { get; set; }

        [FindsBy(How = How.LinkText, Using = ("//h4[contains(text(),'Greige')]"))]
        IWebElement dropStateGreige { get; set; }

        [FindsBy(How = How.XPath, Using = ("//h4[contains(text(),'Released')]"))]
        //[FindsBy(How = How.XPath, Using = ("//a[@class='dropStateBtn'][contains(@ng-click,'Released')]"))]
        
        IWebElement dropStateReleased { get; set; }

        [FindsBy(How = How.XPath, Using = ("//button[@class='btn btn-white dropStateConfirmation']"))]
        IWebElement stateChangeCancelButton { get; set; }

        [FindsBy(How = How.XPath, Using = ("//button[@class='btn btn-info dropStateConfirmation']"))]
        IWebElement stateChangeUpdateStatusButton { get; set; }

        //Drop Quantity text field
        [FindsBy(How = How.XPath, Using = ("//*[label='Drop Quantity']//input[@type='number']"))]
        IWebElement dropQuantityTextField { get; set; }

        //DC Due Date dropdown
        [FindsBy(How = How.XPath, Using = "//select[contains(@ng-change,'dcDueDateChanged')]")]
        IWebElement dcDueDateDropdown { get; set; }

        //DC Due Date dropdown option
        [FindsBy(How = How.XPath, Using = "//select[contains(@ng-change,'dcDueDateChanged')]/option[text()='PD08WK04F20']")]
        IWebElement dcDueDateDropdownOption { get; set; }
        

        //Delete Drop button
        [FindsBy(How = How.XPath, Using = "//button[@type='button'][text()='Delete Drop']")]
        IWebElement deleteDropButton { get; set; }

        
        //====================================== Methods===========================================================


        public void ClickFirstRatioPackAus()
        {
            bool enab = firstRatioPackAus.Enabled;
            firstRatioPackAus.Click();
        }

        public void ClickNewZealandTab()
        {
            newZealandTab.Click();
        }

        public void ClickRatiopackNZ()
        {
            ratiopackNZ.Click();
        }

        public void ClickDropStateGreige()
        {
            dropStateGreige.Click();
        }
        

        public void ClickSinglepackNZ()
        {
            singlepackNZ.Click();
        }

        public void ClickSaveChangesButton()
        {
            saveChangesButton.Click();
        }

        public void ClickDropStateReleased()
        {
            dropStateReleased.Click();
        }

        public void ClickStateChangeUpdateStatusButton()
        {
            stateChangeUpdateStatusButton.Click();
        }

        public DropsPage ClickdropEditCloseButton()
        {
            dropEditCloseButton.Click();
            return GetInstance<DropsPage>();
        }

        public DropsPage ClickDeleteDropButton()
        {
            deleteDropButton.Click();
            return GetInstance<DropsPage>();
        }

        public void EnterDropQuantityTextField(string quantity)
        {
            dropQuantityTextField.Click();
            System.Threading.Thread.Sleep(2000);
            dropQuantityTextField.Clear();
            System.Threading.Thread.Sleep(2000);
            dropQuantityTextField.SendKeys(quantity);
        }

        public void selectFromDcDueDateDropdown(string option)
        {
            //SelectElement slc = new SelectElement(dcDueDateDropdown);
            //slc.SelectByText(option);

            dcDueDateDropdown.Click();
            System.Threading.Thread.Sleep(2000);
            dcDueDateDropdownOption.Click();
        }

        
    }
}
