using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using MongoDB.Driver.Linq;
using Tbg.Automation.Framework.Base;
using TechTalk.SpecFlow;

namespace Tbg.Taxback.Automation.Web.Test.Hooks
{
    [Binding]
    public class HookInitialize : InitializeFrameworkHook
    {
        private static readonly ExtentReports extent;
        private static  ExtentTest extentTest;

        static HookInitialize()
        {
            extent = new ExtentReports();
        
           
        }
        public HookInitialize() : base()
        {
         
            InitializeSettings();
            // NavigateSite();
        }

        [BeforeTestRun()]
        public static void BeforeTestRun()
        {
            var htmlReporter = new ExtentHtmlReporter(@"C:PickelsOutput/extent.html");
            // initialize ExtentReports and attach the HtmlReporter
          
            // attach only HtmlReporter
           
            extent.AttachReporter(htmlReporter);

        }

        [AfterTestRun()]
        public static void AfterTestRun()
        {
         
            extent.Flush();
        }

        [BeforeFeature()]
        public static void BeforeFeature()
        {
            HookInitialize init = new HookInitialize();
            // feature
            var featureDesc = FeatureContext.Current.FeatureInfo.Description;
             extentTest = extent.CreateTest<Feature>(featureDesc);
        }

        [AfterFeature()]
        public static void AfterFeature()
        {
            DriverContext.Driver.Close();
            
            //dispose off the driver otherwise the process keeps running on the machine.
            DriverContext.Driver.Dispose();
        }

        [BeforeScenario()]
        public static void BeforeScenario()
        {
            extentTest = extentTest.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
        }

        [AfterScenario()]
        public static void AfterScenario()
        {
            if (ScenarioContext.Current.TestError != null)
            {
                extentTest.Log(Status.Fail, ScenarioContext.Current.TestError.InnerException);
            }
            else
            {
                extentTest.Log(Status.Pass, "Pass");
            }

        }

        [BeforeScenarioBlock()]
        public static void BeforeScenarioBlock()
        {
            
        }

        [AfterScenarioBlock()]
        public static void AfterScenarioBlock()
        {
           
        }

       

        [AfterStep]
        public static void AfterStep()
        {
         
            // steps
            extentTest.CreateNode(ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString(),
                ScenarioStepContext.Current.StepInfo.Text);

          
           
        }
    }
}
