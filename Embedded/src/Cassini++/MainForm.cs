using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;

using Cassinipp.WebServer;
using System.Diagnostics;
using System.Configuration;
using Cassinipp.Properties;
using Cassinipp.WebServer.Utilities;

namespace Cassinipp
{
    public partial class MainForm : Form
    {
        private Server Server { get; set; }
        private Status Status { get; set; }
        private AppType AppType { get; set; }
        private ListenOn ListenOn { get; set; }

        #region Constructors

        public MainForm()
            : this(new string[0])
        { }

        public MainForm(string[] args)
        {
            InitializeComponent();

            InitializeTitle();

            try
            {
                if (args.Length != 0)
                {
                    if (args.Length >= 1)
                    {
                        var appPath = args[0];
                        txtAppPath.Text = Path.GetFullPath(appPath);
                    }

                    if (args.Length >= 2)
                    {
                        nudPort.Value = int.Parse(args[1]);
                    }

                    if (args.Length >= 3)
                    {
                        txtVirtRoot.Text = args[2];
                    }

                    if (args.Length >= 4)
                    {
                        // Default to Loopback
                        if (args[3].Equals("any", StringComparison.OrdinalIgnoreCase))
                        {
                            rdbAny.Checked = true;
                        }
                        else
                        {
                            rdbLoopBack.Checked = true;
                        }
                    }
                    if (args.Length >= 5)
                    {
                        //defaults to Webforms
                        if (args[4].Equals("mvc", StringComparison.OrdinalIgnoreCase))
                            rdMVC.Checked = true;
                        this.Status = WebServer.Status.Online;
                    }
                }
                else
                {
                    bool autostart = bool.Parse(Settings.Default["autoStart"].ToString());
                    if (autostart)
                    {
                        txtAppPath.Text = Settings.Default["webRoot"].ToString();
                        txtVirtRoot.Text = Settings.Default["vRoot"].ToString();
                        nudPort.Value = int.Parse(Settings.Default["port"].ToString());
                        ListenOn listenOn = Helper.ParseListen(Settings.Default["listen"].ToString());
                        AppType type = Helper.ParseAppType(Settings.Default["appType"].ToString());

                        switch (listenOn)
                        {
                            case ListenOn.Loopback: rdbLoopBack.Checked = true;
                                break;
                            case ListenOn.Any: rdbAny.Checked = true;
                                break;
                            default: rdbLoopBack.Checked = true;
                                break;
                        }
                        switch (type)
                        {
                            case AppType.WebForms: rdWebForms.Checked = true;
                                break;
                            case AppType.MVC: rdMVC.Checked = true;
                                break;
                            default: rdWebForms.Checked = true;
                                break;
                        }
                    }
                }
            }
            catch (Exception)
            { }

            if (ValidateForm())
            {
                Start();
            }
        }

        private void InitializeTitle()
        {
            lblLogo.Text = Version.Product;

            Text = Version.FullName;
        }

        #endregion

        #region Start, Stop

        //private void btnStart_Click(object sender, EventArgs e)
        //{
        //    if (ValidateForm())
        //    {
        //        Start();
        //    }
        //}

        //private void btnStop_Click(object sender, EventArgs e)
        //{
        //    Stop();
        //}

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            if (Status == WebServer.Status.Offline && ValidateForm()) Start();
            else if (Status == WebServer.Status.Online) Stop();
        }

        private void Start()
        {
            try
            {
                AppType type = rdWebForms.Checked ? AppType.WebForms : AppType.MVC; //default only MVC and Webforms are present, no need for complex validation

                Server = new Server((int)nudPort.Value, txtVirtRoot.Text, txtAppPath.Text, rdbAny.Checked ? IPAddress.Any : IPAddress.Loopback, type);

                // Register event handlers
                Server.Started += new EventHandler(ServerStarted);
                Server.Stopped += new EventHandler(ServerStopped);

                Server.Start();
                this.Status = WebServer.Status.Online;
            }
            catch
            {
                ShowError("Cassini Managed Web Server failed to start listening on port " + nudPort.Value + ".\r\n" +
                          "Possible conflict with another Web Server on the same port.");
            }
        }

        private void Stop()
        {
            try
            {
                if (Server != null)
                {
                    Server.Stop();
                    this.Status = WebServer.Status.Offline;
                }
            }
            finally
            {
                // Unregister event handlers
                if (Server != null)
                {
                    Server.Started -= new EventHandler(ServerStarted);
                    Server.Stopped -= new EventHandler(ServerStopped);
                }
                Server = null;
            }
        }

        private void ServerStopped(object sender, EventArgs e)
        {
            SetStatus(String.Format("{0} is Offline", Version.FullName));

            btnOnOff.Image = Properties.Resources.off;
            Status = WebServer.Status.Offline;

            toolStripStatusWebPath.Text = String.Empty;

            EnableInput(true);
        }

        private void ServerStarted(object sender, EventArgs e)
        {
            // SetStatus(String.Format("{0} running on port {1}", Version.FullName, nudPort.Value));
            SetStatus(String.Format("{0} is Online @ {1}", Version.FullName, nudPort.Value));
            toolStripStatusWebPath.Text = Server.RootUrl;

            Status = WebServer.Status.Online;
            btnOnOff.Image = Properties.Resources.on;

            EnableInput(false);
        }

        #endregion

        #region Helpers

        private void ShowError(String err)
        {
            MessageBox.Show(err, "Portable Asp.Net Web Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SetStatus(string status)
        {
            string short_status = "";
            if (status.Length > 40)
            {
                short_status = "Web Server " + status.Substring(28);
                toolStripStatusPort.Text = short_status;
            }
            else
                toolStripStatusPort.Text = status;

            // Only 63 chars allowed in notify icon title
            noiCassini.Text = status.Substring(0, Math.Min(status.Length, 63));
        }

        private void EnableInput(bool stopped)
        {
            //btnOnOff.Enabled = stopped;
            startToolStripMenuItem.Enabled = stopped;

            //btnStop.Enabled = !stopped;
            stopToolStripMenuItem.Enabled = !stopped;

            txtVirtRoot.Enabled = stopped;
            nudPort.Enabled = stopped;
            txtAppPath.Enabled = stopped;
            rdbLoopBack.Enabled = stopped;
            rdbAny.Enabled = stopped;
            btnSaveConfig.Enabled = stopped;
            gboAppType.Enabled = stopped;

            btnSelectDirectory.Enabled = stopped;
        }

        //private void llaOpenBrowser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    System.Diagnostics.Process.Start(toolStripStatusWebPath.Text);
        //}

        #endregion

        #region Directory selection

        private void btnSelectDirectory_Click(object sender, EventArgs e)
        {
            fbDlgSelectAppPath.SelectedPath = txtAppPath.Text;

            var res = fbDlgSelectAppPath.ShowDialog(this);

            if (res == DialogResult.OK || res == DialogResult.Yes)
            {
                txtAppPath.Text = fbDlgSelectAppPath.SelectedPath;
            }
        }

        #endregion

        [STAThread]
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(args));
        }

        #region Notify icon event handlers

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
                noiCassini.Visible = true;
            }
            else if (WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized)
            {
                ShowInTaskbar = true;
                noiCassini.Visible = false;
            }
        }

        private void noiCassini_DoubleClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Validation

        private void nudPort_ValueChanged(object sender, EventArgs e)
        {
            ValidatePort();
        }

        private void txtAppPath_TextChanged(object sender, EventArgs e)
        {
            ValidateAppPath();
        }

        private void txtVirtRoot_TextChanged(object sender, EventArgs e)
        {
            ValidateVirtRoot();
        }

        private bool ValidateVirtRoot()
        {
            return Validate(() => !String.IsNullOrEmpty(txtVirtRoot.Text), lblVirtRoot);
        }

        private bool ValidateAppPath()
        {
            return Validate(() => !String.IsNullOrEmpty(txtAppPath.Text) && Directory.Exists(txtAppPath.Text), lblAppPath);
        }

        private bool ValidatePort()
        {
            return Validate(() => nudPort.Value > 0, lblPort);
        }

        private bool Validate(Func<bool> predicate, Label lbl)
        {
            var valid = predicate();

            if (!valid)
            {
                lbl.ForeColor = Color.Red;
            }
            else
            {
                lbl.ForeColor = Color.Black;
            }

            return valid;
        }

        private bool ValidateForm()
        {
            return ValidatePort() && ValidateAppPath() && ValidateVirtRoot();
        }

        #endregion

        #region Other Options
        private void btnAbout_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog(this);
        }

        private void toolStripStatusWebPath_DoubleClick(object sender, EventArgs e)
        {
            OpenBrowser(toolStripStatusWebPath.Text);
        }

        private void OpenBrowser(string url)
        {
            Process.Start(url);
        }

        private void toolStripStatusWebPath_Click(object sender, EventArgs e)
        {
            OpenBrowser(toolStripStatusWebPath.Text);
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default["webRoot"] = txtAppPath.Text;
                Settings.Default["vRoot"] = txtVirtRoot.Text;
                Settings.Default["port"] = int.Parse(nudPort.Value.ToString());
                Settings.Default["autoStart"] = true.ToString();
                Settings.Default["appType"] = this.AppType.AppString();
                Settings.Default["listen"] = this.ListenOn.ToString(); ;
                Settings.Default.Save(); // Saves settings in application configuration file
                toolStripStatusPort.Text = "Configuration Saved";
            }
            catch
            {
                toolStripStatusPort.Text = "Error Saving Configuration";
            }

        }
        #endregion

        private void rdbAppType_Click(object sender, EventArgs e)
        {
            RadioButton rd = (RadioButton)sender;
            switch (rd.Name)
            {
                case "rdWebForms": this.AppType = WebServer.Utilities.AppType.WebForms;
                    break;
                case "rdMVC": this.AppType = WebServer.Utilities.AppType.MVC;
                    break;
                default: this.AppType = WebServer.Utilities.AppType.WebForms;
                    break;
            }

        }

        private void rdbListenOn_Click(object sender, EventArgs e)
        {
            RadioButton rd = (RadioButton)sender;

            switch (rd.Name)
            {
                case "rdbLoopBack": this.ListenOn = WebServer.ListenOn.Loopback;
                    break;
                case "rdbAny": this.ListenOn = WebServer.ListenOn.Any;
                    break;
                default: this.ListenOn = WebServer.ListenOn.Loopback;
                    break;
            }
        }


    }
}