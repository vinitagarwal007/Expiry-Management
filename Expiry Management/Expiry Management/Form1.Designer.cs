namespace Expiry_Management
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savebtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.partyname = new System.Windows.Forms.TextBox();
            this.itemname = new System.Windows.Forms.TextBox();
            this.mrp = new System.Windows.Forms.TextBox();
            this.qty = new System.Windows.Forms.TextBox();
            this.samt = new System.Windows.Forms.TextBox();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.voucherid = new System.Windows.Forms.Label();
            this.sdate = new System.Windows.Forms.DateTimePicker();
            this.Company = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvsl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvitem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvmrp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvsettledate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvsettleamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Partyname ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Item Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "MRP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Qty   ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Settle Amt ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Settle Date ";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvsl,
            this.dgvitem,
            this.dgvmrp,
            this.dgvqty,
            this.dgvsettledate,
            this.dgvsettleamount,
            this.Column1});
            this.dgv.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv.Location = new System.Drawing.Point(463, 10);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(838, 463);
            this.dgv.TabIndex = 8;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(143, 68);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(142, 32);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(142, 32);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.IndianRed;
            this.savebtn.FlatAppearance.BorderSize = 0;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.savebtn.Location = new System.Drawing.Point(14, 425);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(420, 48);
            this.savebtn.TabIndex = 7;
            this.savebtn.Text = "Reset";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.cancelbtn.FlatAppearance.BorderSize = 0;
            this.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbtn.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelbtn.Location = new System.Drawing.Point(14, 376);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(422, 43);
            this.cancelbtn.TabIndex = 8;
            this.cancelbtn.Text = "Add";
            this.cancelbtn.UseVisualStyleBackColor = false;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // partyname
            // 
            this.partyname.Location = new System.Drawing.Point(143, 87);
            this.partyname.Name = "partyname";
            this.partyname.Size = new System.Drawing.Size(290, 26);
            this.partyname.TabIndex = 0;
            this.partyname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.partyname_KeyPress);
            this.partyname.Leave += new System.EventHandler(this.partyname_Leave);
            // 
            // itemname
            // 
            this.itemname.AutoCompleteCustomSource.AddRange(new string[] {
            "sa",
            "vinit",
            "ankit"});
            this.itemname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.itemname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.itemname.Location = new System.Drawing.Point(143, 144);
            this.itemname.Name = "itemname";
            this.itemname.Size = new System.Drawing.Size(290, 26);
            this.itemname.TabIndex = 1;
            this.itemname.TextChanged += new System.EventHandler(this.itemname_TextChanged);
            this.itemname.Enter += new System.EventHandler(this.itemname_Enter);
            // 
            // mrp
            // 
            this.mrp.Location = new System.Drawing.Point(143, 217);
            this.mrp.Name = "mrp";
            this.mrp.Size = new System.Drawing.Size(290, 26);
            this.mrp.TabIndex = 3;
            this.mrp.Text = "0";
            this.mrp.TextChanged += new System.EventHandler(this.mrp_TextChanged);
            this.mrp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mrp_KeyPress);
            // 
            // qty
            // 
            this.qty.Location = new System.Drawing.Point(143, 255);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(290, 26);
            this.qty.TabIndex = 4;
            this.qty.Text = "0";
            this.qty.TextChanged += new System.EventHandler(this.mrp_TextChanged);
            this.qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mrp_KeyPress);
            // 
            // samt
            // 
            this.samt.Location = new System.Drawing.Point(143, 334);
            this.samt.Name = "samt";
            this.samt.Size = new System.Drawing.Size(290, 26);
            this.samt.TabIndex = 6;
            this.samt.Text = "0";
            this.samt.TextChanged += new System.EventHandler(this.mrp_TextChanged);
            this.samt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mrp_KeyPress);
            this.samt.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.samt_PreviewKeyDown);
            // 
            // datetime
            // 
            this.datetime.CustomFormat = "dd-MM-yyyy";
            this.datetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetime.Location = new System.Drawing.Point(143, 47);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(290, 26);
            this.datetime.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 11F);
            this.label9.Location = new System.Drawing.Point(8, 10);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "Voucher Id";
            // 
            // voucherid
            // 
            this.voucherid.AutoSize = true;
            this.voucherid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.voucherid.Location = new System.Drawing.Point(142, 14);
            this.voucherid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.voucherid.Name = "voucherid";
            this.voucherid.Size = new System.Drawing.Size(18, 20);
            this.voucherid.TabIndex = 20;
            this.voucherid.Text = "1";
            // 
            // sdate
            // 
            this.sdate.CustomFormat = "dd-MM-yyyy";
            this.sdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.sdate.Location = new System.Drawing.Point(143, 294);
            this.sdate.Name = "sdate";
            this.sdate.Size = new System.Drawing.Size(290, 26);
            this.sdate.TabIndex = 5;
            // 
            // Company
            // 
            this.Company.AutoCompleteCustomSource.AddRange(new string[] {
            "sa",
            "vinit",
            "ankit"});
            this.Company.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Company.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Company.Location = new System.Drawing.Point(142, 180);
            this.Company.Name = "Company";
            this.Company.Size = new System.Drawing.Size(290, 26);
            this.Company.TabIndex = 2;
            this.Company.Leave += new System.EventHandler(this.itemname_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Comapany";
            // 
            // dgvsl
            // 
            this.dgvsl.FillWeight = 10F;
            this.dgvsl.HeaderText = "Sl.";
            this.dgvsl.MinimumWidth = 8;
            this.dgvsl.Name = "dgvsl";
            this.dgvsl.ReadOnly = true;
            // 
            // dgvitem
            // 
            this.dgvitem.FillWeight = 50F;
            this.dgvitem.HeaderText = "Item";
            this.dgvitem.MinimumWidth = 8;
            this.dgvitem.Name = "dgvitem";
            this.dgvitem.ReadOnly = true;
            // 
            // dgvmrp
            // 
            this.dgvmrp.FillWeight = 15F;
            this.dgvmrp.HeaderText = "MRP";
            this.dgvmrp.MinimumWidth = 8;
            this.dgvmrp.Name = "dgvmrp";
            this.dgvmrp.ReadOnly = true;
            // 
            // dgvqty
            // 
            this.dgvqty.FillWeight = 15F;
            this.dgvqty.HeaderText = "QTY";
            this.dgvqty.MinimumWidth = 8;
            this.dgvqty.Name = "dgvqty";
            this.dgvqty.ReadOnly = true;
            // 
            // dgvsettledate
            // 
            this.dgvsettledate.FillWeight = 20F;
            this.dgvsettledate.HeaderText = "Settle Date";
            this.dgvsettledate.MinimumWidth = 8;
            this.dgvsettledate.Name = "dgvsettledate";
            this.dgvsettledate.ReadOnly = true;
            // 
            // dgvsettleamount
            // 
            this.dgvsettleamount.FillWeight = 20F;
            this.dgvsettleamount.HeaderText = "Settle Amt.";
            this.dgvsettleamount.MinimumWidth = 8;
            this.dgvsettleamount.Name = "dgvsettleamount";
            this.dgvsettleamount.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 20F;
            this.Column1.HeaderText = "Company";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1309, 483);
            this.Controls.Add(this.Company);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sdate);
            this.Controls.Add(this.voucherid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.datetime);
            this.Controls.Add(this.samt);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.mrp);
            this.Controls.Add(this.itemname);
            this.Controls.Add(this.partyname);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Create Voucher";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.TextBox partyname;
        private System.Windows.Forms.TextBox itemname;
        private System.Windows.Forms.TextBox mrp;
        private System.Windows.Forms.TextBox qty;
        private System.Windows.Forms.TextBox samt;
        private System.Windows.Forms.DateTimePicker datetime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label voucherid;
        private System.Windows.Forms.DateTimePicker sdate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.TextBox Company;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvsl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvitem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvmrp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvsettledate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvsettleamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

