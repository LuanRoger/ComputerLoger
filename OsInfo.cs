using System.Management;

public class OsInfo
{
    ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
    private string osName { get; set; }
    private string osVersion { get; set; }
    private string osSerial { get; set; }

    public string SeeOsInfo()
    {
        string osString = null;

        foreach (ManagementObject OsObject in managementObjectSearcher.Get())
        {
            osName = OsObject["Caption"].ToString();
            osVersion = OsObject["Version"].ToString();
            osSerial = OsObject["SerialNumber"].ToString();


            osString = $"Nome: {osName}\nVersão do sistema: {osVersion}\n" +
                $"Número do Serial: {osSerial}";
        }

        return osString;
    }
}
