using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuyPlan.Automation.Framework.Base;
using BuyPlan.Automation.Web.Test.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BuyPlan.Automation.Web.Test.Steps
{
    [Binding]
    public class ProductSummarySteps : BaseStep
    {
        [Given(@"I enter From and To dates")]
        public void GivenIEnterFromAndToDates(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            CurrentPage.As<ProductSummaryPage>().EnterFromAndToDates(data.FromDate, data.ToDate);
        }

        [Given(@"I click on SearchDatebutton")]
        public void GivenIClickOnSearchDatebutton()
        {
            CurrentPage.As<ProductSummaryPage>().ClickDateSearchButton();
        }

       

        [Given(@"I click on (.*) text field")]
        public void GivenIClickOnTextField(string textField)
        {
            if (textField == "productNumber")
                CurrentPage.As<ProductSummaryPage>().ClickProductNumberTextField();
        }

        

        [Given(@"I click on search icon")]
        public void GivenIClickOnSearchIcon()
        {
            CurrentPage.As<ProductSummaryPage>().ClickquerySearchbutton();
        }

        //[Given(@"I verify that results matches the search criteria")]
        //public void GivenIVerifyThatResultsMatchesTheSearchCriteria(Table table)
        //{
        //    dynamic data = table.CreateDynamicInstance();
        //    CurrentPage.As<ProductSummaryPage>().ValidateProductNumberColumn(data.SampleText);
        //}

        [Given(@"I verify that (.*) results matches the search criteria")]
        public void GivenIVerifyThatResultsMatchesTheSearchCriteria(string results, Table table)
        {
            if (results == "ProductNumber")
            {
                dynamic data = table.CreateDynamicInstance();
                CurrentPage.As<ProductSummaryPage>().ValidateProductNumberColumn(data.SampleText);
            }

            else if (results == "Family")
            {
                dynamic data = table.CreateDynamicInstance();
                CurrentPage.As<ProductSummaryPage>().ValidateFamilyColumn(data.SampleText);
            }

            else if (results == "Class")
            {
                dynamic data = table.CreateDynamicInstance();
                CurrentPage.As<ProductSummaryPage>().ValidateClassColumn(data.SampleText);
            }

            else if (results == "Seasonality")
            {
                dynamic data = table.CreateDynamicInstance();
                CurrentPage.As<ProductSummaryPage>().ValidateSeasonalityColumn(data.SampleText);
            }

            //else if (results == "KmartStyleID")
            //{
            //    dynamic data = table.CreateDynamicInstance();
            //    CurrentPage.As<ProductSummaryPage>().ValidateKmartStyleIDColumn(data.SampleText);
            //}

            else if (results == "ProductDescription")
            {
                dynamic data = table.CreateDynamicInstance();
                CurrentPage.As<ProductSummaryPage>().ValidateProductDescriptionColumn(data.SampleText);
            }

            else if (results == "PrimaryColour")
            {
                dynamic data = table.CreateDynamicInstance();
                CurrentPage.As<ProductSummaryPage>().ValidatePrimaryColourColumn(data.SampleText);
            }

            else if (results == "SecondaryColour")
            {
                dynamic data = table.CreateDynamicInstance();
                CurrentPage.As<ProductSummaryPage>().ValidateSecondaryColourColumn(data.SampleText);
            }

            else if (results == "SecondaryColourLong")
            {
                dynamic data = table.CreateDynamicInstance();
                CurrentPage.As<ProductSummaryPage>().ValidateSecondaryColourLongColumn(data.SampleText);
            }

            else if (results == "Vendor")
            {
                dynamic data = table.CreateDynamicInstance();
                CurrentPage.As<ProductSummaryPage>().ValidateVendorColumn(data.SampleText);
            }
        }


        [Given(@"I wait till BuyPlan loads")]
        public void GivenIWaitTillBuyPlanLoads()
        {

           // WebDriverWait wait = new WebDriverWait(DriverContext.Driver, TimeSpan.FromSeconds(200));
            //wait.Until(condition: ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='preloader-dotline']")));
            // wait.Until(condition: ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@class='preloader-dotline']")));


            //wait.Until(driver1 => ((IJavaScriptExecutor)DriverContext.Driver).ExecuteScript("return document.readyState").Equals("complete"));

            //DriverContext.Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(200);
           // Console.WriteLine("Wait success");

            System.Threading.Thread.Sleep(5000);
        }

        //For int inputs
        [Given(@"I verify that (.*) search results matches ""(.*)""")]
        public void GivenIVerifyThatKmartStyleIDResultsMatchesThe(string textField, string searchText)
        {
            if (textField == "KmartStyleID")
            {
                CurrentPage.As<ProductSummaryPage>().ValidateKmartStyleIDColumn(searchText);
            }

        }


        [Given(@"I am n the page")]
        public void GivenIAmNThePage()
        {
            ScenarioContext.Current.Pending();
        }



    }
}
