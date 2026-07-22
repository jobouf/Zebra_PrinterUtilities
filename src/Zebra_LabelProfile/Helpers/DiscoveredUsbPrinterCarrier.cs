using Zebra.Sdk.Printer.Discovery;

namespace Zebra_LabelProfile.Helpers
{
    internal class DiscoveredUsbPrinterCarrier
    {
        public DiscoveredUsbPrinter DiscoveredUsbPrinter { get; set; }
        public string Model { get { return DiscoveredUsbPrinter.DiscoveryDataMap["MODEL"]; } }
        public string Serial { get { return DiscoveredUsbPrinter.DiscoveryDataMap["SERIAL_NUMBER"]; } }
        public string FriendlyName { get { return Model + " - " + Serial; } }
    }
}
