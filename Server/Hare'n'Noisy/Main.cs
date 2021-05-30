using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Hare_n_Noisy
{
    public partial class Main : Form
    {
        private TcpClient client;
        private StreamReader reading = null;
        private StreamWriter writing = null;
        public string recieve;
        public string TextToSend;


        public Main()
        {
            InitializeComponent();
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            lbStatus.Items.Add("Serwer wystartował");
            bwStart.RunWorkerAsync();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            TextToSend = rtWrite.Text;
            bwMessage.RunWorkerAsync();
            rtWrite.Text = "";
        }



        private void bwConnect_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    recieve = reading.ReadLine();
                    this.lbMessages.Invoke(new MethodInvoker(delegate () { lbMessages.Items.Add("Client: " + recieve); }));
                }
                catch (Exception except)
                {
                    MessageBox.Show(except.Message.ToString());
                }
            }
        }


        private void bwMessage_DoWork(object sender, DoWorkEventArgs e)
        {
            if(client != null)
            {
                if (client.Connected)
                {
                    writing.WriteLine(TextToSend);
                    this.lbMessages.Invoke(new MethodInvoker(delegate () { lbMessages.Items.Add("Ja: " + TextToSend + "\n"); }));
                }
            }

           
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (client != null)
            {
                client.Close();
                lbStatus.Items.Add("Zakończono pracę serwera...");
            }
        }

        private void bwStart_DoWork(object sender, DoWorkEventArgs e)
        {
            TcpListener server = new TcpListener(IPAddress.Any, (int)nPort.Value);
            server.Start();
            client = server.AcceptTcpClient();
            reading = new StreamReader(client.GetStream());
            writing = new StreamWriter(client.GetStream());
            writing.AutoFlush = true;

            bwConnect.RunWorkerAsync();
            bwMessage.WorkerSupportsCancellation = true;

            this.lbStatus.Invoke(new MethodInvoker(delegate () { lbStatus.Items.Add("Połączono"); }));

        }
    }
}
