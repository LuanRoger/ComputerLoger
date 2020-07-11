using System.IO;
using System.Windows.Forms;
using ComputerLoger;

namespace ComputerLoger {
    class SaveLog
    {
        private string dirName { get; set; }
        private string logName { get; set; } = @"\System_Log.txt";
        private StreamWriter log { get; set; }

        public void GenerateLog(string dirName)
        {
            log = File.CreateText(dirName + logName);

            //Sistema Operacional
            OsInfo osInfo = new OsInfo();
            string logOsString = "===Sistema Operacional========================\n" +
                $"{osInfo.SeeOsInfo()}\n";

            //Processador
            ProcessorInfo processorInfo = new ProcessorInfo();
            string logProcessorString = "\n===Processador=============================\n" +
                $"{processorInfo.SeeProcessorInfo()}\n";

            //GPU
            GpuInfo gpuInfo = new GpuInfo();
            string logGpuString = "\n===GPU==================================\n" +
                $"{gpuInfo.SeeGpuInfo()}";

            //Sound Device
            SoundInfo soundInfo = new SoundInfo();
            string logSoundString = "\n===Dispositivo de Som========================\n" +
                $"{soundInfo.SeeSoundDevice()}\n";

            //Printers
            PrinterInfo printerInfo = new PrinterInfo();
            string logPrinterString = "\n===Impressoras========================\n" +
                $"{printerInfo.SeePrinterInfo()}\n";

            //RAM
            RamInfo ramInfo = new RamInfo();
            string logRamString = "\n===RAM==================================\n" +
                $"{ramInfo.SeeRam()}";

            log.Write(logOsString + logProcessorString + logGpuString + logSoundString + logPrinterString + logRamString);
            log.Close();

            MessageBox.Show($"Arquivo gerado com sucesos em {dirName}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
