using WarpPointManager.ViewModels;

namespace WarpPointManager.Models
{
    public class SettingsModel
    {
        public string BaseDump { get; set; }
        public string UpdateDump { get; set; }
        public string DlcDump { get; set; }

        public SettingsModel(SettingsViewModel svm)
        {
            BaseDump = svm.BaseDump;
            UpdateDump = svm.UpdateDump;
            DlcDump = svm.DlcDump;
        }
    }
}
