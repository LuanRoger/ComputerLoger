using System;
using System.Windows.Forms;

namespace ComputerLoger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public FolderBrowserDialog logDir = new FolderBrowserDialog();
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dirResult = logDir.ShowDialog();

            if(logDir.SelectedPath == "" || dirResult == DialogResult.Cancel || dirResult == DialogResult.Abort) { return; }
            SaveLog saveLog = new SaveLog();
            saveLog.GenerateLog(logDir.SelectedPath);
        }

        private void btnSeeLog_Click(object sender, EventArgs e)
        {
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
                $"{gpuInfo.SeeGpuInfo()}\n";

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

            MessageBox.Show(logOsString + logProcessorString + logGpuString + logSoundString + logPrinterString + logRamString, "Informações", MessageBoxButtons.OK);
        }
    }
}
