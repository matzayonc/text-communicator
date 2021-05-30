namespace Hare_n_Noisy
{
    partial class Main
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbConf = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.ListBox();
            this.rtWrite = new System.Windows.Forms.RichTextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.nPort = new System.Windows.Forms.NumericUpDown();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.btConnect = new System.Windows.Forms.Button();
            this.bwConnect = new System.ComponentModel.BackgroundWorker();
            this.bwMessage = new System.ComponentModel.BackgroundWorker();
            this.lbMessages = new System.Windows.Forms.ListBox();
            this.bwStart = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.nPort)).BeginInit();
            this.SuspendLayout();
            // 
            // lbConf
            // 
            this.lbConf.AutoSize = true;
            this.lbConf.Location = new System.Drawing.Point(12, 19);
            this.lbConf.Name = "lbConf";
            this.lbConf.Size = new System.Drawing.Size(109, 13);
            this.lbConf.TabIndex = 0;
            this.lbConf.Text = "Konfiguracja serwera:";
            // 
            // lbStatus
            // 
            this.lbStatus.FormattingEnabled = true;
            this.lbStatus.Location = new System.Drawing.Point(12, 55);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(397, 56);
            this.lbStatus.TabIndex = 1;
            // 
            // rtWrite
            // 
            this.rtWrite.Location = new System.Drawing.Point(12, 371);
            this.rtWrite.Name = "rtWrite";
            this.rtWrite.Size = new System.Drawing.Size(397, 67);
            this.rtWrite.TabIndex = 4;
            this.rtWrite.Text = "";
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(342, 334);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(67, 27);
            this.btSend.TabIndex = 5;
            this.btSend.Text = "Wyślij";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // nPort
            // 
            this.nPort.Location = new System.Drawing.Point(251, 17);
            this.nPort.Name = "nPort";
            this.nPort.Size = new System.Drawing.Size(68, 20);
            this.nPort.TabIndex = 6;
            this.nPort.Value = new decimal(new int[] {
            69,
            0,
            0,
            0});
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(145, 16);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(100, 20);
            this.tbIP.TabIndex = 7;
            this.tbIP.Text = "127.0.0.1";
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(334, 14);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(75, 23);
            this.btConnect.TabIndex = 8;
            this.btConnect.Text = "Start";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // bwConnect
            // 
            this.bwConnect.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwConnect_DoWork);
            // 
            // bwMessage
            // 
            this.bwMessage.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwMessage_DoWork);
            // 
            // lbMessages
            // 
            this.lbMessages.FormattingEnabled = true;
            this.lbMessages.Location = new System.Drawing.Point(12, 117);
            this.lbMessages.Name = "lbMessages";
            this.lbMessages.Size = new System.Drawing.Size(397, 199);
            this.lbMessages.TabIndex = 9;
            // 
            // bwStart
            // 
            this.bwStart.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwStart_DoWork);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 450);
            this.Controls.Add(this.lbMessages);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.nPort);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.rtWrite);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbConf);
            this.Name = "Main";
            this.Text = "Hare\'n\'Noisy Serwer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbConf;
        private System.Windows.Forms.ListBox lbStatus;
        private System.Windows.Forms.RichTextBox rtWrite;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.NumericUpDown nPort;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Button btConnect;
        private System.ComponentModel.BackgroundWorker bwConnect;
        private System.ComponentModel.BackgroundWorker bwMessage;
        private System.Windows.Forms.ListBox lbMessages;
        private System.ComponentModel.BackgroundWorker bwStart;
    }
}

