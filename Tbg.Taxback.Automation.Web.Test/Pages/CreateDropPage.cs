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
    public class CreateDropPage : BasePage
    {
        //Quantity Text field
        [FindsBy(How = How.XPath, Using = ("//input[contains(@class,'ng-valid-min ng-valid-required')]"))]
        IWebElement quantityInputField { get; set; }

        //New Zealand Split(%)
        [FindsBy(How = How.XPath, Using = ("//input[contains(@class,'ng-valid-max')]"))]

        //input[@ng-model='creationPayload.NzSplit']
        IWebElement newZealandSplitTextField { get; set; }

        //Close button
        [FindsBy(How = How.XPath, Using = ("//button[@class='btn btn-default']"))]
        IWebElement closeButton { get; set; }

        //Save Changes button
        [FindsBy(How = How.XPath, Using = ("//button[@type='submit']"))]
        IWebElement saveChangesButton { get; set; }

        public void ClickQuantityInputField()
        {
            quantityInputField.Click();
        }

        public void EnterTextQuantityInputField(string quantity)
        {
            quantityInputField.Click();
            quantityInputField.SendKeys(quantity);
        }

        public void ClickNewZealandSplitTextField()
        {

            newZealandSplitTextField.Click();
        }

        public void EnterTextNewZealandSplitTextField(string quantity)
        {
            ClickNewZealandSplitTextField();
            newZealandSplitTextField.SendKeys(quantity);
        }

        public void ClickSaveChangesButton()
        {
            saveChangesButton.Click();
        }
    }
}
