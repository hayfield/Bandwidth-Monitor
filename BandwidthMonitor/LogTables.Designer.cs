namespace BandwidthMonitor
{
    partial class LogTables
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.logTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.logTable)).BeginInit();
            this.SuspendLayout();
            // 
            // logTable
            // 
            this.logTable.AllowUserToAddRows = false;
            this.logTable.AllowUserToDeleteRows = false;
            this.logTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.logTable.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.logTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logTable.Location = new System.Drawing.Point(0, 0);
            this.logTable.Name = "logTable";
            this.logTable.RowHeadersVisible = false;
            this.logTable.Size = new System.Drawing.Size(376, 467);
            this.logTable.TabIndex = 0;
            // 
            // LogTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.logTable);
            this.Name = "LogTables";
            this.Size = new System.Drawing.Size(376, 467);
            this.Load += new System.EventHandler(this.LogTables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView logTable;
    }
}
