using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Timers;
using System.IO;
using System.Threading;

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
        /// The context menu for the system tray icon
        /// </summary>
        private static ContextMenu iconMenu;

        /// <summary>
        /// Indicates whether there is currently a main form open
        /// </summary>
        public static bool mainFormActive = false;
        /// <summary>
        /// Indicates whether there is currently a logs form open
        /// </summary>
        public static bool logsFormActive = false;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnApplicationExit);

            timer = new System.Timers.Timer(1000);
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            timer.Enabled = true;

            iconMenu = new ContextMenu();
            iconMenu.MenuItems.Add(new MenuItem("Current Status", icon_Click));
            iconMenu.MenuItems.Add(new MenuItem("Logs (daily totals)", OnMenuLogsClick));
            iconMenu.MenuItems.Add(new MenuItem("Exit (stop logging)", OnMenuExitClick));

            icon = new NotifyIcon();
            icon.Icon = new Icon(Properties.Resources.ProgramIcon, 16, 16);
            icon.Text = "Bandwidth Monitor";
            icon.Visible = true;
            icon.DoubleClick += new EventHandler(icon_Click);
            icon.ContextMenu = iconMenu;
            
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
            if (!mainFormActive)
            {
                MainForm form = new MainForm();
                form.Show();
                mainFormActive = true;
            }
        }

        private static void OnApplicationExit(object Sender, EventArgs e)
        {
            //Console.WriteLine("exiting");
            foreach (NetInterface adapter in NetInterfaces.interfaces)
            {
                adapter.ForceLog();
            }
            icon.Dispose();
        }

        private static void OnMenuExitClick(object Sender, EventArgs e)
        {
            Application.Exit();
        }

        private static void OnMenuLogsClick(object Sender, EventArgs e)
        {
            if (!logsFormActive)
            {
                LogForm form = new LogForm();
                form.Show();
                logsFormActive = true;
            }
        }
    }
}
