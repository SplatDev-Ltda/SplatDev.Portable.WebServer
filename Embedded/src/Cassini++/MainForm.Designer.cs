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
            this.btnRedisOnOff = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.grpWebServer = new System.Windows.Forms.GroupBox();
            this.grpRedisServer = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.cmsNotifyIcon.SuspendLayout();
            this.gboAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).BeginInit();
            this.pnlLogo.SuspendLayout();
            this.gboAppType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.grpWebServer.SuspendLayout();
            this.grpRedisServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.Location = new System.Drawing.Point(6, 66);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(62, 13);
            this.lblPort.TabIndex = 1;
            this.lblPort.Text = "Server Port:";
            // 
            // lblAppPath
            // 
            this.lblAppPath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAppPath.AutoSize = true;
            this.lblAppPath.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppPath.Location = new System.Drawing.Point(6, 19);
            this.lblAppPath.Name = "lblAppPath";
            this.lblAppPath.Size = new System.Drawing.Size(74, 13);
            this.lblAppPath.TabIndex = 3;
            this.lblAppPath.Text = "Website Path:";
            // 
            // btnSelectDirectory
            // 
            this.btnSelectDirectory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSelectDirectory.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSelectDirectory.Location = new System.Drawing.Point(232, 14);
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
            this.lblVirtRoot.AutoSize = true;
            this.lblVirtRoot.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVirtRoot.Location = new System.Drawing.Point(6, 42);
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
            this.rdbLoopBack.Location = new System.Drawing.Point(6, 13);
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
            this.rdbAny.Location = new System.Drawing.Point(87, 13);
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
            this.gboAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gboAddress.Controls.Add(this.rdbLoopBack);
            this.gboAddress.Controls.Add(this.rdbAny);
            this.gboAddress.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboAddress.Location = new System.Drawing.Point(263, 9);
            this.gboAddress.Name = "gboAddress";
            this.gboAddress.Size = new System.Drawing.Size(135, 36);
            this.gboAddress.TabIndex = 14;
            this.gboAddress.TabStop = false;
            this.gboAddress.Text = "Listen on";
            // 
            // ssStatus
            // 
            this.ssStatus.AutoSize = false;
            this.ssStatus.Location = new System.Drawing.Point(0, 323);
            this.ssStatus.MinimumSize = new System.Drawing.Size(300, 0);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(480, 22);
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
            this.nudPort.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudPort.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPort.Location = new System.Drawing.Point(79, 65);
            this.nudPort.Maximum = new decimal(new int[] {
            64000,
            0,
            0,
            0});
            this.nudPort.Name = "nudPort";
            this.nudPort.Size = new System.Drawing.Size(177, 21);
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
            this.pnlLogo.Size = new System.Drawing.Size(480, 49);
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
            this.btnAbout.Image = global::Cassinipp.Properties.Resources.question;
            this.btnAbout.Location = new System.Drawing.Point(429, 0);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(49, 48);
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
            this.lblLogo.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.Black;
            this.lblLogo.Location = new System.Drawing.Point(4, 8);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(330, 33);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "Portable Asp.Net Web Server";
            // 
            // btnOnOff
            // 
            this.btnOnOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOnOff.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOnOff.FlatAppearance.BorderSize = 0;
            this.btnOnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnOff.Image = global::Cassinipp.Properties.Resources.off;
            this.btnOnOff.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnOnOff.Location = new System.Drawing.Point(239, 93);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(106, 42);
            this.btnOnOff.TabIndex = 6;
            this.btnOnOff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTips.SetToolTip(this.btnOnOff, "Start/Stop Server");
            this.btnOnOff.UseVisualStyleBackColor = true;
            this.btnOnOff.Click += new System.EventHandler(this.btnOnOff_Click);
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveConfig.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnSaveConfig.FlatAppearance.BorderSize = 0;
            this.btnSaveConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveConfig.Image = global::Cassinipp.Properties.Resources.save;
            this.btnSaveConfig.Location = new System.Drawing.Point(196, 96);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(37, 39);
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
            this.txtVirtRoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVirtRoot.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Cassinipp.Properties.Settings.Default, "vRoot", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtVirtRoot.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVirtRoot.Location = new System.Drawing.Point(80, 40);
            this.txtVirtRoot.Name = "txtVirtRoot";
            this.txtVirtRoot.Size = new System.Drawing.Size(176, 21);
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
            this.txtAppPath.BackColor = System.Drawing.Color.White;
            this.txtAppPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAppPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Cassinipp.Properties.Settings.Default, "webRoot", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtAppPath.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppPath.Location = new System.Drawing.Point(80, 15);
            this.txtAppPath.Name = "txtAppPath";
            this.txtAppPath.Size = new System.Drawing.Size(150, 21);
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
            this.gboAppType.Location = new System.Drawing.Point(263, 46);
            this.gboAppType.Name = "gboAppType";
            this.gboAppType.Size = new System.Drawing.Size(135, 41);
            this.gboAppType.TabIndex = 21;
            this.gboAppType.TabStop = false;
            this.gboAppType.Text = "App Type";
            this.toolTips.SetToolTip(this.gboAppType, "Sets the root to /Home/");
            // 
            // rdMVC
            // 
            this.rdMVC.AutoSize = true;
            this.rdMVC.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMVC.Location = new System.Drawing.Point(83, 18);
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
            this.rdWebForms.Location = new System.Drawing.Point(6, 18);
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
            this.pictureBox.Image = global::Cassinipp.Properties.Resources.server_medium;
            this.pictureBox.Location = new System.Drawing.Point(4, 55);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(66, 81);
            this.pictureBox.TabIndex = 20;
            this.pictureBox.TabStop = false;
            // 
            // btnRedisOnOff
            // 
            this.btnRedisOnOff.FlatAppearance.BorderSize = 0;
            this.btnRedisOnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedisOnOff.Image = global::Cassinipp.Properties.Resources.off;
            this.btnRedisOnOff.Location = new System.Drawing.Point(239, 19);
            this.btnRedisOnOff.Name = "btnRedisOnOff";
            this.btnRedisOnOff.Size = new System.Drawing.Size(99, 35);
            this.btnRedisOnOff.TabIndex = 23;
            this.btnRedisOnOff.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Image = global::Cassinipp.Properties.Resources.settings;
            this.btnSettings.Location = new System.Drawing.Point(344, 91);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(53, 46);
            this.btnSettings.TabIndex = 25;
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // grpWebServer
            // 
            this.grpWebServer.Controls.Add(this.nudPort);
            this.grpWebServer.Controls.Add(this.lblAppPath);
            this.grpWebServer.Controls.Add(this.btnSettings);
            this.grpWebServer.Controls.Add(this.btnSaveConfig);
            this.grpWebServer.Controls.Add(this.btnSelectDirectory);
            this.grpWebServer.Controls.Add(this.lblPort);
            this.grpWebServer.Controls.Add(this.gboAppType);
            this.grpWebServer.Controls.Add(this.txtAppPath);
            this.grpWebServer.Controls.Add(this.btnOnOff);
            this.grpWebServer.Controls.Add(this.lblVirtRoot);
            this.grpWebServer.Controls.Add(this.gboAddress);
            this.grpWebServer.Controls.Add(this.txtVirtRoot);
            this.grpWebServer.Location = new System.Drawing.Point(76, 55);
            this.grpWebServer.Name = "grpWebServer";
            this.grpWebServer.Size = new System.Drawing.Size(403, 143);
            this.grpWebServer.TabIndex = 26;
            this.grpWebServer.TabStop = false;
            this.grpWebServer.Text = "Web Server";
            // 
            // grpRedisServer
            // 
            this.grpRedisServer.Controls.Add(this.button1);
            this.grpRedisServer.Controls.Add(this.btnRedisOnOff);
            this.grpRedisServer.Location = new System.Drawing.Point(76, 204);
            this.grpRedisServer.Name = "grpRedisServer";
            this.grpRedisServer.Size = new System.Drawing.Size(403, 77);
            this.grpRedisServer.TabIndex = 27;
            this.grpRedisServer.TabStop = false;
            this.grpRedisServer.Text = "Redis Server";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Cassinipp.Properties.Resources.settings;
            this.button1.Location = new System.Drawing.Point(344, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 46);
            this.button1.TabIndex = 26;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Cassinipp.Properties.Resources.database;
            this.pictureBox1.Location = new System.Drawing.Point(0, 189);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 92);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnOnOff;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 345);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpRedisServer);
            this.Controls.Add(this.grpWebServer);
            this.Controls.Add(this.pnlLogo);
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
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).EndInit();
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.gboAppType.ResumeLayout(false);
            this.gboAppType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.grpWebServer.ResumeLayout(false);
            this.grpWebServer.PerformLayout();
            this.grpRedisServer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnRedisOnOff;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.GroupBox grpWebServer;
        private System.Windows.Forms.GroupBox grpRedisServer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
    }
}