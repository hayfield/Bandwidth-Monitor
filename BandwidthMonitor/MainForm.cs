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
        private bool initialised = false;


        public MainForm()
        {
            InitializeComponent();
        }

        //NetInterfaces interfaces = new NetInterfaces();

        private void MainForm_Load(object sender, EventArgs e)
        {
            populateAdaptersList();
            updateUI();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            updateUI();
        }

        private void updateUI()
        {
            NetInterface trackedInterface = NetInterfaces.TrackedInterface();
            adapterName.Text = trackedInterface.name.Replace("[UP] ", "");
            kbInSecond.Text = Bytes.ToKilobytes(trackedInterface.period.getBytesIn()).ToString("#0.00") + " KB/sec in";
            kbOutSecond.Text = Bytes.ToKilobytes(trackedInterface.period.getBytesOut()).ToString("#0.00") + " KB/sec out";
            mbInMinute.Text = Bytes.ToMegabytes(trackedInterface.Tracker["Minute"].getBytesIn()).ToString("#0.00") + " MB in last minute";
            mbOutMinute.Text = Bytes.ToMegabytes(trackedInterface.Tracker["Minute"].getBytesOut()).ToString("#0.00") + " MB out last minute";
            mbInHour.Text = Bytes.ToMegabytes(trackedInterface.Tracker["Hour"].getBytesIn()).ToString("#0.00") + " MB in last hour";
            mbOutHour.Text = Bytes.ToMegabytes(trackedInterface.Tracker["Hour"].getBytesOut()).ToString("#0.00") + " MB out last hour";
            mbInDay.Text = Bytes.ToMegabytes(trackedInterface.Tracker["Day"].getBytesIn()).ToString("#0.00") + " MB in last day";
            mbOutDay.Text = Bytes.ToMegabytes(trackedInterface.Tracker["Day"].getBytesOut()).ToString("#0.00") + " MB out last day";
            gbInWeek.Text = Bytes.ToGigabytes(trackedInterface.Tracker["Week"].getBytesIn()).ToString("#0.00") + " GB in last week";
            gbOutWeek.Text = Bytes.ToGigabytes(trackedInterface.Tracker["Week"].getBytesOut()).ToString("#0.00") + " GB out last week";
            gbInMonth.Text = Bytes.ToGigabytes(trackedInterface.Tracker["Month"].getBytesIn()).ToString("#0.00") + " GB in last month";
            gbOutMonth.Text = Bytes.ToGigabytes(trackedInterface.Tracker["Month"].getBytesOut()).ToString("#0.00") + " GB out last month";
            gbInYear.Text = Bytes.ToGigabytes(trackedInterface.Tracker["Year"].getBytesIn()).ToString("#0.00") + " GB in last year";
            gbOutYear.Text = Bytes.ToGigabytes(trackedInterface.Tracker["Year"].getBytesOut()).ToString("#0.00") + " GB out last year";

            notifyIcon.Text = kbInSecond.Text + "\n" + kbOutSecond.Text;
        }

        private void populateAdaptersList()
        {
            networkAdaptersList.DataSource = NetInterfaces.interfaces;
            networkAdaptersList.DisplayMember = "name";
            networkAdaptersList.ValueMember = "ID";
            networkAdaptersList.SelectedIndex = NetInterfaces.InterfaceIndexWithID(Properties.Settings.Default.TrackedAdapter);
            initialised = true;
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog(this);
        }

        private void adapterList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (initialised)
            {
                Properties.Settings.Default.TrackedAdapter = networkAdaptersList.SelectedValue.ToString();
                Properties.Settings.Default.Save();
                updateUI();
            }
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine("happy times");
            //notifyIcon.Text = "Bob likes\nEating";
        }


    }
}
