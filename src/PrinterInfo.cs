using System.Management;

namespace ComputerLoger
{
    class PrinterInfo
    {
        private ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_Printer");
        private string printerName { get; set; }
        private string printerNetwork { get; set; }
        private string printerDefault { get; set; }
        private string printerId { get; set; }
        private string printerStatus { get; set; }

        public string SeePrinterInfo()
        {
            string printerString = null;

            foreach(ManagementObject printerObject in managementObjectSearcher.Get())
            {
                printerName = printerObject["Name"].ToString();
                printerNetwork = (printerObject["Network"].ToString() == "False") ? "Não" : "Sim";
                printerDefault = (printerObject["Default"].ToString() == "False") ? "Não" : "Sim";
                printerId = printerObject["DeviceId"].ToString();
                printerStatus = printerObject["Status"].ToString();

                printerString = $"Nome: {printerName}\nConexão com a internet: {printerNetwork}\n" +
                    $"Padrão: {printerDefault}\nId: {printerId}\nStatus: {printerStatus}";
            }

            return printerString;
        }
    }
}
