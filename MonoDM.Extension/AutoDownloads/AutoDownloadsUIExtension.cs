using System;
using System.Collections.Generic;
using System.Text;
using MonoDM.Core.Extensions;
using System.Windows.Forms;
using MonoDM.Core.Common;
using MonoDM.Extension.AutoDownloads.UI;

namespace MonoDM.Extension.AutoDownloads
{
    public class AutoDownloadsUIExtension: IUIExtension
    {
        #region IUIExtension Members

        public BaseWidget[] CreateSettingsView()
        {
            return new BaseWidget[] { new Jobs() };
        }

        public void PersistSettings(BaseWidget[] settingsView)
        {
            Jobs jobs = (Jobs)settingsView[0];

            Settings.Default.MaxJobs = jobs.MaxJobs;
            Settings.Default.WorkOnlyOnSpecifiedTimes = jobs.WorkOnlyOnSpecifiedTimes;
            Settings.Default.TimesToWork = jobs.TimesToWork;
            Settings.Default.MaxRateOnTime = jobs.MaxRate;
            Settings.Default.AutoStart = jobs.AutoStart;
            Settings.Default.Save();
        }

        #endregion
    }
}
