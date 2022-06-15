using Stylet;
using System;
using System.IO;
using System.Text.Json;
using WarpPointManager.Models;

namespace WarpPointManager.ViewModels
{
    public class SettingsViewModel : Screen
    {
        private string _baseDump = "";
        public string BaseDump {
            get => _baseDump;
            set => SetAndNotify(ref _baseDump, value);
        }

        private string _updateDump = "";
        public string UpdateDump {
            get => _updateDump;
            set => SetAndNotify(ref _updateDump, value);
        }

        private string _dlcDump = "";
        public string DlcDump {
            get => _dlcDump;
            set => SetAndNotify(ref _dlcDump, value);
        }

        public void Browse(string mode)
        {
            System.Windows.Forms.FolderBrowserDialog openFld = new();
            
            if (openFld.ShowDialog() == System.Windows.Forms.DialogResult.OK) {

                // Base
                if (mode == "base") {
                    BaseDump = openFld.SelectedPath;
                }

                // Update
                if (mode == "update") {
                    UpdateDump = openFld.SelectedPath;
                }

                // DLC
                if (mode == "dlc") {
                    DlcDump = openFld.SelectedPath;
                }
            }
        }

        public void Save()
        {
            string path = $"{Environment.GetEnvironmentVariable("LOCALAPPDATA")}\\WarpPointManager";

            Directory.CreateDirectory(path);
            File.WriteAllText($"{path}\\config.json", JsonSerializer.Serialize(new SettingsModel(this)));

            WindowManager.Show("Settings saved succefully.");
        }

        private IWindowManager? WindowManager { get; set; }
        public SettingsViewModel(IWindowManager? windowManager)
        {
            WindowManager = windowManager;
        }
    }
}
