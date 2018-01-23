using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Net.NetworkInformation;    

namespace PingBoot
{
    public partial class Form1 : Form
    {
        string add1 = "";
        string add2 = "";
        string add3 = "";
        int failureCount = 0;

        public Form1()
        {
            InitializeComponent();

            if (Properties.Settings.Default.savedAdd1 != "")
                address1.Text = Properties.Settings.Default.savedAdd1;
            
            if (Properties.Settings.Default.savedAdd2 != "")
                address2.Text = Properties.Settings.Default.savedAdd2;

            if (Properties.Settings.Default.savedAdd3 != "")
                address3.Text = Properties.Settings.Default.savedAdd3;
            intervalNumber.Value = Properties.Settings.Default.savedInterval;
            autoStart.Checked = Properties.Settings.Default.savedAutostart;            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Go!")
            {
                intervalNumber.Enabled = false;
                address1.Enabled = false;
                address2.Enabled = false;
                address3.Enabled = false;
                autoStart.Enabled = false;
                button1.Text = "Stop";


                add1 = address1.Text;
                add2 = address2.Text;
                add3 = address3.Text;
                timer1.Interval = (int)intervalNumber.Value * 60 * 1000;

                Properties.Settings.Default.savedAdd1 = add1;
                Properties.Settings.Default.savedAdd2 = add2;
                Properties.Settings.Default.savedAdd3 = add3;

                Properties.Settings.Default.savedInterval = intervalNumber.Value;
                Properties.Settings.Default.savedAutostart = autoStart.Checked;
                Properties.Settings.Default.Save();


                timer1.Start();
                log("PingBoot Started.");
                log("Waiting " + intervalNumber.Value.ToString() + " minutes...");
            }
            else 
            { 
                intervalNumber.Enabled = true;
                address1.Enabled = true;
                address2.Enabled = true;
                address3.Enabled = true;
                autoStart.Enabled = true;
                button1.Text = "Go!";
                timer1.Stop();
                log("PingBoot Stopped.");
            }            
        }





        private void log(string s)
        {
            output.AppendText("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + s + "\r\n");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            log("Time's up!");
            CheckForIllegalCrossThreadCalls = false;
            Thread t = new Thread(ping);
            t.Start();
        }

        private void ping()
        {
            bool pingable1 = false;
            bool pingable2 = false;
            bool pingable3 = false;

            Ping pinger = new Ping();

            try
            {
                log("Pinging " + add1);
                PingReply reply = pinger.Send(add1);
                pingable1 = reply.Status == IPStatus.Success;
                if(pingable1)
                    log("Successful reply from " + add1);
                else
                    log("No reply from " + add1);
            
            }
            catch (Exception)
            {
                log("Error pinging " + add1);
            }

            try
            {
                log("Pinging " + add2);
                PingReply reply = pinger.Send(add2);
                pingable2 = reply.Status == IPStatus.Success;
                if (pingable2)
                    log("Successful reply from " + add2);
                else
                    log("No reply from " + add2);
            }
            catch (Exception)
            {
                log("Error pinging " + add2);
            }

            try
            {
                log("Pinging " + add3);
                PingReply reply = pinger.Send(add3);
                pingable3 = reply.Status == IPStatus.Success;
                if (pingable3)
                    log("Successful reply from " + add3);
                else
                    log("No reply from " + add3);
            }
            catch (Exception)
            {
                log("Error pinging " + add3);
            }

            if(pingable1 || pingable2 || pingable3)
            {
                log("Waiting " + intervalNumber.Value.ToString() + " minutes...");
                failureCount = 0;
            }
            else if(failureCount >= 2)
            {
                failureCount = 0;
                log("Restarting!");
                restart();
            }
            else
            {
                failureCount++;
            }

            
        }

        private void restart()
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.WindowStyle = ProcessWindowStyle.Hidden;
            proc.FileName = "cmd";
            proc.Arguments = "/C shutdown -f -r";
            Process.Start(proc);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/CplSyx/PingBoot");
            Process.Start(sInfo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (autoStart.Checked)
            {
                log("Autostarting.");
                button1.PerformClick();
            }
        }
    }
}
