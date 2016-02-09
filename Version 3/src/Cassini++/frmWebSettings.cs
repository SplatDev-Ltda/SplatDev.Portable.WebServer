using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PiW
{
    public partial class frmWebSettings : Form
    {
        public frmWebSettings()
        {
            InitializeComponent();
        }


        private void frmWebSettings_Load(object sender, EventArgs e)
        {
            string[] defaultDocuments = Properties.Settings.Default["DefaultDocs"].ToString().Split(',');
            lstDefaultDocuments.Items.Clear();

            for (int i = 0; i < defaultDocuments.Length; i++)
                lstDefaultDocuments.Items.Add(defaultDocuments[i]);

            txtMVCroot.Text = Properties.Settings.Default["MVCroot"].ToString();
        }

        private void btnAddDefaultDocument_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void frmWebSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save();
        }
        private void Add()
        {
            lstDefaultDocuments.Items.Add(txtNewDefaultDocument.Text);
            txtNewDefaultDocument.Text = "";
        }
        private void MoveUp()
        {
            Reorder(true);
        }

        private void MoveDown()
        {
            Reorder(false);
        }
        private void Remove()
        {
            if (lstDefaultDocuments.SelectedIndex != -1)
                lstDefaultDocuments.Items.Remove(lstDefaultDocuments.SelectedItem);
        }
        private void Save()
        {
            string defaultDocuments = string.Empty;
            int count = lstDefaultDocuments.Items.Count;
            for (int y = 0; y < count; y++)
            {
                defaultDocuments += lstDefaultDocuments.Items[y];
                if (y != count - 1) defaultDocuments += ",";
            }
            Properties.Settings.Default["DefaultDocs"] = defaultDocuments;
            Properties.Settings.Default["MVCroot"] = txtMVCroot.Text;
            Properties.Settings.Default.Save();
        }
        private void Reorder(bool up = false)
        {
            string current;
            int currIndex = 0;
            int newIndex = 0;

            if (lstDefaultDocuments.SelectedIndex != -1)
            {
                current = lstDefaultDocuments.SelectedItem.ToString();
                currIndex = lstDefaultDocuments.SelectedIndex;

                lstDefaultDocuments.Items.Remove(current);
                if (up)
                    newIndex = currIndex - 1 < 0 ? 0 : currIndex - 1;
                else newIndex = currIndex + 1 > lstDefaultDocuments.Items.Count ? lstDefaultDocuments.Items.Count : currIndex + 1;



                lstDefaultDocuments.Items.Insert(newIndex, current);
                lstDefaultDocuments.SelectedIndex = newIndex;
            }
        }
        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remove();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnDocumentUp_Click(object sender, EventArgs e)
        {
            MoveUp();
        }

        private void btnDocumentDown_Click(object sender, EventArgs e)
        {
            MoveDown();
        }

        private void upToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoveUp();
        }

        private void downToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoveDown();
        }

        private void txtNewDefaultDocument_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Add();
        }
    }
}
