namespace BandwidthMonitor
{
    partial class SettingsForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.networkAdaptersList = new System.Windows.Forms.ListBox();
            this.netInterfaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.netInterfacesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.netInterfaceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.netInterfacesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Network Adapter";
            // 
            // networkAdaptersList
            // 
            this.networkAdaptersList.FormattingEnabled = true;
            this.networkAdaptersList.Location = new System.Drawing.Point(12, 25);
            this.networkAdaptersList.Name = "networkAdaptersList";
            this.networkAdaptersList.Size = new System.Drawing.Size(402, 355);
            this.networkAdaptersList.Sorted = true;
            this.networkAdaptersList.TabIndex = 2;
            // 
            // netInterfaceBindingSource
            // 
            this.netInterfaceBindingSource.DataSource = typeof(BandwidthMonitor.NetInterface);
            // 
            // netInterfacesBindingSource
            // 
            this.netInterfacesBindingSource.DataSource = typeof(BandwidthMonitor.NetInterfaces);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 388);
            this.Controls.Add(this.networkAdaptersList);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.netInterfaceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.netInterfacesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource netInterfacesBindingSource;
        private System.Windows.Forms.BindingSource netInterfaceBindingSource;
        private System.Windows.Forms.ListBox networkAdaptersList;

    }
}