using System.IO;
using System.Windows.Forms;

    class SaveLog
    {
        private string dirName { get; set; }
        private string logName { get; set; } = @"\System_Log.txt";
        private StreamWriter log { get; set; }
        
        public void GenerateLog(string dirName)
        {
            try
            {
                log = File.CreateText(dirName + logName);
            }
            catch
            {
                MessageBox.Show("Insira um caminho válido");
                return;
            }

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

            log.Write(logOsString + logProcessorString + logGpuString);
            log.Close();

        MessageBox.Show("Arquivo gerado com sucesos.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
