using Zebra.Sdk.Comm;
using Zebra.Sdk.Device;
using Zebra.Sdk.Printer;
using Zebra.Sdk.Printer.Discovery;

namespace Zebra_LabelProfile
{
    public partial class MainView : Form
    {
        List<DiscoveredUsbPrinter>? discoveredUsbPrinterList;
        List<SGDQuery> SGDQueryList = new();

        public MainView()
        {
            InitializeComponent();
            RefreshPrinters();
            InitializeSGDQueries();
        }

        public class SGDQuery
        {
            public string Command { get; set; }
            public string? Result { get; set; }
        }

        private void InitializeSGDQueries()
        {

            if (SGDQueryList != null) SGDQueryList.Clear();
            SGDQueryList.AddRange(
                (new SGDQuery{Command = "device.unique_id"}),
                (new SGDQuery{Command = "device.sensor_profile"}),
                (new SGDQuery{Command = "device.sensor_select" }),
                (new SGDQuery{Command = "sensor.gap.thold" }),
                (new SGDQuery{Command = "sensor.gap.offset" }),
                (new SGDQuery{Command = "sensor.gap.gain" }),
                (new SGDQuery{Command = "sensor.gap.brightness" }),
                (new SGDQuery{Command = "sensor.gap.curr" }),
                (new SGDQuery{Command = "sensor.front_gap.thold" }),
                (new SGDQuery{Command = "sensor.front_gap.offset" }),
                (new SGDQuery{Command = "sensor.front_gap.gain" }),
                (new SGDQuery{Command = "sensor.front_gap.brightness" }),
                (new SGDQuery{Command = "sensor.front_gap.curr" }),
                (new SGDQuery{Command = "sensor.front_gap.ppr_out_thold" })
                );
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

            for (int i = 0; i < SGDQueryList.Count; i++)
            {
                SGDQueryList[i].Result = SGD.GET(SGDQueryList[i].Command, USBConnection);
            }
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
