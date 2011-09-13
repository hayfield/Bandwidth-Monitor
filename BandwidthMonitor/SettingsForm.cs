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
            foreach(NetInterface i in NetInterfaces.interfaces)
            {
                networkAdaptersList.Items.Add(i);
            }
            networkAdaptersList.SelectedIndex = 0;
            Console.WriteLine("bobby" + networkAdaptersList.Items[1]);
        }
    }
}
