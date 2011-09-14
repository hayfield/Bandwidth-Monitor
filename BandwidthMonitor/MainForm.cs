﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace BandwidthMonitor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //NetInterfaces interfaces = new NetInterfaces();

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NetInterfaces.update();
            updateUI();
        }

        private void updateUI()
        {
            NetInterface trackedInterface = NetInterfaces.TrackedInterface();
            kbInLabel.Text = Bytes.ToKilobytes(trackedInterface.period.getBytesIn()).ToString("#0.00") + " KB/sec in";
            kbOutLabel.Text = Bytes.ToKilobytes(trackedInterface.period.getBytesOut()).ToString("#0.00") + " KB/sec out";
            mbInHour.Text = Bytes.ToMegabytes(trackedInterface.Tracker["Minute"].getBytesIn()).ToString("#0.00") + " MB in last minute";
            mbOutHour.Text = Bytes.ToMegabytes(trackedInterface.Tracker["Minute"].getBytesOut()).ToString("#0.00") + " MB out last minute";
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog(this);
        }

        private void mbInHour_Click(object sender, EventArgs e)
        {

        }
    }
}