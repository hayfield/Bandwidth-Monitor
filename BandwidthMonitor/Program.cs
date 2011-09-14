using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Timers;
using System.IO;

namespace BandwidthMonitor
{
    static class Program
    {
        /// <summary>
        /// The timer that updates the status of the program
        /// </summary>
        private static System.Timers.Timer timer;

        /// <summary>
        /// The system tray icon
        /// </summary>
        private static NotifyIcon icon;

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

            icon = new NotifyIcon();
            icon.Icon = new Icon(SystemIcons.Exclamation, 16, 16);
            icon.Text = "Bandwidth Monitor";
            icon.Visible = true;
            icon.Click += new EventHandler(icon_Click);

            Application.Run();
        }

        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            NetInterfaces.update();
            NetInterface trackedInterface = NetInterfaces.TrackedInterface();
            icon.Text = Bytes.ToKilobytes(trackedInterface.period.getBytesIn()).ToString("#0.00") + " KB/sec in\n" +
                            Bytes.ToKilobytes(trackedInterface.period.getBytesOut()).ToString("#0.00") + " KB/sec out";
        }

        private static void icon_Click(object Sender, EventArgs e)
        {
            Application.Run(new MainForm());
        }
    }
}
