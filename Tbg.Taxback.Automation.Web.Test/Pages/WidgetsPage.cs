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
    public class WidgetsPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = ("//button[contains(@class,'changeLogDownloadbtn')]"))]
        IWebElement ChangeLogDownloadButton { get; set; }

        [FindsBy(How = How.XPath, Using = ("//button[contains(@class,'filterDateSearch')]"))]
        IWebElement filterDateSearchButton { get; set; }

        internal void CheckIfChangeLogDownloadButtonPresent()
        {
            ChangeLogDownloadButton.AssertElementPresent();
        }

        internal void CheckIfSearchButtonPresent()
        {
            filterDateSearchButton.AssertElementPresent();
        }

        internal ProductSummaryPage NavigateToProductSummary()
        {
            //DriverContext.Browser.GoToUrl(Settings.ProductSummaryUrl);
            DriverContext.Browser.GoToUrl("http://buyplan-test.kmtltd.net.au:84/BuyPlan/Summary?depNo=008");
            //DriverContext.Browser.GoToUrl("http://buyplan-dev.int.ap-southeast-2.dev.a-sharedinfra.net/BuyPlan/Summary?depNo=008");
            return GetInstance<ProductSummaryPage>();
        }

        internal DropsPage NavigateToDropsPage()
        {
            //DriverContext.Browser.GoToUrl(Settings.ProductSummaryUrl);
            DriverContext.Browser.GoToUrl("http://buyplan-test.kmtltd.net.au:84/Planner/Drops?depNo=008&startDate=6-1-2020&endDate=28-6-2020&viewMode=1");
            //DriverContext.Browser.GoToUrl("http://buyplan-dev.int.ap-southeast-2.dev.a-sharedinfra.net/BuyPlan/Summary?depNo=008");
            return GetInstance<DropsPage>();
        }

        internal PurchaseOrderPage NavigateToPurchaseOrderPage()
        {
            DriverContext.Browser.GoToUrl("http://buyplan-test.kmtltd.net.au:84/Planner/PurchaseOrder?depNo=008");
            return GetInstance<PurchaseOrderPage>();
        }
    }
}
