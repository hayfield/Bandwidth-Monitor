using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace BandwidthMonitor
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            populateAdaptersList();
        }

        private void populateAdaptersList()
        {
            networkAdaptersList.DataSource = NetInterfaces.interfaces;
            networkAdaptersList.DisplayMember = "name";
            networkAdaptersList.ValueMember = "ID";
            networkAdaptersList.SelectedIndex = 0;
        }

        private void networkAdaptersList_SelectedValueChanged(object sender, EventArgs e)
        {
            //Console.WriteLine("selected: " + networkAdaptersList.SelectedIndex + " item: " + networkAdaptersList.SelectedItem + " val: " + networkAdaptersList.SelectedValue);
            Properties.Settings.Default.TrackedAdapter = networkAdaptersList.SelectedValue.ToString();
        }
    }
}
