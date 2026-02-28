using Zebra.Sdk.Comm;
using Zebra.Sdk.Device;
using Zebra.Sdk.Printer;
using Zebra.Sdk.Printer.Discovery;
using Zebra_LabelProfile.Models;
using Zebra_LabelProfile.Services;

namespace Zebra_LabelProfile
{
    public partial class MainView : Form
    {
        private readonly ISGDCommandListService _sgdCommandListService;
        public MainView(ISGDCommandListService sgdCommandListService)
        {
            _sgdCommandListService = sgdCommandListService;

            InitializeComponent();
            RefreshPrinters();
        }
        private void RefreshPrinters()
        {
            
        private async Task GetSensorProfileAsync(DiscoveredUsbPrinterCarrier DiscoveredUsbPrinterCarrier)
            {
            _sgdCommandListService.InitDefaultCommandList();

            Progress<int> progress = new Progress<int>();
            progress.ProgressChanged += (p, value) => toolStripProgressBarSensorProfile.Value = value;
            toolStripProgressBarSensorProfile.Maximum = _sgdCommandListService.ListLength;
           
            Connection USBConnection = DiscoveredUsbPrinterCarrier.DiscoveredUsbPrinter.GetConnection();
            USBConnection.Open();

            List<ISGDCommand> QueryResults = await Task.Run(() => _sgdCommandListService.ExecuteCommandList(USBConnection, progress));
            USBConnection.Close();
        }

        // Standard designer event functions
        private void toolStripButtonDiscoverPrinters_Click(object sender, EventArgs e)
        {
            RefreshPrinters();
        }

        private void toolStripButtonStartProfile_Click(object sender, EventArgs e)
        {
            GetSensorProfileAsync((DiscoveredUsbPrinterCarrier)toolStripComboBoxPrinterList.SelectedItem);
        }
    }
}
