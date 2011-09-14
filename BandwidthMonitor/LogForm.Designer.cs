namespace BandwidthMonitor
{
    partial class LogForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.logTables = new BandwidthMonitor.LogTables();
            this.SuspendLayout();
            // 
            // logTables
            // 
            this.logTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logTables.Location = new System.Drawing.Point(0, 0);
            this.logTables.Name = "logTables";
            this.logTables.Size = new System.Drawing.Size(348, 372);
            this.logTables.TabIndex = 0;
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 372);
            this.Controls.Add(this.logTables);
            this.Name = "LogForm";
            this.Text = "Bandwidth Logs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LogForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private LogTables logTables;
    }
}