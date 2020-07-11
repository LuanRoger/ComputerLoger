using System.Management;
using System;
using ByteSizeLib;

namespace ComputerLoger
{
    class RamInfo
    {
        private ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
        private string totalRam { get; set; }
        private string freeRam { get; set; }

        public string SeeRam()
        {
            string ramString = null;

            foreach(ManagementObject ramObject in managementObjectSearcher.Get())
            {
                totalRam = ByteSize.FromKiloBytes(Convert.ToDouble(ramObject["TotalVisibleMemorySize"])).GigaBytes.ToString("N1") + " GB";
                freeRam = ByteSize.FromKiloBytes(Convert.ToDouble(ramObject["FreePhysicalMemory"])).GigaBytes.ToString("N1") + " GB";

                ramString = $"Memória RAM total: {totalRam}\nMemória RAM livre: {freeRam}";
            }

            return ramString;
        }
    }
}
