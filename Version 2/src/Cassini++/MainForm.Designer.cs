namespace Cassinipp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblPort = new System.Windows.Forms.Label();
            this.lblAppPath = new System.Windows.Forms.Label();
            this.fbDlgSelectAppPath = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSelectDirectory = new System.Windows.Forms.Button();
            this.lblVirtRoot = new System.Windows.Forms.Label();
            this.noiCassini = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rdbLoopBack = new System.Windows.Forms.RadioButton();
            this.rdbAny = new System.Windows.Forms.RadioButton();
            this.gboAddress = new System.Windows.Forms.GroupBox();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusWebPath = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusPort = new System.Windows.Forms.ToolStripStatusLabel();
            this.nudPort = new System.Windows.Forms.NumericUpDown();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnOnOff = new System.Windows.Forms.Button();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.txtVirtRoot = new System.Windows.Forms.TextBox();
            this.txtAppPath = new System.Windows.Forms.TextBox();
            this.gboAppType = new System.Windows.Forms.GroupBox();
            this.rdMVC = new System.Windows.Forms.RadioButton();
            this.rdWebForms = new System.Windows.Forms.RadioButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.cmsNotifyIcon.SuspendLayout();
            this.gboAddress.SuspendLayout();
            this.ssStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).BeginInit();
            this.pnlLogo.SuspendLayout();
            this.gboAppType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPort
            // 
            this.lblPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.Location = new System.Drawing.Point(83, 117);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(62, 13);
            this.lblPort.TabIndex = 1;
            this.lblPort.Text = "Server Port:";
            // 
            // lblAppPath
            // 
            this.lblAppPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAppPath.AutoSize = true;
            this.lblAppPath.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppPath.Location = new System.Drawing.Point(83, 49);
            this.lblAppPath.Name = "lblAppPath";
            this.lblAppPath.Size = new System.Drawing.Size(74, 13);
            this.lblAppPath.TabIndex = 3;
            this.lblAppPath.Text = "Website Path:";
            // 
            // btnSelectDirectory
            // 
            this.btnSelectDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectDirectory.Location = new System.Drawing.Point(294, 43);
            this.btnSelectDirectory.Name = "btnSelectDirectory";
            this.btnSelectDirectory.Size = new System.Drawing.Size(25, 23);
            this.btnSelectDirectory.TabIndex = 2;
            this.btnSelectDirectory.Text = "...";
            this.toolTips.SetToolTip(this.btnSelectDirectory, "Browse...");
            this.btnSelectDirectory.UseVisualStyleBackColor = true;
            this.btnSelectDirectory.Click += new System.EventHandler(this.btnSelectDirectory_Click);
            // 
            // lblVirtRoot
            // 
            this.lblVirtRoot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVirtRoot.AutoSize = true;
            this.lblVirtRoot.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVirtRoot.Location = new System.Drawing.Point(83, 82);
            this.lblVirtRoot.Name = "lblVirtRoot";
            this.lblVirtRoot.Size = new System.Drawing.Size(66, 13);
            this.lblVirtRoot.TabIndex = 6;
            this.lblVirtRoot.Text = "Virtual Root:";
            // 
            // noiCassini
            // 
            this.noiCassini.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.noiCassini.BalloonTipText = "Server Online";
            this.noiCassini.BalloonTipTitle = "Server Status";
            this.noiCassini.ContextMenuStrip = this.cmsNotifyIcon;
            this.noiCassini.Icon = ((System.Drawing.Icon)(resources.GetObject("noiCassini.Icon")));
            this.noiCassini.Text = "Portable Asp.Net Web Server";
            this.noiCassini.Visible = true;
            this.noiCassini.DoubleClick += new System.EventHandler(this.noiCassini_DoubleClick);
            // 
            // cmsNotifyIcon
            // 
            this.cmsNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.cmsNotifyIcon.Name = "cmsNotifyIcon";
            this.cmsNotifyIcon.Size = new System.Drawing.Size(99, 70);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Enabled = false;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // rdbLoopBack
            // 
            this.rdbLoopBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbLoopBack.AutoSize = true;
            this.rdbLoopBack.Checked = true;
            this.rdbLoopBack.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbLoopBack.Location = new System.Drawing.Point(6, 20);
            this.rdbLoopBack.Name = "rdbLoopBack";
            this.rdbLoopBack.Size = new System.Drawing.Size(70, 17);
            this.rdbLoopBack.TabIndex = 4;
            this.rdbLoopBack.TabStop = true;
            this.rdbLoopBack.Text = "Loopback";
            this.toolTips.SetToolTip(this.rdbLoopBack, "Default (127.0.0.1)");
            this.rdbLoopBack.UseVisualStyleBackColor = true;
            this.rdbLoopBack.Click += new System.EventHandler(this.rdbListenOn_Click);
            // 
            // rdbAny
            // 
            this.rdbAny.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbAny.AutoSize = true;
            this.rdbAny.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAny.Location = new System.Drawing.Point(98, 20);
            this.rdbAny.Name = "rdbAny";
            this.rdbAny.Size = new System.Drawing.Size(42, 17);
            this.rdbAny.TabIndex = 5;
            this.rdbAny.Text = "Any";
            this.toolTips.SetToolTip(this.rdbAny, "Any interfaces");
            this.rdbAny.UseVisualStyleBackColor = true;
            this.rdbAny.Click += new System.EventHandler(this.rdbListenOn_Click);
            // 
            // gboAddress
            // 
            this.gboAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gboAddress.Controls.Add(this.rdbLoopBack);
            this.gboAddress.Controls.Add(this.rdbAny);
            this.gboAddress.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboAddress.Location = new System.Drawing.Point(5, 138);
            this.gboAddress.Name = "gboAddress";
            this.gboAddress.Size = new System.Drawing.Size(152, 44);
            this.gboAddress.TabIndex = 14;
            this.gboAddress.TabStop = false;
            this.gboAddress.Text = "Listen on";
            // 
            // ssStatus
            // 
            this.ssStatus.AutoSize = false;
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus,
            this.toolStripStatusWebPath,
            this.toolStripStatusPort});
            this.ssStatus.Location = new System.Drawing.Point(0, 231);
            this.ssStatus.MinimumSize = new System.Drawing.Size(300, 0);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(329, 22);
            this.ssStatus.TabIndex = 16;
            this.ssStatus.Text = "statusStrip1";
            // 
            // tssStatus
            // 
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.tssStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusWebPath
            // 
            this.toolStripStatusWebPath.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripStatusWebPath.IsLink = true;
            this.toolStripStatusWebPath.Name = "toolStripStatusWebPath";
            this.toolStripStatusWebPath.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusWebPath.Click += new System.EventHandler(this.toolStripStatusWebPath_Click);
            this.toolStripStatusWebPath.DoubleClick += new System.EventHandler(this.toolStripStatusWebPath_DoubleClick);
            // 
            // toolStripStatusPort
            // 
            this.toolStripStatusPort.Name = "toolStripStatusPort";
            this.toolStripStatusPort.Size = new System.Drawing.Size(0, 17);
            // 
            // nudPort
            // 
            this.nudPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudPort.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPort.Location = new System.Drawing.Point(165, 114);
            this.nudPort.Maximum = new decimal(new int[] {
            64000,
            0,
            0,
            0});
            this.nudPort.Name = "nudPort";
            this.nudPort.Size = new System.Drawing.Size(152, 21);
            this.nudPort.TabIndex = 3;
            this.nudPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTips.SetToolTip(this.nudPort, "Port to listen on (Default 80)");
            this.nudPort.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.nudPort.ValueChanged += new System.EventHandler(this.nudPort_ValueChanged);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.SystemColors.Window;
            this.pnlLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLogo.Controls.Add(this.btnAbout);
            this.pnlLogo.Controls.Add(this.lblLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(329, 37);
            this.pnlLogo.TabIndex = 18;
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.Location = new System.Drawing.Point(301, 5);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(25, 23);
            this.btnAbout.TabIndex = 1;
            this.toolTips.SetToolTip(this.btnAbout, "Open About");
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.Black;
            this.lblLogo.Location = new System.Drawing.Point(6, 5);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(258, 26);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "Portable Asp.Net Web Server";
            // 
            // btnOnOff
            // 
            this.btnOnOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOnOff.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnOnOff.FlatAppearance.BorderSize = 0;
            this.btnOnOff.Image = ((System.Drawing.Image)(resources.GetObject("btnOnOff.Image")));
            this.btnOnOff.Location = new System.Drawing.Point(245, 154);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(74, 74);
            this.btnOnOff.TabIndex = 6;
            this.toolTips.SetToolTip(this.btnOnOff, "Start/Stop Server");
            this.btnOnOff.UseVisualStyleBackColor = true;
            this.btnOnOff.Click += new System.EventHandler(this.btnOnOff_Click);
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveConfig.FlatAppearance.BorderSize = 0;
            this.btnSaveConfig.Image = global::Cassinipp.Properties.Resources.save;
            this.btnSaveConfig.Location = new System.Drawing.Point(165, 154);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(74, 74);
            this.btnSaveConfig.TabIndex = 19;
            this.toolTips.SetToolTip(this.btnSaveConfig, "Save Configuration");
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // toolTips
            // 
            this.toolTips.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // txtVirtRoot
            // 
            this.txtVirtRoot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVirtRoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVirtRoot.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Cassinipp.Properties.Settings.Default, "vRoot", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtVirtRoot.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVirtRoot.Location = new System.Drawing.Point(165, 78);
            this.txtVirtRoot.Name = "txtVirtRoot";
            this.txtVirtRoot.Size = new System.Drawing.Size(152, 21);
            this.txtVirtRoot.TabIndex = 2;
            this.txtVirtRoot.Text = global::Cassinipp.Properties.Settings.Default.vRoot;
            this.toolTips.SetToolTip(this.txtVirtRoot, "Virtual Path (Default /)");
            this.txtVirtRoot.TextChanged += new System.EventHandler(this.txtVirtRoot_TextChanged);
            // 
            // txtAppPath
            // 
            this.txtAppPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAppPath.AutoCompleteCustomSource.AddRange(new string[] {
            "C:\\",
            "C:\\Users\\",
            "C:\\Programs and Settings\\",
            "C:\\Windows"});
            this.txtAppPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtAppPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtAppPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAppPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Cassinipp.Properties.Settings.Default, "webRoot", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtAppPath.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppPath.Location = new System.Drawing.Point(165, 45);
            this.txtAppPath.Name = "txtAppPath";
            this.txtAppPath.Size = new System.Drawing.Size(123, 21);
            this.txtAppPath.TabIndex = 1;
            this.txtAppPath.Text = global::Cassinipp.Properties.Settings.Default.webRoot;
            this.toolTips.SetToolTip(this.txtAppPath, "Physical Location for the Website");
            this.txtAppPath.TextChanged += new System.EventHandler(this.txtAppPath_TextChanged);
            // 
            // gboAppType
            // 
            this.gboAppType.Controls.Add(this.rdMVC);
            this.gboAppType.Controls.Add(this.rdWebForms);
            this.gboAppType.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboAppType.Location = new System.Drawing.Point(5, 181);
            this.gboAppType.Name = "gboAppType";
            this.gboAppType.Size = new System.Drawing.Size(152, 47);
            this.gboAppType.TabIndex = 21;
            this.gboAppType.TabStop = false;
            this.gboAppType.Text = "App Type";
            this.toolTips.SetToolTip(this.gboAppType, "Sets the root to /Home/");
            // 
            // rdMVC
            // 
            this.rdMVC.AutoSize = true;
            this.rdMVC.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMVC.Location = new System.Drawing.Point(98, 20);
            this.rdMVC.Name = "rdMVC";
            this.rdMVC.Size = new System.Drawing.Size(46, 17);
            this.rdMVC.TabIndex = 1;
            this.rdMVC.TabStop = true;
            this.rdMVC.Text = "MVC";
            this.rdMVC.UseVisualStyleBackColor = true;
            this.rdMVC.Click += new System.EventHandler(this.rdbAppType_Click);
            // 
            // rdWebForms
            // 
            this.rdWebForms.AutoSize = true;
            this.rdWebForms.Checked = true;
            this.rdWebForms.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdWebForms.Location = new System.Drawing.Point(7, 20);
            this.rdWebForms.Name = "rdWebForms";
            this.rdWebForms.Size = new System.Drawing.Size(76, 17);
            this.rdWebForms.TabIndex = 0;
            this.rdWebForms.TabStop = true;
            this.rdWebForms.Text = "WebForms";
            this.rdWebForms.UseVisualStyleBackColor = true;
            this.rdWebForms.Click += new System.EventHandler(this.rdbAppType_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(15, 51);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(66, 81);
            this.pictureBox.TabIndex = 20;
            this.pictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnOnOff;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 253);
            this.Controls.Add(this.gboAppType);
            this.Controls.Add(this.btnSaveConfig);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.gboAddress);
            this.Controls.Add(this.nudPort);
            this.Controls.Add(this.txtVirtRoot);
            this.Controls.Add(this.lblVirtRoot);
            this.Controls.Add(this.btnOnOff);
            this.Controls.Add(this.txtAppPath);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.btnSelectDirectory);
            this.Controls.Add(this.lblAppPath);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(200, 281);
            this.Name = "MainForm";
            this.Text = "Portable Asp.Net Web Server";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.cmsNotifyIcon.ResumeLayout(false);
            this.gboAddress.ResumeLayout(false);
            this.gboAddress.PerformLayout();
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).EndInit();
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.gboAppType.ResumeLayout(false);
            this.gboAppType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblAppPath;
        private System.Windows.Forms.TextBox txtAppPath;
        private System.Windows.Forms.FolderBrowserDialog fbDlgSelectAppPath;
        private System.Windows.Forms.Button btnSelectDirectory;
        private System.Windows.Forms.Label lblVirtRoot;
        private System.Windows.Forms.TextBox txtVirtRoot;
        private System.Windows.Forms.NotifyIcon noiCassini;
        private System.Windows.Forms.RadioButton rdbLoopBack;
        private System.Windows.Forms.RadioButton rdbAny;
        private System.Windows.Forms.GroupBox gboAddress;
        private System.Windows.Forms.ContextMenuStrip cmsNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private System.Windows.Forms.NumericUpDown nudPort;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnOnOff;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusWebPath;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusPort;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.ToolTip toolTips;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox gboAppType;
        private System.Windows.Forms.RadioButton rdMVC;
        private System.Windows.Forms.RadioButton rdWebForms;
    }
}