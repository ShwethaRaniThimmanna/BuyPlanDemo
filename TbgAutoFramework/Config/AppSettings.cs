using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Tbg.Automation.Framework.Base;
using Tbg.Automation.Framework.Config;

namespace Tbg.Automation.Framework.Config
{
    public class AppSettings
    {
        public int Timeout { get; set; }

        public string IsReporting { get; set; }

        public string TestType { get; set; }

        public string AUT { get; set; }

        public string BuildName { get; set; }

        public BrowserType BrowserType { get; set; }

        public string DbConnectionString { get; set; }

        public string AppConnectionString { get; set; }

        public string IsLog { get; set; }

        public string LogPath { get; set; }
    }
}


