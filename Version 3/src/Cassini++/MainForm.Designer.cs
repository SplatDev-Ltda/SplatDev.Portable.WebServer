namespace PiW
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openTerminalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
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
            this.gboAppType = new System.Windows.Forms.GroupBox();
            this.rdWFileBrowser = new System.Windows.Forms.RadioButton();
            this.rdMVC = new System.Windows.Forms.RadioButton();
            this.rdWebForms = new System.Windows.Forms.RadioButton();
            this.txtAppPath = new System.Windows.Forms.TextBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.btnNetStats = new System.Windows.Forms.Button();
            this.btnConsole = new System.Windows.Forms.Button();
            this.btnBenchmark = new System.Windows.Forms.Button();
            this.btnRootFolder = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnRedisOnOff = new System.Windows.Forms.Button();
            this.btnServerConfig = new System.Windows.Forms.Button();
            this.chkAutoStartWeb = new System.Windows.Forms.CheckBox();
            this.btnRedisConfig = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkAutoStartRedis = new System.Windows.Forms.CheckBox();
            this.grpWebServer = new System.Windows.Forms.GroupBox();
            this.grpRedisServer = new System.Windows.Forms.GroupBox();
            this.chkShowPanel = new System.Windows.Forms.CheckBox();
            this.txtVirtRoot = new System.Windows.Forms.TextBox();
            this.cmsNotifyIcon.SuspendLayout();
            this.gboAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).BeginInit();
            this.pnlLogo.SuspendLayout();
            this.gboAppType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpWebServer.SuspendLayout();
            this.grpRedisServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.Location = new System.Drawing.Point(12, 68);
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
            this.lblAppPath.Location = new System.Drawing.Point(9, 20);
            this.lblAppPath.Name = "lblAppPath";
            this.lblAppPath.Size = new System.Drawing.Size(74, 13);
            this.lblAppPath.TabIndex = 3;
            this.lblAppPath.Text = "Website Path:";
            // 
            // btnSelectDirectory
            // 
            this.btnSelectDirectory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSelectDirectory.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSelectDirectory.Location = new System.Drawing.Point(169, 15);
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
            this.lblVirtRoot.Location = new System.Drawing.Point(12, 44);
            this.lblVirtRoot.Name = "lblVirtRoot";
            this.lblVirtRoot.Size = new System.Drawing.Size(66, 13);
            this.lblVirtRoot.TabIndex = 6;
            this.lblVirtRoot.Text = "Virtual Root:";
            // 
            // noiCassini
            // 
            this.noiCassini.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.noiCassini.BalloonTipText = "Server now Online\r\n";
            this.noiCassini.BalloonTipTitle = "PiW Status";
            this.noiCassini.ContextMenuStrip = this.cmsNotifyIcon;
            this.noiCassini.Icon = ((System.Drawing.Icon)(resources.GetObject("noiCassini.Icon")));
            this.noiCassini.Text = "Portable Internet Web";
            this.noiCassini.Visible = true;
            this.noiCassini.DoubleClick += new System.EventHandler(this.noiCassini_DoubleClick);
            // 
            // cmsNotifyIcon
            // 
            this.cmsNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.redisToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.cmsNotifyIcon.Name = "cmsNotifyIcon";
            this.cmsNotifyIcon.Size = new System.Drawing.Size(134, 76);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.configureToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItem1.Text = "Web Server";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Enabled = false;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.configureToolStripMenuItem.Text = "Configure";
            // 
            // redisToolStripMenuItem
            // 
            this.redisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem1,
            this.stopToolStripMenuItem1,
            this.openTerminalToolStripMenuItem});
            this.redisToolStripMenuItem.Name = "redisToolStripMenuItem";
            this.redisToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.redisToolStripMenuItem.Text = "Redis";
            // 
            // startToolStripMenuItem1
            // 
            this.startToolStripMenuItem1.Name = "startToolStripMenuItem1";
            this.startToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.startToolStripMenuItem1.Text = "Start";
            // 
            // stopToolStripMenuItem1
            // 
            this.stopToolStripMenuItem1.Name = "stopToolStripMenuItem1";
            this.stopToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.stopToolStripMenuItem1.Text = "Stop";
            // 
            // openTerminalToolStripMenuItem
            // 
            this.openTerminalToolStripMenuItem.Name = "openTerminalToolStripMenuItem";
            this.openTerminalToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.openTerminalToolStripMenuItem.Text = "Open Terminal";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(130, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
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
            this.rdbAny.Location = new System.Drawing.Point(83, 13);
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
            this.gboAddress.Location = new System.Drawing.Point(200, 9);
            this.gboAddress.Name = "gboAddress";
            this.gboAddress.Size = new System.Drawing.Size(183, 36);
            this.gboAddress.TabIndex = 14;
            this.gboAddress.TabStop = false;
            this.gboAddress.Text = "Listen on";
            // 
            // ssStatus
            // 
            this.ssStatus.AutoSize = false;
            this.ssStatus.Location = new System.Drawing.Point(0, 281);
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
            this.nudPort.Location = new System.Drawing.Point(83, 66);
            this.nudPort.Maximum = new decimal(new int[] {
            64000,
            0,
            0,
            0});
            this.nudPort.Name = "nudPort";
            this.nudPort.Size = new System.Drawing.Size(111, 21);
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
            this.btnAbout.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAbout.BackColor = System.Drawing.Color.White;
            this.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Image = global::PiW.Properties.Resources.question;
            this.btnAbout.Location = new System.Drawing.Point(429, 0);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(49, 48);
            this.btnAbout.TabIndex = 1;
            this.toolTips.SetToolTip(this.btnAbout, "Open About");
            this.btnAbout.UseVisualStyleBackColor = false;
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
            this.lblLogo.Size = new System.Drawing.Size(254, 33);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "Portable Internet Web";
            // 
            // btnOnOff
            // 
            this.btnOnOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOnOff.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOnOff.FlatAppearance.BorderSize = 0;
            this.btnOnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnOff.Image = global::PiW.Properties.Resources.off;
            this.btnOnOff.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnOnOff.Location = new System.Drawing.Point(288, 93);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(97, 42);
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
            this.btnSaveConfig.Image = global::PiW.Properties.Resources.disk;
            this.btnSaveConfig.Location = new System.Drawing.Point(168, 98);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(37, 39);
            this.btnSaveConfig.TabIndex = 19;
            this.toolTips.SetToolTip(this.btnSaveConfig, "Save Configuration");
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // gboAppType
            // 
            this.gboAppType.Controls.Add(this.rdWFileBrowser);
            this.gboAppType.Controls.Add(this.rdMVC);
            this.gboAppType.Controls.Add(this.rdWebForms);
            this.gboAppType.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboAppType.Location = new System.Drawing.Point(200, 49);
            this.gboAppType.Name = "gboAppType";
            this.gboAppType.Size = new System.Drawing.Size(183, 41);
            this.gboAppType.TabIndex = 21;
            this.gboAppType.TabStop = false;
            this.gboAppType.Text = "App Type";
            this.toolTips.SetToolTip(this.gboAppType, "Sets the root to /Home/");
            // 
            // rdWFileBrowser
            // 
            this.rdWFileBrowser.AutoSize = true;
            this.rdWFileBrowser.Location = new System.Drawing.Point(131, 18);
            this.rdWFileBrowser.Name = "rdWFileBrowser";
            this.rdWFileBrowser.Size = new System.Drawing.Size(46, 17);
            this.rdWFileBrowser.TabIndex = 2;
            this.rdWFileBrowser.TabStop = true;
            this.rdWFileBrowser.Text = "WFB";
            this.toolTips.SetToolTip(this.rdWFileBrowser, "Web File Browser (Custom Directory Browsing)");
            this.rdWFileBrowser.UseVisualStyleBackColor = true;
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
            this.toolTips.SetToolTip(this.rdMVC, "Asp.net MVC");
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
            this.toolTips.SetToolTip(this.rdWebForms, "Asp.net Webforms");
            this.rdWebForms.UseVisualStyleBackColor = true;
            this.rdWebForms.Click += new System.EventHandler(this.rdbAppType_Click);
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
            this.txtAppPath.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppPath.Location = new System.Drawing.Point(83, 16);
            this.txtAppPath.Name = "txtAppPath";
            this.txtAppPath.Size = new System.Drawing.Size(84, 21);
            this.txtAppPath.TabIndex = 1;
            this.toolTips.SetToolTip(this.txtAppPath, "Physical Location for the Website");
            this.txtAppPath.TextChanged += new System.EventHandler(this.txtAppPath_TextChanged);
            // 
            // btnBrowser
            // 
            this.btnBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowser.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnBrowser.FlatAppearance.BorderSize = 0;
            this.btnBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowser.Image = global::PiW.Properties.Resources.browser;
            this.btnBrowser.Location = new System.Drawing.Point(12, 96);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(43, 43);
            this.btnBrowser.TabIndex = 27;
            this.toolTips.SetToolTip(this.btnBrowser, "Open Web Browser");
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // btnNetStats
            // 
            this.btnNetStats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNetStats.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnNetStats.FlatAppearance.BorderSize = 0;
            this.btnNetStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNetStats.Image = global::PiW.Properties.Resources.graph;
            this.btnNetStats.Location = new System.Drawing.Point(61, 96);
            this.btnNetStats.Name = "btnNetStats";
            this.btnNetStats.Size = new System.Drawing.Size(46, 39);
            this.btnNetStats.TabIndex = 28;
            this.toolTips.SetToolTip(this.btnNetStats, "Show Statistics");
            this.btnNetStats.UseVisualStyleBackColor = true;
            this.btnNetStats.Click += new System.EventHandler(this.btnNetStats_Click);
            // 
            // btnConsole
            // 
            this.btnConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsole.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnConsole.FlatAppearance.BorderSize = 0;
            this.btnConsole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsole.Image = global::PiW.Properties.Resources.app;
            this.btnConsole.Location = new System.Drawing.Point(12, 20);
            this.btnConsole.Name = "btnConsole";
            this.btnConsole.Size = new System.Drawing.Size(49, 39);
            this.btnConsole.TabIndex = 27;
            this.toolTips.SetToolTip(this.btnConsole, "Redis Terminal");
            this.btnConsole.UseVisualStyleBackColor = true;
            this.btnConsole.Click += new System.EventHandler(this.btnConsole_Click);
            // 
            // btnBenchmark
            // 
            this.btnBenchmark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBenchmark.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnBenchmark.FlatAppearance.BorderSize = 0;
            this.btnBenchmark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBenchmark.Image = global::PiW.Properties.Resources.gauge;
            this.btnBenchmark.Location = new System.Drawing.Point(61, 22);
            this.btnBenchmark.Name = "btnBenchmark";
            this.btnBenchmark.Size = new System.Drawing.Size(61, 39);
            this.btnBenchmark.TabIndex = 28;
            this.toolTips.SetToolTip(this.btnBenchmark, "Redis Benchmark");
            this.btnBenchmark.UseVisualStyleBackColor = true;
            this.btnBenchmark.Click += new System.EventHandler(this.btnBenchmark_Click);
            // 
            // btnRootFolder
            // 
            this.btnRootFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRootFolder.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnRootFolder.FlatAppearance.BorderSize = 0;
            this.btnRootFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRootFolder.Image = global::PiW.Properties.Resources.cabinet;
            this.btnRootFolder.Location = new System.Drawing.Point(113, 90);
            this.btnRootFolder.Name = "btnRootFolder";
            this.btnRootFolder.Size = new System.Drawing.Size(49, 48);
            this.btnRootFolder.TabIndex = 29;
            this.toolTips.SetToolTip(this.btnRootFolder, "Open PiW Folder");
            this.btnRootFolder.UseVisualStyleBackColor = true;
            this.btnRootFolder.Click += new System.EventHandler(this.btnRootFolder_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::PiW.Properties.Resources.server_medium;
            this.pictureBox.Location = new System.Drawing.Point(3, 64);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(66, 81);
            this.pictureBox.TabIndex = 20;
            this.pictureBox.TabStop = false;
            this.toolTips.SetToolTip(this.pictureBox, "PiW Server");
            // 
            // btnRedisOnOff
            // 
            this.btnRedisOnOff.FlatAppearance.BorderSize = 0;
            this.btnRedisOnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedisOnOff.Image = global::PiW.Properties.Resources.off;
            this.btnRedisOnOff.Location = new System.Drawing.Point(291, 24);
            this.btnRedisOnOff.Name = "btnRedisOnOff";
            this.btnRedisOnOff.Size = new System.Drawing.Size(95, 35);
            this.btnRedisOnOff.TabIndex = 23;
            this.toolTips.SetToolTip(this.btnRedisOnOff, "Start/Stop Redis Server");
            this.btnRedisOnOff.UseVisualStyleBackColor = true;
            this.btnRedisOnOff.Click += new System.EventHandler(this.btnRedisOnOff_Click);
            // 
            // btnServerConfig
            // 
            this.btnServerConfig.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnServerConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServerConfig.Image = global::PiW.Properties.Resources.settings;
            this.btnServerConfig.Location = new System.Drawing.Point(238, 91);
            this.btnServerConfig.Name = "btnServerConfig";
            this.btnServerConfig.Size = new System.Drawing.Size(53, 46);
            this.btnServerConfig.TabIndex = 25;
            this.toolTips.SetToolTip(this.btnServerConfig, "Advanced Configure PiW");
            this.btnServerConfig.UseVisualStyleBackColor = true;
            this.btnServerConfig.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // chkAutoStartWeb
            // 
            this.chkAutoStartWeb.AutoSize = true;
            this.chkAutoStartWeb.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutoStartWeb.Location = new System.Drawing.Point(3, 151);
            this.chkAutoStartWeb.Name = "chkAutoStartWeb";
            this.chkAutoStartWeb.Size = new System.Drawing.Size(73, 17);
            this.chkAutoStartWeb.TabIndex = 26;
            this.chkAutoStartWeb.Text = "Auto Start";
            this.toolTips.SetToolTip(this.chkAutoStartWeb, "Launch PiW on startup");
            this.chkAutoStartWeb.UseVisualStyleBackColor = true;
            // 
            // btnRedisConfig
            // 
            this.btnRedisConfig.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnRedisConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedisConfig.Image = global::PiW.Properties.Resources.settings;
            this.btnRedisConfig.Location = new System.Drawing.Point(238, 18);
            this.btnRedisConfig.Name = "btnRedisConfig";
            this.btnRedisConfig.Size = new System.Drawing.Size(53, 46);
            this.btnRedisConfig.TabIndex = 26;
            this.toolTips.SetToolTip(this.btnRedisConfig, "Configure Redis Server");
            this.btnRedisConfig.UseVisualStyleBackColor = true;
            this.btnRedisConfig.Click += new System.EventHandler(this.btnRedisConfig_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::PiW.Properties.Resources.database;
            this.pictureBox1.Location = new System.Drawing.Point(12, 189);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 42);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.toolTips.SetToolTip(this.pictureBox1, "Redis noDB");
            // 
            // chkAutoStartRedis
            // 
            this.chkAutoStartRedis.AutoSize = true;
            this.chkAutoStartRedis.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutoStartRedis.Location = new System.Drawing.Point(3, 241);
            this.chkAutoStartRedis.Name = "chkAutoStartRedis";
            this.chkAutoStartRedis.Size = new System.Drawing.Size(73, 17);
            this.chkAutoStartRedis.TabIndex = 30;
            this.chkAutoStartRedis.Text = "Auto Start";
            this.toolTips.SetToolTip(this.chkAutoStartRedis, "Launch Redis on startup");
            this.chkAutoStartRedis.UseVisualStyleBackColor = true;
            // 
            // grpWebServer
            // 
            this.grpWebServer.Controls.Add(this.btnRootFolder);
            this.grpWebServer.Controls.Add(this.btnNetStats);
            this.grpWebServer.Controls.Add(this.btnBrowser);
            this.grpWebServer.Controls.Add(this.nudPort);
            this.grpWebServer.Controls.Add(this.lblAppPath);
            this.grpWebServer.Controls.Add(this.btnServerConfig);
            this.grpWebServer.Controls.Add(this.btnSaveConfig);
            this.grpWebServer.Controls.Add(this.btnSelectDirectory);
            this.grpWebServer.Controls.Add(this.lblPort);
            this.grpWebServer.Controls.Add(this.gboAppType);
            this.grpWebServer.Controls.Add(this.txtAppPath);
            this.grpWebServer.Controls.Add(this.btnOnOff);
            this.grpWebServer.Controls.Add(this.lblVirtRoot);
            this.grpWebServer.Controls.Add(this.gboAddress);
            this.grpWebServer.Controls.Add(this.txtVirtRoot);
            this.grpWebServer.Location = new System.Drawing.Point(89, 55);
            this.grpWebServer.Name = "grpWebServer";
            this.grpWebServer.Size = new System.Drawing.Size(390, 143);
            this.grpWebServer.TabIndex = 26;
            this.grpWebServer.TabStop = false;
            this.grpWebServer.Text = "Web Server";
            // 
            // grpRedisServer
            // 
            this.grpRedisServer.Controls.Add(this.btnBenchmark);
            this.grpRedisServer.Controls.Add(this.btnConsole);
            this.grpRedisServer.Controls.Add(this.btnRedisConfig);
            this.grpRedisServer.Controls.Add(this.btnRedisOnOff);
            this.grpRedisServer.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRedisServer.Location = new System.Drawing.Point(89, 204);
            this.grpRedisServer.Name = "grpRedisServer";
            this.grpRedisServer.Size = new System.Drawing.Size(390, 77);
            this.grpRedisServer.TabIndex = 27;
            this.grpRedisServer.TabStop = false;
            this.grpRedisServer.Text = "Redis Server";
            // 
            // chkShowPanel
            // 
            this.chkShowPanel.AutoSize = true;
            this.chkShowPanel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPanel.Location = new System.Drawing.Point(3, 264);
            this.chkShowPanel.Name = "chkShowPanel";
            this.chkShowPanel.Size = new System.Drawing.Size(80, 17);
            this.chkShowPanel.TabIndex = 29;
            this.chkShowPanel.Text = "Show Panel";
            this.chkShowPanel.UseVisualStyleBackColor = true;
            // 
            // txtVirtRoot
            // 
            this.txtVirtRoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVirtRoot.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::PiW.Properties.Settings.Default, "vRoot", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtVirtRoot.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVirtRoot.Location = new System.Drawing.Point(83, 42);
            this.txtVirtRoot.Name = "txtVirtRoot";
            this.txtVirtRoot.Size = new System.Drawing.Size(111, 21);
            this.txtVirtRoot.TabIndex = 2;
            this.txtVirtRoot.Text = global::PiW.Properties.Settings.Default.vRoot;
            this.toolTips.SetToolTip(this.txtVirtRoot, "Virtual Path (Default /)");
            this.txtVirtRoot.TextChanged += new System.EventHandler(this.txtVirtRoot_TextChanged);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnOnOff;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 303);
            this.Controls.Add(this.chkShowPanel);
            this.Controls.Add(this.chkAutoStartRedis);
            this.Controls.Add(this.chkAutoStartWeb);
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
            this.Text = "Portable Internet Web";
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpWebServer.ResumeLayout(false);
            this.grpWebServer.PerformLayout();
            this.grpRedisServer.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnServerConfig;
        private System.Windows.Forms.GroupBox grpWebServer;
        private System.Windows.Forms.GroupBox grpRedisServer;
        private System.Windows.Forms.Button btnRedisConfig;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chkAutoStartWeb;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openTerminalToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btnRootFolder;
        private System.Windows.Forms.Button btnNetStats;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Button btnBenchmark;
        private System.Windows.Forms.Button btnConsole;
        private System.Windows.Forms.CheckBox chkAutoStartRedis;
        private System.Windows.Forms.RadioButton rdWFileBrowser;
        private System.Windows.Forms.CheckBox chkShowPanel;
    }
}