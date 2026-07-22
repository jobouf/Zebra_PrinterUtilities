using System.ComponentModel;
using Zebra.Sdk.Comm;
using Zebra.Sdk.Printer.Discovery;
using LabelUtilities.Core.Helpers;
using LabelUtilities.Core.Models;
using LabelUtilities.Core.Services;

namespace LabelUtilities.WinForms.Views
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
            printerlistToolStripComboBox.ComboBox.DataSource = UsbDiscoverer.GetZebraUsbPrinters().Select(p => new DiscoveredUsbPrinterCarrier { DiscoveredUsbPrinter = p }).ToList();
            printerlistToolStripComboBox.ComboBox.DisplayMember = "FriendlyName";
            printerlistToolStripComboBox.ComboBox.ValueMember = "DiscoveredUsbPrinter";
        }

        private async Task GetSensorProfileAsync(DiscoveredUsbPrinterCarrier DiscoveredUsbPrinterCarrier)
        {
            _sgdCommandListService.InitDefaultCommandList();

            Progress<int> progress = new Progress<int>();
            progress.ProgressChanged += (p, value) => mainToolStripProgressBar.Value = value;
            mainToolStripProgressBar.Maximum = _sgdCommandListService.ListLength;

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
            GetSensorProfileAsync((DiscoveredUsbPrinterCarrier)printerlistToolStripComboBox.SelectedItem);
        }
    }
}
