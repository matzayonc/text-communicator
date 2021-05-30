namespace TCP_Client
{
    partial class Form1
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
            this.Address = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.Port = new System.Windows.Forms.Label();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.lbClient = new System.Windows.Forms.ListBox();
            this.btConnect = new System.Windows.Forms.Button();
            this.bw = new System.ComponentModel.BackgroundWorker();
            this.message = new System.Windows.Forms.RichTextBox();
            this.send = new System.Windows.Forms.Button();
            this.bs = new System.ComponentModel.BackgroundWorker();
            this.lv = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.SuspendLayout();
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(34, 130);
            this.Address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(60, 17);
            this.Address.TabIndex = 0;
            this.Address.Text = "Address";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(113, 126);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(165, 22);
            this.tbAddress.TabIndex = 1;
            this.tbAddress.Text = "127.0.0.1";
            this.tbAddress.TextChanged += new System.EventHandler(this.tbAddress_TextChanged);
            // 
            // Port
            // 
            this.Port.AutoSize = true;
            this.Port.Location = new System.Drawing.Point(286, 126);
            this.Port.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(34, 17);
            this.Port.TabIndex = 2;
            this.Port.Text = "Port";
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(328, 127);
            this.numPort.Margin = new System.Windows.Forms.Padding(4);
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(115, 22);
            this.numPort.TabIndex = 4;
            this.numPort.Value = new decimal(new int[] {
            69,
            0,
            0,
            0});
            this.numPort.ValueChanged += new System.EventHandler(this.numPort_ValueChanged);
            // 
            // lbClient
            // 
            this.lbClient.FormattingEnabled = true;
            this.lbClient.ItemHeight = 16;
            this.lbClient.Location = new System.Drawing.Point(37, 13);
            this.lbClient.Margin = new System.Windows.Forms.Padding(4);
            this.lbClient.Name = "lbClient";
            this.lbClient.Size = new System.Drawing.Size(527, 84);
            this.lbClient.TabIndex = 5;
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(464, 127);
            this.btConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(110, 22);
            this.btConnect.TabIndex = 6;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // bw
            // 
            this.bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_DoWork);
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(37, 497);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(527, 154);
            this.message.TabIndex = 8;
            this.message.Text = "";
            this.message.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(259, 671);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 28);
            this.send.TabIndex = 9;
            this.send.Text = "SEND";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // bs
            // 
            this.bs.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bs_DoWork);
            // 
            // lv
            // 
            this.lv.Location = new System.Drawing.Point(37, 168);
            this.lv.MinimumSize = new System.Drawing.Size(20, 20);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(527, 296);
            this.lv.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 723);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.send);
            this.Controls.Add(this.message);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.lbClient);
            this.Controls.Add(this.numPort);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.Address);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "z";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label Port;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.ListBox lbClient;
        private System.Windows.Forms.Button btConnect;
        private System.ComponentModel.BackgroundWorker bw;
        private System.Windows.Forms.RichTextBox message;
        private System.Windows.Forms.Button send;
        private System.ComponentModel.BackgroundWorker bs;
        private System.Windows.Forms.WebBrowser lv;
    }
}

