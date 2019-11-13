using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using BuyPlan.Automation.Framework.Base;
using BuyPlan.Automation.Framework.Extensions;
using NUnit.Framework;

namespace BuyPlan.Automation.Web.Test.Pages
{
    public class ProductSummaryPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = ("//a[contains(@href,'/BuyPlan/Summary')]"))]
        IWebElement ProductSummary { get; set; }

        [FindsBy(How = How.XPath, Using = ("//a[contains(@href,'/BuyPlan/FinancialConsolidation')]"))]
        IWebElement FinancialConsolidation { get; set; }

        //From Date Selector text field
        [FindsBy(How = How.Id, Using = "fStartDate")]
        IWebElement fromDate { get; set; }

        //To Date Selector text field
        [FindsBy(How = How.Id, Using = "fEndDate")]
        IWebElement toDate { get; set; }

        //Search button next to date selector
        [FindsBy(How = How.XPath, Using = "//*[@class='btn btn-success filterDateSearch']")]
        IWebElement dateSearchButton { get; set; }

        //Unsync tab
        [FindsBy(How = How.Id, Using = "unSyncedStylesButton")]
        IWebElement unSyncedTab { get; set; }

        //Half year selector
        [FindsBy(How = How.LinkText, Using = "2-2020")]
        IWebElement halfYear { get; set; }

        //Product Number search text field
        [FindsBy(How = How.XPath, Using = "(//input[@id='inputProductNbr'])[1]")]
        IWebElement productNumberSearch { get; set; }

        //Product Number search result column
        [FindsBy(How = How.XPath, Using = "//table[@id='StyleSummaryTable_tableColumnClone']//td[3]")]
        IList<IWebElement> productNumberColumn { get; set; }

        //Family search text field
        [FindsBy(How = How.XPath, Using = "(//input[@id='inputFamily'])[1]")]
        IWebElement familySearch { get; set; }

        //Family search result column
        [FindsBy(How = How.XPath, Using = "//table[@id='StyleSummaryTable_tableColumnClone']//td[4]")]
        IList<IWebElement> familyColumn { get; set; }

        //Class search text field
        [FindsBy(How = How.XPath, Using = "(//input[@id='inputClass'])[1]")]
        IWebElement classSearch { get; set; }

        //Class search result column
        [FindsBy(How = How.XPath, Using = "//table[@id='StyleSummaryTable_tableColumnClone']//td[5]")]
        IList<IWebElement> classColumn { get; set; }

        //Seasonality search text field
        [FindsBy(How = How.XPath, Using = "(//input[@id='inputSeasonality'])[1]")]
        IWebElement seasonalitySearch { get; set; }

        //Seasonality search result column
        [FindsBy(How = How.XPath, Using = "//table[@id='StyleSummaryTable_tableColumnClone']//td[6]")]
        IList<IWebElement> seasonalityColumn { get; set; }

        //Kmart StyleID search text field
        [FindsBy(How = How.XPath, Using = "(//input[@id='inputKmartStyleId'])[1]")]
        IWebElement kmartStyleIDSearch { get; set; }

        //Kmart StyleID search result column
        [FindsBy(How = How.XPath, Using = "//table[@id='StyleSummaryTable_tableColumnClone']//td[7]")]
        IList<IWebElement> kmartStyleIDColumn { get; set; }

        //Product Description search text field
        [FindsBy(How = How.XPath, Using = "(//input[@id='inputProductDescription'])[1]")]
        IWebElement productDescriptionSearch { get; set; }

        //Product Description search result column
        [FindsBy(How = How.XPath, Using = "//table[@id='StyleSummaryTable_tableColumnClone']//td[8]")]
        IList<IWebElement> productDescriptionColumn { get; set; }

        //Primary Colour search text field
        [FindsBy(How = How.XPath, Using = "(//input[@id='inputPrimaryColour'])[1]")]
        IWebElement primaryColourSearch { get; set; }

        //Primary Colour search result column
        [FindsBy(How = How.XPath, Using = "//table[@id='StyleSummaryTable_tableColumnClone']//td[9]")]
        IList<IWebElement> primaryColourColumn { get; set; }

        //Secondary Colour search text field
        [FindsBy(How = How.XPath, Using = "(//input[@id='inputSecondaryColour'])[1]")]
        IWebElement secondaryColourSearch { get; set; }

        //Secondary Colour search result column
        [FindsBy(How = How.XPath, Using = "//table[@id='StyleSummaryTable_tableColumnClone']//td[10]")]
        IList<IWebElement> secondaryColourColumn { get; set; }

        //Secondary Colour Long search text field
        [FindsBy(How = How.XPath, Using = "(//input[@id='inputSecondaryColourLong'])[1]")]
        IWebElement secondaryColourLongSearch { get; set; }

        //Secondary Colour Long search result column
        [FindsBy(How = How.XPath, Using = "//table[@id='StyleSummaryTable_tableColumnClone']//td[11]")]
        IList<IWebElement> secondaryColourLongColumn { get; set; }

        //Vendor search text field
        [FindsBy(How = How.XPath, Using = "(//input[@id='inputVendor'])[1]")]
        IWebElement vendorSearch { get; set; }

        //Vendor search result column
        [FindsBy(How = How.XPath, Using = "//table[@id='StyleSummaryTable_tableColumnClone']//td[12]")]
        IList<IWebElement> vendorColumn { get; set; }

        //Search button
        [FindsBy(How = How.XPath, Using = "//button[@id='btnMultiSearch']")]
        IWebElement querySearchbutton { get; set; }

        //No Matching record message
        [FindsBy(How = How.XPath, Using = "//*[@class='dataTables_empty']")]
        IWebElement noRecordFoundText { get; set; }

        //Element for tagname - body
        [FindsBy(How = How.TagName, Using = "body")]
        IWebElement bodyTag { get; set; }

        //===============================================  Methods ======================================================================
        public void ClickProductSummaryTab()
        {
            ProductSummary.Click();
        }

        public void ClickquerySearchbutton()
        {
            querySearchbutton.Click();
        }
        public void EnterFromAndToDates(string FromDate, string ToDate)
        {
            fromDate.SendKeys("FromDate");
            toDate.SendKeys("ToDate");

            //toDate.SelectDropdownList("name");
        }

        public void ClickDateSearchButton()
        {
            dateSearchButton.Click();
        }

        public void ClickUnsyncTab()
        {
            unSyncedTab.Click();
        }

        public FinancialConsolidationPage ClickFinancialConTab()
        {
            FinancialConsolidation.Click();
            return GetInstance<FinancialConsolidationPage>();
        }

        internal void CheckIfDateSearchButtonExist()
        {
            dateSearchButton.AssertElementPresent();
        }

        public void ClickHalfYear()
        {
           halfYear.Click();      
        }

        public void ClickProductNumberTextField()
        {
            productNumberSearch.Click();
        }

        public void EnterTextProductNumberTextField(string ProductNumber)
        {

            productNumberSearch.SendKeys(ProductNumber);
        }

        public void ClickFamilyTextField()
        {
            familySearch.Click();
        }

        public void EnterTextFamilyTextField(string familyName)
        {
            familySearch.SendKeys(familyName);
        }

        public void ClickClassTextField()
        {
            classSearch.Click();
        }

        public void EnterTextClassTextField(string className)
        {
            classSearch.SendKeys(className);
        }

        public void ClickSeasonalityTextField()
        {
            seasonalitySearch.Click();
        }

        public void EnterTextSeasonalityTextField(string seasonalityName)
        {
            seasonalitySearch.SendKeys(seasonalityName);
        }

        public void ClickKmartStyleIDSearchTextField()
        {
            kmartStyleIDSearch.Click();
        }

        public void EnterTextKmartStyleIDSearchTextField(string KmartStyleID)
        {
            kmartStyleIDSearch.SendKeys(KmartStyleID);
        }

        public void ClickProductDescriptionTextField()
        {
            productDescriptionSearch.Click();
        }

        public void EnterTextProductDescriptionTextField(string productDescription)
        {
            productDescriptionSearch.SendKeys(productDescription);
        }

        public void ClickPrimaryColourTextField()
        {
            primaryColourSearch.Click();
        }

        public void EnterTextPrimaryColourTextField(string primaryColour)
        {
            primaryColourSearch.SendKeys(primaryColour);
        }

        public void ClickSecondaryColourTextField()
        {
            secondaryColourSearch.Click();
        }

        public void EnterTextSecondaryColourTextField(string secondaryColour)
        {
            secondaryColourSearch.SendKeys(secondaryColour);
        }

        public void ClickSecondaryColourLongTextField()
        {
            secondaryColourLongSearch.Click();
        }

        public void EnterTextSecondaryColourLongTextField(string secondaryColourLong)
        {
            secondaryColourLongSearch.SendKeys(secondaryColourLong);
        }

        public void ClickVendorTextField()
        {
            vendorSearch.Click();
        }

        public void EnterTextVendorTextField(string vendor)
        {
            vendorSearch.SendKeys(vendor);
        }

        internal ProductSummaryPage NavigateToProductSummary()
        {
            //DriverContext.Browser.GoToUrl(Settings.ProductSummaryUrl);
            DriverContext.Browser.GoToUrl("http://buyplan-test.kmtltd.net.au:84/BuyPlan/Summary?depNo=008");
            return GetInstance<ProductSummaryPage>();
        }

        //Verify if elementis present
        public bool IsElementPresent(By by)
        {
            try
            {
                DriverContext.Driver.FindElement(by);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Validate Product Number query Results
        public void ValidateProductNumberColumn(string ProductNumber)
        {
            foreach (IWebElement element in productNumberColumn)
            {
                String resultText = element.Text;
                resultText = resultText.ToUpper();
                ProductNumber = ProductNumber.ToUpper();
                if ((resultText) != "" && (resultText) != null)
                {
                    bool b1 = resultText.Contains(ProductNumber) | resultText.StartsWith(ProductNumber) | resultText.EndsWith(ProductNumber);
                    Assert.IsTrue(b1);
                }
            }
        }

        //Validate Family column query Results
        public void ValidateFamilyColumn(string Family)
        {
            foreach (IWebElement element in familyColumn)
            {
                String resultText = element.Text;
                resultText = resultText.ToUpper();
                Family = Family.ToUpper();
                if ((resultText) != "" && (resultText) != null)
                {
                    bool b1 = resultText.Contains(Family) | resultText.StartsWith(Family) | resultText.EndsWith(Family);
                    Assert.IsTrue(b1);
                }
            }
        }

        //Validate Class column query Results
        public void ValidateClassColumn(string Class)
        {
            foreach (IWebElement element in classColumn)
            {
                String resultText = element.Text;
                resultText = resultText.ToUpper();
                Class = Class.ToUpper();
                if ((resultText) != "" && (resultText) != null)
                {
                    bool b1 = resultText.Contains(Class) | resultText.StartsWith(Class) | resultText.EndsWith(Class);
                    Assert.IsTrue(b1);
                }
            }
        }

        //Validate Seasonality column query Results
        public void ValidateSeasonalityColumn(string Seasonality)
        {
            foreach (IWebElement element in seasonalityColumn)
            {
                String resultText = element.Text;
                resultText = resultText.ToUpper();
                Seasonality = Seasonality.ToUpper();
                if ((resultText) != "" && (resultText) != null)
                {
                    bool b1 = resultText.Contains(Seasonality) | resultText.StartsWith(Seasonality) | resultText.EndsWith(Seasonality);
                    Assert.IsTrue(b1);
                }
            }
        }

        //Validate KmartStyleID column query Results
        public void ValidateKmartStyleIDColumn(string KmartStyleID)
        {
            foreach (IWebElement element in kmartStyleIDColumn)
            {
                String resultText = element.Text;

                //resultText = resultText.ToUpper();
                //KmartStyleID = KmartStyleID.ToUpper();
                if ((resultText) != "" && (resultText) != null)
                {
                    bool b1 = resultText.Contains(KmartStyleID) | resultText.StartsWith(KmartStyleID) | resultText.EndsWith(KmartStyleID);
                    Assert.IsTrue(b1);

                }

            }
        }


        //Validate ProductDescription column query Results
        public void ValidateProductDescriptionColumn(string ProductDescription)
        {
            foreach (IWebElement element in productDescriptionColumn)
            {
                String resultText = element.Text;
                resultText = resultText.ToUpper();
                //ProductDescription = ProductDescription.ToUpper();
                if ((resultText) != "" && (resultText) != null)
                {
                    bool b1 = resultText.Contains(ProductDescription) | resultText.StartsWith(ProductDescription) | resultText.EndsWith(ProductDescription);
                    Assert.IsTrue(b1);
                }
            }
        }

        //Validate Primary Colour column query Results
        public void ValidatePrimaryColourColumn(string PrimaryColour)
        {
            foreach (IWebElement element in primaryColourColumn)
            {
                String resultText = element.Text;
                resultText = resultText.ToUpper();
                PrimaryColour = PrimaryColour.ToUpper();
                if ((resultText) != "" && (resultText) != null)
                {
                    bool b1 = resultText.Contains(PrimaryColour) | resultText.StartsWith(PrimaryColour) | resultText.EndsWith(PrimaryColour);
                    Assert.IsTrue(b1);
                }
            }
        }

        //Validate Secondary Colour column query Results
        public void ValidateSecondaryColourColumn(string SecondaryColour)
        {
            foreach (IWebElement element in secondaryColourColumn)
            {
                String resultText = element.Text;
                resultText = resultText.ToUpper();
                SecondaryColour = SecondaryColour.ToUpper();
                if ((resultText) != "" && (resultText) != null)
                {
                    bool b1 = resultText.Contains(SecondaryColour) | resultText.StartsWith(SecondaryColour) | resultText.EndsWith(SecondaryColour);
                    Assert.IsTrue(b1);
                }
            }
        }

        //Validate Secondary Colour Long column query Results
        public void ValidateSecondaryColourLongColumn(string SecondaryColourLong)
        {
            foreach (IWebElement element in secondaryColourLongColumn)
            {
                String resultText = element.Text;
                resultText = resultText.ToUpper();
                SecondaryColourLong = SecondaryColourLong.ToUpper();
                if ((resultText) != "" && (resultText) != null)
                {
                    bool b1 = resultText.Contains(SecondaryColourLong) | resultText.StartsWith(SecondaryColourLong) | resultText.EndsWith(SecondaryColourLong);
                    Assert.IsTrue(b1);
                }
            }
        }

        //Validate Vendor column query Results
        public void ValidateVendorColumn(string Vendor)
        {
            foreach (IWebElement element in vendorColumn)
            {
                String resultText = element.Text;
                resultText = resultText.ToUpper();
                Vendor = Vendor.ToUpper();
                if ((resultText) != "" && (resultText) != null)
                {
                    bool b1 = resultText.Contains(Vendor) | resultText.StartsWith(Vendor) | resultText.EndsWith(Vendor);
                    Assert.IsTrue(b1);
                }
            }
        }

        //Verify page contains text
        public void VerifyPageContainsText(string message)
        {
            if (bodyTag.Text.Contains(message))
            {
                Console.WriteLine("search is successful");
            }
            else
            {
                throw new System.Exception();
            }
        }

        //Clear Text - productNumberSearch
        public void ProductNumberClearText()
        {
            productNumberSearch.Clear();
        }

        public void FamilyClearText()
        {
            familySearch.Clear();
        }

        public void ClassClearText()
        {
            classSearch.Clear();
        }

        public void SeasonalityClearText()
        {
            seasonalitySearch.Clear();
        }

        public void KmartStyleIDClearText()
        {
            kmartStyleIDSearch.Clear();
        }

        public void ProductDescriptionClearText()
        {
            productDescriptionSearch.Clear();
        }

        public void PrimaryColourClearText()
        {
            primaryColourSearch.Clear();
        }

        public void SecondaryColourClearText()
        {
            secondaryColourSearch.Clear();
        }

        public void SecondaryColourLongClearText()
        {
            secondaryColourLongSearch.Clear();
        }

        public void VendorClearText()
        {
            vendorSearch.Clear();
        }

        //Verify text present in element - noRecordFoundText
        public void VerifyTextInElementNoRecord(string message)
        {
            if (noRecordFoundText.Text.Contains(message))
            {
                Console.WriteLine("search is successful");
            }
            else
            {
                throw new System.Exception();
            }
        }

        public void EnterTextKmartStyleID(string styleId)
        {
            kmartStyleIDSearch.Click();
            kmartStyleIDSearch.SendKeys(styleId);
        }

        public void ClickEnter()
        {
            Actions action = new Actions(DriverContext.Driver);
            action.MoveToElement(productNumberSearch).SendKeys(Keys.Enter);
        }

        public void ClickTab()
        {
            Actions action = new Actions(DriverContext.Driver);
            action.MoveToElement(productNumberSearch).SendKeys(Keys.Enter);
        }

        public void BrowserClose()
        {
            DriverContext.Driver.Quit();
        }

        //internal ProductSummaryPage NavigateToProductSummary()
        //{
        //    DriverContext.Browser.GoToUrl(Settings.ProductSummaryUrl);
        //    DriverContext.Browser.GoToUrl("http://buyplan-test.kmtltd.net.au:84/BuyPlan/Summary?depNo=008");
        //    DriverContext.Browser.GoToUrl("http://buyplan-dev.int.ap-southeast-2.dev.a-sharedinfra.net/BuyPlan/Summary?depNo=008");
        //    return GetInstance<ProductSummaryPage>();
        //}



    }
}
