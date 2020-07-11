using System.Management;

namespace ComputerLoger
{
    class SoundInfo
    {
        ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_SoundDevice");
        private string soundName { get; set; }
        private string soundId { get; set; }
        private string soundDeviceStatus { get; set; }

        public string SeeSoundDevice()
        {
            string soundString = null;

            foreach (ManagementObject soundObject in managementObjectSearcher.Get())
            {
                soundName = soundObject["Name"].ToString();
                soundId = soundObject["DeviceID"].ToString();
                soundDeviceStatus = soundObject["Status"].ToString();

                soundString = $"Nome: {soundName}\nID: {soundId}\nStatus: {soundDeviceStatus}";
            }

            return soundString;
        }
    }
}
