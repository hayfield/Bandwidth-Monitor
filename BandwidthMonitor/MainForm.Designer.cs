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
            this.secondTimer = new System.Windows.Forms.Timer(this.components);
            this.settingsButton = new System.Windows.Forms.Button();
            this.kbInSecond = new System.Windows.Forms.Label();
            this.kbOutSecond = new System.Windows.Forms.Label();
            this.mbInMinute = new System.Windows.Forms.Label();
            this.mbOutMinute = new System.Windows.Forms.Label();
            this.mbOutHour = new System.Windows.Forms.Label();
            this.mbInHour = new System.Windows.Forms.Label();
            this.mbOutDay = new System.Windows.Forms.Label();
            this.mbInDay = new System.Windows.Forms.Label();
            this.gbOutWeek = new System.Windows.Forms.Label();
            this.gbInWeek = new System.Windows.Forms.Label();
            this.gbOutMonth = new System.Windows.Forms.Label();
            this.gbInMonth = new System.Windows.Forms.Label();
            this.gbOutYear = new System.Windows.Forms.Label();
            this.gbInYear = new System.Windows.Forms.Label();
            this.adapterName = new System.Windows.Forms.Label();
            this.networkAdaptersList = new System.Windows.Forms.ComboBox();
            this.settingsGroup = new System.Windows.Forms.GroupBox();
            this.settingsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // secondTimer
            // 
            this.secondTimer.Enabled = true;
            this.secondTimer.Interval = 1000;
            this.secondTimer.Tick += new System.EventHandler(this.secondTimer_Tick);
            // 
            // settingsButton
            // 
            this.settingsButton.Enabled = false;
            this.settingsButton.Location = new System.Drawing.Point(200, 170);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(75, 23);
            this.settingsButton.TabIndex = 0;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Visible = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // kbInSecond
            // 
            this.kbInSecond.AutoSize = true;
            this.kbInSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbInSecond.Location = new System.Drawing.Point(12, 35);
            this.kbInSecond.Name = "kbInSecond";
            this.kbInSecond.Size = new System.Drawing.Size(67, 13);
            this.kbInSecond.TabIndex = 1;
            this.kbInSecond.Text = " KB/sec in";
            // 
            // kbOutSecond
            // 
            this.kbOutSecond.AutoSize = true;
            this.kbOutSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbOutSecond.Location = new System.Drawing.Point(12, 52);
            this.kbOutSecond.Name = "kbOutSecond";
            this.kbOutSecond.Size = new System.Drawing.Size(75, 13);
            this.kbOutSecond.TabIndex = 2;
            this.kbOutSecond.Text = " KB/sec out";
            // 
            // mbInMinute
            // 
            this.mbInMinute.AutoSize = true;
            this.mbInMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbInMinute.Location = new System.Drawing.Point(142, 35);
            this.mbInMinute.Name = "mbInMinute";
            this.mbInMinute.Size = new System.Drawing.Size(87, 13);
            this.mbInMinute.TabIndex = 3;
            this.mbInMinute.Text = "MB in last minute";
            // 
            // mbOutMinute
            // 
            this.mbOutMinute.AutoSize = true;
            this.mbOutMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbOutMinute.Location = new System.Drawing.Point(142, 52);
            this.mbOutMinute.Name = "mbOutMinute";
            this.mbOutMinute.Size = new System.Drawing.Size(94, 13);
            this.mbOutMinute.TabIndex = 4;
            this.mbOutMinute.Text = "MB out last minute";
            // 
            // mbOutHour
            // 
            this.mbOutHour.AutoSize = true;
            this.mbOutHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbOutHour.Location = new System.Drawing.Point(12, 94);
            this.mbOutHour.Name = "mbOutHour";
            this.mbOutHour.Size = new System.Drawing.Size(84, 13);
            this.mbOutHour.TabIndex = 6;
            this.mbOutHour.Text = "MB out last hour";
            // 
            // mbInHour
            // 
            this.mbInHour.AutoSize = true;
            this.mbInHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbInHour.Location = new System.Drawing.Point(12, 77);
            this.mbInHour.Name = "mbInHour";
            this.mbInHour.Size = new System.Drawing.Size(77, 13);
            this.mbInHour.TabIndex = 5;
            this.mbInHour.Text = "MB in last hour";
            // 
            // mbOutDay
            // 
            this.mbOutDay.AutoSize = true;
            this.mbOutDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbOutDay.Location = new System.Drawing.Point(12, 136);
            this.mbOutDay.Name = "mbOutDay";
            this.mbOutDay.Size = new System.Drawing.Size(61, 13);
            this.mbOutDay.TabIndex = 8;
            this.mbOutDay.Text = "MB out day";
            // 
            // mbInDay
            // 
            this.mbInDay.AutoSize = true;
            this.mbInDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbInDay.Location = new System.Drawing.Point(12, 119);
            this.mbInDay.Name = "mbInDay";
            this.mbInDay.Size = new System.Drawing.Size(54, 13);
            this.mbInDay.TabIndex = 7;
            this.mbInDay.Text = "MB in day";
            // 
            // gbOutWeek
            // 
            this.gbOutWeek.AutoSize = true;
            this.gbOutWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOutWeek.Location = new System.Drawing.Point(142, 95);
            this.gbOutWeek.Name = "gbOutWeek";
            this.gbOutWeek.Size = new System.Drawing.Size(69, 13);
            this.gbOutWeek.TabIndex = 10;
            this.gbOutWeek.Text = "GB out week";
            // 
            // gbInWeek
            // 
            this.gbInWeek.AutoSize = true;
            this.gbInWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInWeek.Location = new System.Drawing.Point(142, 78);
            this.gbInWeek.Name = "gbInWeek";
            this.gbInWeek.Size = new System.Drawing.Size(62, 13);
            this.gbInWeek.TabIndex = 9;
            this.gbInWeek.Text = "GB in week";
            // 
            // gbOutMonth
            // 
            this.gbOutMonth.AutoSize = true;
            this.gbOutMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOutMonth.Location = new System.Drawing.Point(12, 180);
            this.gbOutMonth.Name = "gbOutMonth";
            this.gbOutMonth.Size = new System.Drawing.Size(72, 13);
            this.gbOutMonth.TabIndex = 12;
            this.gbOutMonth.Text = "GB out month";
            // 
            // gbInMonth
            // 
            this.gbInMonth.AutoSize = true;
            this.gbInMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInMonth.Location = new System.Drawing.Point(12, 163);
            this.gbInMonth.Name = "gbInMonth";
            this.gbInMonth.Size = new System.Drawing.Size(65, 13);
            this.gbInMonth.TabIndex = 11;
            this.gbInMonth.Text = "GB in month";
            // 
            // gbOutYear
            // 
            this.gbOutYear.AutoSize = true;
            this.gbOutYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOutYear.Location = new System.Drawing.Point(142, 136);
            this.gbOutYear.Name = "gbOutYear";
            this.gbOutYear.Size = new System.Drawing.Size(63, 13);
            this.gbOutYear.TabIndex = 14;
            this.gbOutYear.Text = "GB out year";
            // 
            // gbInYear
            // 
            this.gbInYear.AutoSize = true;
            this.gbInYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInYear.Location = new System.Drawing.Point(142, 119);
            this.gbInYear.Name = "gbInYear";
            this.gbInYear.Size = new System.Drawing.Size(56, 13);
            this.gbInYear.TabIndex = 13;
            this.gbInYear.Text = "GB in year";
            // 
            // adapterName
            // 
            this.adapterName.AutoSize = true;
            this.adapterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adapterName.Location = new System.Drawing.Point(12, 9);
            this.adapterName.Name = "adapterName";
            this.adapterName.Size = new System.Drawing.Size(65, 17);
            this.adapterName.TabIndex = 15;
            this.adapterName.Text = "Adapter";
            // 
            // networkAdaptersList
            // 
            this.networkAdaptersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.networkAdaptersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.networkAdaptersList.FormattingEnabled = true;
            this.networkAdaptersList.Location = new System.Drawing.Point(3, 16);
            this.networkAdaptersList.Name = "networkAdaptersList";
            this.networkAdaptersList.Size = new System.Drawing.Size(281, 21);
            this.networkAdaptersList.TabIndex = 16;
            this.networkAdaptersList.SelectedIndexChanged += new System.EventHandler(this.adapterList_SelectedIndexChanged);
            // 
            // settingsGroup
            // 
            this.settingsGroup.Controls.Add(this.networkAdaptersList);
            this.settingsGroup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.settingsGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsGroup.Location = new System.Drawing.Point(0, 204);
            this.settingsGroup.Name = "settingsGroup";
            this.settingsGroup.Size = new System.Drawing.Size(287, 53);
            this.settingsGroup.TabIndex = 17;
            this.settingsGroup.TabStop = false;
            this.settingsGroup.Text = "Network Adapter";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(287, 257);
            this.Controls.Add(this.settingsGroup);
            this.Controls.Add(this.adapterName);
            this.Controls.Add(this.gbOutYear);
            this.Controls.Add(this.gbInYear);
            this.Controls.Add(this.gbOutMonth);
            this.Controls.Add(this.gbInMonth);
            this.Controls.Add(this.gbOutWeek);
            this.Controls.Add(this.gbInWeek);
            this.Controls.Add(this.mbOutDay);
            this.Controls.Add(this.mbInDay);
            this.Controls.Add(this.mbOutHour);
            this.Controls.Add(this.mbInHour);
            this.Controls.Add(this.mbOutMinute);
            this.Controls.Add(this.mbInMinute);
            this.Controls.Add(this.kbOutSecond);
            this.Controls.Add(this.kbInSecond);
            this.Controls.Add(this.settingsButton);
            this.Name = "MainForm";
            this.Text = "Bandwidth Monitor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.settingsGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer secondTimer;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Label kbInSecond;
        private System.Windows.Forms.Label kbOutSecond;
        private System.Windows.Forms.Label mbInMinute;
        private System.Windows.Forms.Label mbOutMinute;
        private System.Windows.Forms.Label mbOutHour;
        private System.Windows.Forms.Label mbInHour;
        private System.Windows.Forms.Label mbOutDay;
        private System.Windows.Forms.Label mbInDay;
        private System.Windows.Forms.Label gbOutWeek;
        private System.Windows.Forms.Label gbInWeek;
        private System.Windows.Forms.Label gbOutMonth;
        private System.Windows.Forms.Label gbInMonth;
        private System.Windows.Forms.Label gbOutYear;
        private System.Windows.Forms.Label gbInYear;
        private System.Windows.Forms.Label adapterName;
        private System.Windows.Forms.ComboBox networkAdaptersList;
        private System.Windows.Forms.GroupBox settingsGroup;
    }
}

