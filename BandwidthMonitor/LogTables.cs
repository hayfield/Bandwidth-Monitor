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
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Date";
            column.ReadOnly = true;
            column.Unique = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Data In";
            column.ReadOnly = true;
            column.Unique = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Data Out";
            column.ReadOnly = true;
            column.Unique = true;
            table.Columns.Add(column);

            row = table.NewRow();
            row["Date"] = 328764;
            row["Data In"] = 43785985;
            row["Data Out"] = 093485;
            table.Rows.Add(row);
            
            BindingSource bs = new BindingSource();
            bs.DataSource = table;
            logTable.DataSource = bs;
        }
    }
}
