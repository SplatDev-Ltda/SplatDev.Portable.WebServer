using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Cassinipp
{
    partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
            this.Text = String.Format("About {0}", Version.FullName);
            this.labelProductName.Text = Version.Product;
            this.labelVersion.Text = String.Format("Version {0}", Version.FullVersion);
            this.labelCopyright.Text = Version.Copyright;
            this.labelCompanyName.Text = Version.Company;
            this.textBoxDescription.Text = Version.Description;
        }
    }
}
