using Zebra.Sdk.Comm;
using Zebra.Sdk.Device;
using Zebra.Sdk.Printer;
using Zebra.Sdk.Printer.Discovery;
using Zebra_LabelProfile.Services;

namespace Zebra_LabelProfile
{
    public partial class MainView : Form
    {
        
        List<DiscoveredUsbPrinter>? discoveredUsbPrinterList;
        private readonly IMassSGDQueryService _massSGDQueryService;
        public MainView(IMassSGDQueryService massSGDQueryService)
        {
            _massSGDQueryService = massSGDQueryService;

            InitializeComponent();
            RefreshPrinters();
        }
        private void RefreshPrinters()
        {
            
            try
            {
                discoveredUsbPrinterList = UsbDiscoverer.GetZebraUsbPrinters();
            }
            catch (ConnectionException e)
            {
                Console.WriteLine($"Error discovering local printers: {e.Message}");
            }
            toolStripComboBoxPrinterList.ComboBox.DataSource = discoveredUsbPrinterList;
            toolStripComboBoxPrinterList.ComboBox.DisplayMember = "Address";
        }

        private void GetSensorProfile(DiscoveredUsbPrinter discoveredUsbPrinter)
        {
            Connection USBConnection = discoveredUsbPrinter.GetConnection();
            USBConnection.Open();
            _massSGDQueryService.InitializeQueryList(USBConnection);
        }

        // Standard designer event functions
        private void toolStripButtonDiscoverPrinters_Click(object sender, EventArgs e)
        {
            RefreshPrinters();
        }

        private void toolStripButtonStartProfile_Click(object sender, EventArgs e)
        {

           var test = toolStripComboBoxPrinterList.SelectedItem;
            GetSensorProfile((DiscoveredUsbPrinter)toolStripComboBoxPrinterList.SelectedItem);
        }
    }
}
