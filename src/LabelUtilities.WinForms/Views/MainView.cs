using LabelUtilities.WinForms.ViewModels;

namespace LabelUtilities.WinForms.Views
{
    public partial class MainView : Form
    {
        private readonly MainViewModel _mainViewModel;
        public MainView(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
            InitializeComponent();
            InitializeBindings();
        }

        private void InitializeBindings()
        {
            this.DataContext = _mainViewModel;

            mainProgressToolStripProgressBar.DataBindings.Add("Value", this.DataContext, "ProgressBarProgress", true, DataSourceUpdateMode.OnPropertyChanged);
            mainStatusToolStripStatusLabel.DataBindings.Add("Text", this.DataContext, "ProgressBarText", true, DataSourceUpdateMode.OnPropertyChanged);

            newToolStripMenuItem.Click += (s, e) => _mainViewModel.MenuNewCommand.Execute(null);
            openToolStripMenuItem.Click += (s, e) => _mainViewModel.MenuOpenCommand.Execute(null);
            saveToolStripMenuItem.Click += (s, e) => _mainViewModel.MenuSaveCommand.Execute(null);
            saveAsToolStripMenuItem.Click += (s, e) => _mainViewModel.MenuSaveAsCommand.Execute(null);
            printToolStripMenuItem.Click += (s, e) => _mainViewModel.MenuPrintCommand.Execute(null);

            discoverPrintersToolStripButton.Click += (s, e) => _mainViewModel.ToolbarDiscoverCommand.Execute(null);
        }
    }
}
