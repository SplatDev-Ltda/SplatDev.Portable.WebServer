namespace PiW
{
    partial class frmWebSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWebSettings));
            this.tabsSettings = new System.Windows.Forms.TabControl();
            this.tabWebMVC = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewDefaultDocument = new System.Windows.Forms.TextBox();
            this.lstDefaultDocuments = new System.Windows.Forms.ListBox();
            this.ctxDefaultDocuments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabWFB = new System.Windows.Forms.TabPage();
            this.btnAddDefaultDocument = new System.Windows.Forms.Button();
            this.btnDocumentUp = new System.Windows.Forms.Button();
            this.btnDocumentDown = new System.Windows.Forms.Button();
            this.upToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMVCroot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabsSettings.SuspendLayout();
            this.tabWebMVC.SuspendLayout();
            this.ctxDefaultDocuments.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsSettings
            // 
            this.tabsSettings.Controls.Add(this.tabWebMVC);
            this.tabsSettings.Controls.Add(this.tabWFB);
            this.tabsSettings.Location = new System.Drawing.Point(1, 3);
            this.tabsSettings.Name = "tabsSettings";
            this.tabsSettings.SelectedIndex = 0;
            this.tabsSettings.Size = new System.Drawing.Size(259, 259);
            this.tabsSettings.TabIndex = 0;
            // 
            // tabWebMVC
            // 
            this.tabWebMVC.Controls.Add(this.groupBox2);
            this.tabWebMVC.Controls.Add(this.groupBox1);
            this.tabWebMVC.Location = new System.Drawing.Point(4, 22);
            this.tabWebMVC.Name = "tabWebMVC";
            this.tabWebMVC.Padding = new System.Windows.Forms.Padding(3);
            this.tabWebMVC.Size = new System.Drawing.Size(251, 233);
            this.tabWebMVC.TabIndex = 0;
            this.tabWebMVC.Text = "Web / MVC";
            this.tabWebMVC.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add";
            // 
            // txtNewDefaultDocument
            // 
            this.txtNewDefaultDocument.Location = new System.Drawing.Point(35, 13);
            this.txtNewDefaultDocument.Name = "txtNewDefaultDocument";
            this.txtNewDefaultDocument.Size = new System.Drawing.Size(150, 20);
            this.txtNewDefaultDocument.TabIndex = 1;
            this.txtNewDefaultDocument.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNewDefaultDocument_KeyDown);
            // 
            // lstDefaultDocuments
            // 
            this.lstDefaultDocuments.ContextMenuStrip = this.ctxDefaultDocuments;
            this.lstDefaultDocuments.FormattingEnabled = true;
            this.lstDefaultDocuments.Location = new System.Drawing.Point(6, 39);
            this.lstDefaultDocuments.Name = "lstDefaultDocuments";
            this.lstDefaultDocuments.Size = new System.Drawing.Size(179, 121);
            this.lstDefaultDocuments.TabIndex = 0;
            // 
            // ctxDefaultDocuments
            // 
            this.ctxDefaultDocuments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.upToolStripMenuItem,
            this.downToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem});
            this.ctxDefaultDocuments.Name = "ctxDefaultDocuments";
            this.ctxDefaultDocuments.Size = new System.Drawing.Size(118, 98);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // tabWFB
            // 
            this.tabWFB.Location = new System.Drawing.Point(4, 22);
            this.tabWFB.Name = "tabWFB";
            this.tabWFB.Size = new System.Drawing.Size(251, 233);
            this.tabWFB.TabIndex = 2;
            this.tabWFB.Text = "Web File Browser";
            this.tabWFB.ToolTipText = "Custom Directory Browsing";
            this.tabWFB.UseVisualStyleBackColor = true;
            // 
            // btnAddDefaultDocument
            // 
            this.btnAddDefaultDocument.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddDefaultDocument.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAddDefaultDocument.FlatAppearance.BorderSize = 0;
            this.btnAddDefaultDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDefaultDocument.Image = global::PiW.Properties.Resources.add;
            this.btnAddDefaultDocument.Location = new System.Drawing.Point(191, 10);
            this.btnAddDefaultDocument.Name = "btnAddDefaultDocument";
            this.btnAddDefaultDocument.Size = new System.Drawing.Size(38, 47);
            this.btnAddDefaultDocument.TabIndex = 3;
            this.btnAddDefaultDocument.UseVisualStyleBackColor = false;
            this.btnAddDefaultDocument.Click += new System.EventHandler(this.btnAddDefaultDocument_Click);
            // 
            // btnDocumentUp
            // 
            this.btnDocumentUp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDocumentUp.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnDocumentUp.FlatAppearance.BorderSize = 0;
            this.btnDocumentUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocumentUp.Image = global::PiW.Properties.Resources.up;
            this.btnDocumentUp.Location = new System.Drawing.Point(191, 66);
            this.btnDocumentUp.Name = "btnDocumentUp";
            this.btnDocumentUp.Size = new System.Drawing.Size(38, 31);
            this.btnDocumentUp.TabIndex = 4;
            this.btnDocumentUp.UseVisualStyleBackColor = false;
            this.btnDocumentUp.Click += new System.EventHandler(this.btnDocumentUp_Click);
            // 
            // btnDocumentDown
            // 
            this.btnDocumentDown.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDocumentDown.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnDocumentDown.FlatAppearance.BorderSize = 0;
            this.btnDocumentDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocumentDown.Image = global::PiW.Properties.Resources.down;
            this.btnDocumentDown.Location = new System.Drawing.Point(191, 103);
            this.btnDocumentDown.Name = "btnDocumentDown";
            this.btnDocumentDown.Size = new System.Drawing.Size(38, 29);
            this.btnDocumentDown.TabIndex = 5;
            this.btnDocumentDown.UseVisualStyleBackColor = false;
            this.btnDocumentDown.Click += new System.EventHandler(this.btnDocumentDown_Click);
            // 
            // upToolStripMenuItem
            // 
            this.upToolStripMenuItem.Name = "upToolStripMenuItem";
            this.upToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.upToolStripMenuItem.Text = "Up";
            this.upToolStripMenuItem.Click += new System.EventHandler(this.upToolStripMenuItem_Click);
            // 
            // downToolStripMenuItem
            // 
            this.downToolStripMenuItem.Name = "downToolStripMenuItem";
            this.downToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.downToolStripMenuItem.Text = "Down";
            this.downToolStripMenuItem.Click += new System.EventHandler(this.downToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(114, 6);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstDefaultDocuments);
            this.groupBox1.Controls.Add(this.btnDocumentDown);
            this.groupBox1.Controls.Add(this.txtNewDefaultDocument);
            this.groupBox1.Controls.Add(this.btnDocumentUp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAddDefaultDocument);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 168);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Documents";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMVCroot);
            this.groupBox2.Location = new System.Drawing.Point(8, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 49);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MVC";
            // 
            // txtMVCroot
            // 
            this.txtMVCroot.Location = new System.Drawing.Point(43, 17);
            this.txtMVCroot.Name = "txtMVCroot";
            this.txtMVCroot.Size = new System.Drawing.Size(186, 20);
            this.txtMVCroot.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Root";
            // 
            // frmWebSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 262);
            this.Controls.Add(this.tabsSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmWebSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmWebSettings_FormClosing);
            this.Load += new System.EventHandler(this.frmWebSettings_Load);
            this.tabsSettings.ResumeLayout(false);
            this.tabWebMVC.ResumeLayout(false);
            this.ctxDefaultDocuments.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabsSettings;
        private System.Windows.Forms.TabPage tabWebMVC;
        private System.Windows.Forms.TabPage tabWFB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewDefaultDocument;
        private System.Windows.Forms.ListBox lstDefaultDocuments;
        private System.Windows.Forms.ContextMenuStrip ctxDefaultDocuments;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button btnDocumentDown;
        private System.Windows.Forms.Button btnDocumentUp;
        private System.Windows.Forms.Button btnAddDefaultDocument;
        private System.Windows.Forms.ToolStripMenuItem upToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMVCroot;
    }
}