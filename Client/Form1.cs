using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_Client
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        public StreamReader sreader;
        public StreamWriter swriter;
        public string recieve;
        public string TextSend;
        public Form1()
        {
            InitializeComponent();
            this.lv.Navigate("about:blank");
            this.lv.Document.Write("<!DOCTYPE html><html lang='pl'><head><meta charset='UTF - 8'><meta name='viewport' content='width = device - width, initial - scale = 1.0'><style>.sender{color:blue;}.me{color:greenyellow;}p {color:black;}*{margin:0;margin-top:5px;padding:0;}</style></head><body>");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string host = tbAddress.Text;
            int port = System.Convert.ToInt16(numPort.Value);

            client = new TcpClient();
            IPEndPoint Endp = new IPEndPoint(IPAddress.Parse(host), port);
            try
            {
                client.Connect(Endp);
                if (client.Connected)
                {
                    lbClient.Invoke(new MethodInvoker(delegate
                    {
                        lbClient.Items.Add("Nawiązano połączenie z " + host + " na porcie: " + port);
                    }));
                    sreader = new StreamReader(client.GetStream());
                    swriter = new StreamWriter(client.GetStream());
                    swriter.AutoFlush = true;
                    bw.RunWorkerAsync();
                    bs.WorkerSupportsCancellation = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    recieve = sreader.ReadLine();
                    this.lv.Invoke(new MethodInvoker(delegate ()
                    {
                        lv.Document.Write("Serwer: " + recieve + "<br>");
                    }));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                } 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numPort_ValueChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void send_Click(object sender, EventArgs e)
        {
            TextSend = message.Text;
            bs.RunWorkerAsync();
            message.Text = "";
        }

        private void bs_DoWork(object sender, DoWorkEventArgs e)
        {
            if (client.Connected)
            
                swriter.WriteLine(TextSend);
                this.lv.Invoke(new MethodInvoker(delegate ()
                {
                    lv.Document.Write("Me: " + TextSend + "<br>");
                }));
            }
        }
    }

