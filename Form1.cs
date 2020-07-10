using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        public FolderBrowserDialog logDir = new FolderBrowserDialog();
        private void button1_Click(object sender, EventArgs e)
        {
            logDir.ShowDialog();
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
                $"{gpuInfo.SeeGpuInfo()}";

            MessageBox.Show(logOsString + logProcessorString + logGpuString, "Informações", MessageBoxButtons.OK);
        }
    }
}
