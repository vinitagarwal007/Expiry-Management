namespace Expiry_Management
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createVoucherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importPartyListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importItemListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(2, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1309, 485);
            this.panel1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.createVoucherToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.importExportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1317, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // createVoucherToolStripMenuItem
            // 
            this.createVoucherToolStripMenuItem.Name = "createVoucherToolStripMenuItem";
            this.createVoucherToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.createVoucherToolStripMenuItem.Text = "Records";
            this.createVoucherToolStripMenuItem.Click += new System.EventHandler(this.createVoucherToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // importExportToolStripMenuItem
            // 
            this.importExportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importPartyListToolStripMenuItem,
            this.importItemListToolStripMenuItem});
            this.importExportToolStripMenuItem.Name = "importExportToolStripMenuItem";
            this.importExportToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.importExportToolStripMenuItem.Text = "Import";
            // 
            // importPartyListToolStripMenuItem
            // 
            this.importPartyListToolStripMenuItem.Name = "importPartyListToolStripMenuItem";
            this.importPartyListToolStripMenuItem.Size = new System.Drawing.Size(244, 34);
            this.importPartyListToolStripMenuItem.Text = "Import Party List";
            this.importPartyListToolStripMenuItem.Click += new System.EventHandler(this.importPartyListToolStripMenuItem_Click);
            // 
            // importItemListToolStripMenuItem
            // 
            this.importItemListToolStripMenuItem.Name = "importItemListToolStripMenuItem";
            this.importItemListToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.importItemListToolStripMenuItem.Text = "Import Item List";
            this.importItemListToolStripMenuItem.Click += new System.EventHandler(this.importItemListToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 525);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem createVoucherToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem importExportToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importPartyListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importItemListToolStripMenuItem;
    }
}