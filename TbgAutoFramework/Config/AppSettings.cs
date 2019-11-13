using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using BuyPlan.Automation.Framework.Base;
using BuyPlan.Automation.Framework.Config;

namespace BuyPlan.Automation.Framework.Config
{
    public class AppSettings
    {
        public static int Timeout { get; set; }

        public static string IsReporting { get; set; }

        public static string TestType { get; set; }

        public string AUT { get; set; }

        public static string BuildName { get; set; }

        public static BrowserType BrowserType { get; set; }

        public string DbConnectionString { get; set; }

        public string AppConnectionString { get; set; }

        public static string IsLog { get; set; }

        public static string LogPath { get; set; }

        public static string AUTPlanner { get; set; }

        public static string ProductSummaryUrl { get; set; }

        public static string AUTKas { get; set; }
    }
}


