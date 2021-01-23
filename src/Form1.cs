using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerLoger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnGenerateLog_CLick(object sender, EventArgs e)
        { 
            FolderBrowserDialog logDir = new FolderBrowserDialog();
            DialogResult dirResult = logDir.ShowDialog();

            if(logDir.SelectedPath == "" || dirResult == DialogResult.Cancel || dirResult == DialogResult.Abort) return;
            SaveLog saveLog = new SaveLog();
            saveLog.GenerateLog(logDir.SelectedPath);
        }

        private async void btnSeeLog_Click(object sender, EventArgs e)
        {
            //Sistema Operacional
            OsInfo osInfo = new OsInfo();
            string infoOsString = await Task.Run(() => osInfo.SeeOsInfo());
            string logOsString = "===Sistema Operacional========================\n" + 
                                 $"{infoOsString}\n";

            pgbSeeLog.Value = 16;

            //Processador
            ProcessorInfo processorInfo = new ProcessorInfo();
            string infoProcessorString = await Task.Run(() => processorInfo.SeeProcessorInfo());
            string logProcessorString = "\n===Processador=============================\n" + 
                                        $"{infoProcessorString}\n";
            
            pgbSeeLog.Value = 32;

            //GPU
            GpuInfo gpuInfo = new GpuInfo();
            string infoGpu = await Task.Run(() => gpuInfo.SeeGpuInfo());
            string logGpuString = "\n===GPU==================================\n" + 
                                  $"{infoGpu}\n";

            pgbSeeLog.Value = 48;
            
            //Sound Device
            SoundInfo soundInfo = new SoundInfo();
            string infoSound = await Task.Run(() => soundInfo.SeeSoundDevice());
            string logSoundString = "\n===Dispositivo de Som========================\n" + 
                                    $"{infoSound}\n";
            
            pgbSeeLog.Value = 64;

            //Printers
            PrinterInfo printerInfo = new PrinterInfo();
            string infoPrinter = await Task.Run(() => printerInfo.SeePrinterInfo());
            string logPrinterString = "\n===Impressoras========================\n" + 
                                      $"{infoPrinter}\n";

            pgbSeeLog.Value = 80;

            //RAM
            RamInfo ramInfo = new RamInfo();
            string infoRam = await Task.Run(() => ramInfo.SeeRam());
            string logRamString = "\n===RAM==================================\n" + 
                                  $"{infoRam}";
            
            pgbSeeLog.Value = 100;
            
            MessageBox.Show(logOsString + logProcessorString + logGpuString + logSoundString + logPrinterString + logRamString, "Informações", MessageBoxButtons.OK);

            pgbSeeLog.Value = 0;
        }
    }
}
