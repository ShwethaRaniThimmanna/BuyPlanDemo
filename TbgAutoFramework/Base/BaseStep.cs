using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tbg.Automation.Framework.Config;
using Tbg.Automation.Framework.Extensions;

namespace Tbg.Automation.Framework.Base
{
    public abstract class BaseStep:Base
    {
        public virtual void NavigateSite()
        {
            DriverContext.Browser.GoToUrl(Settings.AppSettings.AUT);
            DriverContext.Driver.WaitForPageLoaded();
        }

    }
}
