using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using Tbg.Automation.Framework.Config;
using Tbg.Automation.Framework.Helpers;


namespace Tbg.Automation.Framework.Base
{
    public abstract class InitializeFrameworkHook:Base
    {

        public InitializeFrameworkHook()
        {
          
        }
        public static void InitializeSettings()
        {
           //to do: logging
           //to do: reporting
           //other initialization tasks goes here
           
            //Open Browser
           
            OpenBrowser(Settings.AppSettings.BrowserType);
           DriverContext.Driver.Manage().Window.Maximize();
            
        }

        private static void OpenBrowser(BrowserType browserType = BrowserType.Chrome)
        {
            switch (browserType)
            {
                case BrowserType.InternetExplorer:
                    DriverContext.Driver = new InternetExplorerDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.FireFox:
                    DriverContext.Driver = new FirefoxDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.Chrome:
                    DriverContext.Driver = new ChromeDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.HeadlessChrome:
                    var chromeOption = new ChromeOptions();
                    chromeOption.AddArgument("headless");
                    DriverContext.Driver = new ChromeDriver(chromeOption);
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
            }
        }

        public virtual void NavigateSite()
        {
            DriverContext.Browser.GoToUrl(Settings.AppSettings.AUT);
           
        }



    }
}
