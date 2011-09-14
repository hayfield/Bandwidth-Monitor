namespace BandwidthMonitor
{
    partial class MainForm
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.settingsButton = new System.Windows.Forms.Button();
            this.kbInLabel = new System.Windows.Forms.Label();
            this.kbOutLabel = new System.Windows.Forms.Label();
            this.mbInHour = new System.Windows.Forms.Label();
            this.mbOutHour = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(173, 225);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(75, 23);
            this.settingsButton.TabIndex = 0;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // kbInLabel
            // 
            this.kbInLabel.AutoSize = true;
            this.kbInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbInLabel.Location = new System.Drawing.Point(12, 9);
            this.kbInLabel.Name = "kbInLabel";
            this.kbInLabel.Size = new System.Drawing.Size(81, 17);
            this.kbInLabel.TabIndex = 1;
            this.kbInLabel.Text = " KB/sec in";
            // 
            // kbOutLabel
            // 
            this.kbOutLabel.AutoSize = true;
            this.kbOutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbOutLabel.Location = new System.Drawing.Point(12, 26);
            this.kbOutLabel.Name = "kbOutLabel";
            this.kbOutLabel.Size = new System.Drawing.Size(91, 17);
            this.kbOutLabel.TabIndex = 2;
            this.kbOutLabel.Text = " KB/sec out";
            // 
            // mbInHour
            // 
            this.mbInHour.AutoSize = true;
            this.mbInHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbInHour.Location = new System.Drawing.Point(12, 60);
            this.mbInHour.Name = "mbInHour";
            this.mbInHour.Size = new System.Drawing.Size(102, 17);
            this.mbInHour.TabIndex = 3;
            this.mbInHour.Text = "MB in last hour";
            this.mbInHour.Click += new System.EventHandler(this.mbInHour_Click);
            // 
            // mbOutHour
            // 
            this.mbOutHour.AutoSize = true;
            this.mbOutHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbOutHour.Location = new System.Drawing.Point(12, 77);
            this.mbOutHour.Name = "mbOutHour";
            this.mbOutHour.Size = new System.Drawing.Size(111, 17);
            this.mbOutHour.TabIndex = 4;
            this.mbOutHour.Text = "MB out last hour";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(260, 260);
            this.Controls.Add(this.mbOutHour);
            this.Controls.Add(this.mbInHour);
            this.Controls.Add(this.kbOutLabel);
            this.Controls.Add(this.kbInLabel);
            this.Controls.Add(this.settingsButton);
            this.Name = "MainForm";
            this.Text = "Bandwidth Monitor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Label kbInLabel;
        private System.Windows.Forms.Label kbOutLabel;
        private System.Windows.Forms.Label mbInHour;
        private System.Windows.Forms.Label mbOutHour;
    }
}

