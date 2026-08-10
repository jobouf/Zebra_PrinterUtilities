using System.Collections.ObjectModel;
using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LibUsbDotNet.LibUsb;
using LibUsbDotNet.Main;

namespace LabelUtilities.WinForms.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {

        private List<IUsbDevice>? _usbCollection; 

        [ObservableProperty]
        public partial int? ProgressBarProgress { get; set; }

        [ObservableProperty]
        public partial string? ProgressBarText { get; set; }

        public MainViewModel()
        {

        }

        [RelayCommand]
        private void MenuNew()
        {

        }

        [RelayCommand]
        private void MenuOpen()
        {

        }

        [RelayCommand]
        private void MenuSave()
        {

        }

        [RelayCommand]
        private void MenuSaveAs()
        {

        }

        [RelayCommand]
        private void MenuPrint()
        {

        }

        [RelayCommand]
        private void ToolbarDiscover()
        {

        }

    }
}
