using System.Management;

    public class ProcessorInfo
    {
        ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
        private string processorName { get; set; }
        private string processorManufacturer { get; set; }
        private string speedClock { get; set; }
        private string coresNunber { get; set; }
        private string processorTitle { get; set; }
        
        public string SeeProcessorInfo()
        {
        string processorString = null;

            foreach(ManagementObject processorObject in managementObjectSearcher.Get())
            {
                processorName = processorObject["Name"].ToString();
                processorManufacturer = processorObject["Manufacturer"].ToString();
                speedClock = processorObject["CurrentClockSpeed"].ToString();
                coresNunber = processorObject["NumberOfCores"].ToString();
                processorTitle = processorObject["Caption"].ToString();

            processorString = $"Nome: {processorName}\nFabricante: {processorManufacturer}\n" +
                $"Velocidade do Clock: {speedClock}\nNúmero de Núcleos: {coresNunber}\n" +
                $"Titulo do Prcessador: {processorTitle}";
            }

            return processorString;
        }

    }
