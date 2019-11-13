using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using BuyPlan.Automation.Framework.Config;
using TechTalk.SpecFlow;
namespace BuyPlan.Automation.Framework.Base
{
    public class Base
    {
        // private  IWebDriver _driver = null;
        public BasePage CurrentPage
        {
            get => (BasePage)ScenarioContext.Current["currentpage"];
            set => ScenarioContext.Current["currentpage"] = value;
        }

        public AppSettings AppSettings => Settings.AppSettings;

        //protected TPage PageInstance<TPage>() where TPage : BasePage, new()
        //{
        //    TPage pageInstance = new TPage();
        //    //{
        //    //   // _driver = DriverContext.Driver
        //    //};

        //    return pageInstance;
        //}

        private IWebDriver _driver { get; set; }

        protected Tpage GetInstance<Tpage>() where Tpage : BasePage, new()
        {
            Tpage pageInstance = new Tpage()
            {
                _driver = DriverContext.Driver
            };

            //PageFactory.InitElements(DriverContext.Driver, pageInstance);
            return pageInstance;
        }

        public TPage As<TPage>() where TPage : BasePage
        {
            return (TPage)this;
        }
    }

}

