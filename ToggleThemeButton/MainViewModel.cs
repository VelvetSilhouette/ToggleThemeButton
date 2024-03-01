using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ToggleThemeButton
{
    public class MainViewModel : ObservableObject
    {
        private bool _isChecked;
        public bool IsChecked { get => _isChecked; set { _isChecked = value; OnPropertyChanged(); ChangeBackground(); } }

        private Brush? _background;
        public Brush Background { get => _background; set { _background = value; OnPropertyChanged(); } }

        public MainViewModel() { }

        private void ChangeBackground()
        {
            Background = IsChecked
                ? (Brush)new BrushConverter().ConvertFrom("#000000")
                : (Brush)new BrushConverter().ConvertFrom("#ffffff");
        }
    }
}
