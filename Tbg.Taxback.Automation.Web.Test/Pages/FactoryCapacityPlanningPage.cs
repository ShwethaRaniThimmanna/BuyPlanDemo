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
    public class FactoryCapacityPlanningPage : BasePage
    {
        //Half year selector
        [FindsBy(How = How.LinkText, Using = "2-2020")]
        IWebElement kasHalfYear { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@id='selectDropButton']")]
        IWebElement kasPendingApproval { get; set; }

        //Test China - Factory
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'TEST CHINA - NINGBO')]")]
        IWebElement kasTestChinaFactory { get; set; }

        //Kishani Test - Factory
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'KISHANI TEST')]")]
        IWebElement KishaniTestFactory { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@class,'checkDept')]")]
        IWebElement kasApprovalDepartmentLevelCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'approveSelectionBtn')]")]
        IWebElement kasApproveselectionButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'rejectSelectionBtn')]")]
        IWebElement kasRejectSelectionButton { get; set; }

        //Planner proposed change tab
        [FindsBy(How = How.XPath, Using = "//label[contains(@class,'btn btn-white plannedOrWhatIf whatIfBtn')]")]
        IWebElement plannerProposedChangeTab { get; set; }

        //Pending WhatIf dropdown
        [FindsBy(How = How.XPath, Using = "//button[@id='dropdownMenu1']")]
        IWebElement pendingWhatIfDropdown { get; set; }

        //Planner propsed Change checkbox
        [FindsBy(How = How.XPath, Using = "//input[@type='checkbox'][@class='checkPlannerProposedFactory']")]
        IWebElement checkBoxTestChina { get; set; }

        //Approve Selection button
        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'approveSelectionBtn')]")]
        IWebElement approveSelectionButton { get; set; }

        //Approve Selection button
        [FindsBy(How = How.LinkText, Using = "D008 GIRLSWEAR SZS 7-14")]
        IWebElement pendingWhatIfDepartmentD008 { get; set; }
        

        //============================================= Methods========================================================
        public void ClickKasHalfYear()
        {
            kasHalfYear.Click();
        }

        public void ClickKasPendingApproval()
        {
            kasPendingApproval.Click();
        }

        public void ClickKasTestChinaFactory()
        {
            kasTestChinaFactory.Click();
        }

        public void ClickKishaniTestFactory()
        {
            KishaniTestFactory.Click();
        }

        public void ClickKasApprovalDepartmentLevelCheckBox()
        {
            kasApprovalDepartmentLevelCheckBox.Click();
        }

        public void VerifyKasApproveselectionButton()
        {
            kasApproveselectionButton.AssertElementPresent();
        }

        public void VerifyKasRejectSelectionButton()
        {
            kasRejectSelectionButton.AssertElementPresent();
        }

        public void ClickKasApproveselectionButton()
        {
            kasApproveselectionButton.Click();
        }

        public void ClickPlannerProposedChangeTab()
        {
            plannerProposedChangeTab.Click();
        }

        public void selectFromPendingWhatIfDropdown()
        {
            pendingWhatIfDropdown.Click();
            pendingWhatIfDepartmentD008.Click();
        }

        public void ClickcheckBoxTestChina()
        {
            checkBoxTestChina.Click();
        }

        public void ClickApproveSelectionButton()
        {
            approveSelectionButton.Click();
        }
    }
}
