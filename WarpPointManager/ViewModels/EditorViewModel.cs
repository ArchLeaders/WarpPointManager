using Stylet;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarpPointManager.ViewModels
{
    public class EditorViewModel : Screen
    {

        private string _name = "NewWarpPoint";
        public string Name {
            get => _name;
            set => SetAndNotify(ref _name, value);
        }

        private string _icon = "Shrine";
        public string Icon {
            get => _icon;
            set => SetAndNotify(ref _icon, value);
        }

        private Bitmap _iconImage;
        public Bitmap IconImage {
            get => _iconImage;
            set => SetAndNotify(ref _iconImage, value);
        }

        private string _title = "New Warp Point";
        public string Title {
            get => _title;
            set => SetAndNotify(ref _title, value);
        }

        private string _saveFlag = "Location_Dungeon118";
        public string SaveFlag {
            get => _saveFlag;
            set => SetAndNotify(ref _saveFlag, value);
        }

        private string _field = "MainField";
        public string Field {
            get => _field;
            set => SetAndNotify(ref _field, value);
        }

        private BindableCollection<KeyValuePair<string, double>> _location = new() {
            new("X", 0.0),
            new("Y", 0.0),
            new("Z", 0.0),
        };
        public BindableCollection<KeyValuePair<string, double>> Location {
            get => _location;
            set => SetAndNotify(ref _location, value);
        }

        private BindableCollection<KeyValuePair<string, double>> _rotation = new() {
            new("X", 0.0),
            new("Y", 0.0),
            new("Z", 0.0),
        };
        public BindableCollection<KeyValuePair<string, double>> Rotation {
            get => _rotation;
            set => SetAndNotify(ref _rotation, value);
        }

        public ShellViewModel ShellViewModel { get; set; }
        public EditorViewModel(ShellViewModel svm)
        {
            ShellViewModel = svm;
        }
    }
}
