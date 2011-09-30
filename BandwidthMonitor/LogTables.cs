using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BandwidthMonitor
{
    public partial class LogTables : UserControl
    {
        public LogTables()
        {
            InitializeComponent();
        }

        private void LogTables_Load(object sender, EventArgs e)
        {
            // http://msdn.microsoft.com/en-us/library/system.data.datatable.aspx
            DataTable table = new DataTable("LogTable");
            DataColumn column;
            DataRow row;

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.DateTime");
            column.ColumnName = "Date";
            column.ReadOnly = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Data In";
            column.ReadOnly = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Data Out";
            column.ReadOnly = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Double");
            column.ColumnName = "In";
            column.ReadOnly = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Double");
            column.ColumnName = "Out";
            column.ReadOnly = true;
            table.Columns.Add(column);

            NetInterface trackedInterface = NetInterfaces.TrackedInterface();
            foreach (DataTransferPeriod period in trackedInterface.getDayData())
            {
                row = table.NewRow();
                row["Date"] = DateTime.FromBinary(period.getStartTicks()).ToShortDateString();
                row["Data In"] = Bytes.ToMegabytes(period.getBytesIn()).ToString("#0.00") +" MB";
                row["Data Out"] = Bytes.ToMegabytes(period.getBytesOut()).ToString("#0.00") + " MB";
                row["In"] = Convert.ToDouble(Bytes.ToMegabytes(period.getBytesIn()).ToString("#0.000"));
                row["Out"] = Convert.ToDouble(Bytes.ToMegabytes(period.getBytesOut()).ToString("#0.000"));
                table.Rows.Add(row);
            }

            table.DefaultView.Sort = "Date DESC";

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = table;
            logTable.DataSource = bindingSource;

            logTable.Columns[3].Width = 20;
            logTable.Columns[4].Width = 30;
        }
    }
}
