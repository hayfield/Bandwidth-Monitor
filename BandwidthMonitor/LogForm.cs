using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BandwidthMonitor
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
        }

        private void LogForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.logsFormActive = false;
        }
    }
}
