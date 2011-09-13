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
            //NetInterfaces interfaces = new NetInterfaces();
            Dictionary<string, string> adapters = new Dictionary<string, string>();
            foreach(NetInterface i in NetInterfaces.interfaces)
            {
                //adapters.Add(i.ToString(), i.ToString());
                networkAdaptersList.Items.Add(i);
            }
            networkAdaptersList.SelectedIndex = 0;
            //listBox1.Items = adapters;
        }
    }
}
