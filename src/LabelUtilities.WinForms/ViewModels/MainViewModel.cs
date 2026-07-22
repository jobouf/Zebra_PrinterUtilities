using CommunityToolkit.Mvvm.ComponentModel;

namespace LabelUtilities.WinForms.ViewModels
{
    internal partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        public partial string? LabelSKU { get; set; }
    }
}
