namespace ComputerLoger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGenerateLog = new System.Windows.Forms.Button();
            this.btnSeeLog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerateLog
            // 
            this.btnGenerateLog.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerateLog.Location = new System.Drawing.Point(12, 12);
            this.btnGenerateLog.Name = "btnGenerateLog";
            this.btnGenerateLog.Size = new System.Drawing.Size(280, 35);
            this.btnGenerateLog.TabIndex = 0;
            this.btnGenerateLog.Text = "Gerar Log.txt";
            this.btnGenerateLog.UseVisualStyleBackColor = true;
            this.btnGenerateLog.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSeeLog
            // 
            this.btnSeeLog.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSeeLog.Location = new System.Drawing.Point(12, 62);
            this.btnSeeLog.Name = "btnSeeLog";
            this.btnSeeLog.Size = new System.Drawing.Size(280, 35);
            this.btnSeeLog.TabIndex = 1;
            this.btnSeeLog.Text = "Ver Log";
            this.btnSeeLog.UseVisualStyleBackColor = true;
            this.btnSeeLog.Click += new System.EventHandler(this.btnSeeLog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Criado por Luan Roger";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(304, 134);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSeeLog);
            this.Controls.Add(this.btnGenerateLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer Loger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateLog;
        private System.Windows.Forms.Button btnSeeLog;
        private System.Windows.Forms.Label label1;
    }
}

