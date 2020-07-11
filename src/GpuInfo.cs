using System.Management;

namespace ComputerLoger
{
    class GpuInfo
    {
        private ManagementObjectSearcher gpuObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
        private string gpuName { get; set; }
        private string gpuStatus { get; set; }
        private string gpuTitle { get; set; }
        private string gpuDisplayDrive { get; set; }
        private string gpuDriveVersion { get; set; }
        private string gpuVideoProcessor { get; set; }

        public string SeeGpuInfo()
        {
            string gpuString = null;

            foreach (ManagementObject gpuObject in gpuObjectSearcher.Get())
            {
                gpuName = gpuObject["Name"].ToString();
                gpuStatus = gpuObject["Status"].ToString();
                gpuTitle = gpuObject["Caption"].ToString();
                gpuDisplayDrive = gpuObject["InstalledDisplayDrivers"].ToString();
                gpuDriveVersion = gpuObject["DriverVersion"].ToString();
                gpuVideoProcessor = gpuObject["VideoProcessor"].ToString();

                gpuString = $"Nome: {gpuName}\nStatus: {gpuStatus}\nTitulo: {gpuTitle}\nDrive de vídeo: {gpuDisplayDrive}\n" +
                    $"Versão do drive: {gpuDriveVersion}\nProcessador de vídeo: {gpuVideoProcessor}";
            }

            return gpuString;
        }
    }
}

