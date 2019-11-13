using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace BuyPlan.Automation.Framework.Config
{
    public class ConfigReader
    {

        public static void SetFrameworkSettings()
        {
            XPathItem autplanner;
            XPathItem autkas;
            XPathItem testtype;
            XPathItem islog;
            XPathItem isreport;
            XPathItem buildname;
            //XPathItem logPath;

            string strFileName = Environment.CurrentDirectory.ToString() + "\\Config\\GlobalConfig.xml";
            FileStream stream = new FileStream(strFileName, FileMode.Open);
            XPathDocument document = new XPathDocument(stream);
            XPathNavigator navigator = document.CreateNavigator();

            //Get XML Details and pass it in XPathItem type variables
            autplanner = navigator.SelectSingleNode("EAAutoFramework/RunSettings/AUTPlanner");
            autkas = navigator.SelectSingleNode("EAAutoFramework/RunSettings/AUTKas");
            buildname = navigator.SelectSingleNode("EAAutoFramework/RunSettings/BuildName");
            testtype = navigator.SelectSingleNode("EAAutoFramework/RunSettings/TestType");
            islog = navigator.SelectSingleNode("EAAutoFramework/RunSettings/IsLog");
            isreport = navigator.SelectSingleNode("EAAutoFramework/RunSettings/IsReport");
           // logPath = navigator.SelectSingleNode("EAAutoFramework/RunSettings/LogPath");


            //Set XML Details in the property to be used accross framework
            AppSettings.AUTPlanner = autplanner.Value.ToString();
            AppSettings.AUTKas = autkas.Value.ToString();
            AppSettings.BuildName = buildname.Value.ToString();
            AppSettings.TestType = testtype.Value.ToString();
            AppSettings.IsLog = islog.Value.ToString();
            AppSettings.IsReporting = isreport.Value.ToString();
            //AppSettings.LogPath = logPath.Value.ToString();
        }
    }
}
