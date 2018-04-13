using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using Tbg.Automation.Framework.Config;
using TechTalk.SpecFlow;
namespace Tbg.Automation.Framework.Base
{
    public class Base
    {
       // private  IWebDriver _driver = null;
        public BasePage CurrentPage
        {
            get => (BasePage)ScenarioContext.Current["currentpage"];
            set =>  ScenarioContext.Current["currentpage"] = value;
        }

        public AppSettings AppSettings => Settings.AppSettings;

        protected TPage PageInstance<TPage>() where TPage : BasePage, new()
        {
            TPage pageInstance = new TPage();
            //{
            //   // _driver = DriverContext.Driver
            //};

            return pageInstance;
        }

        public TPage As<TPage>() where TPage : BasePage
        {
            return (TPage) this;
        }
    }
    
}

