using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Timers;

namespace BandwidthMonitor
{
    static class Program
    {
        private static System.Timers.Timer timer;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            timer.Enabled = true;
            Application.Run(new MainForm());
        }

        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            NetInterfaces.update();
        }
    }
}
