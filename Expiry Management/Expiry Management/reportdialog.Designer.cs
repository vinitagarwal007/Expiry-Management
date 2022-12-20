namespace Expiry_Management
{
    partial class reportdialog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvsl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvitem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvmrp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvsettledate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvsettleamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvsl,
            this.dgvitem,
            this.dgvmrp,
            this.dgvqty,
            this.dgvsettledate,
            this.dgvsettleamount,
            this.Column1});
            this.dgv.Location = new System.Drawing.Point(3, 2);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(838, 198);
            this.dgv.TabIndex = 9;
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.cancelbtn.FlatAppearance.BorderSize = 0;
            this.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbtn.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelbtn.Location = new System.Drawing.Point(3, 206);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(415, 41);
            this.cancelbtn.TabIndex = 11;
            this.cancelbtn.Text = "Update";
            this.cancelbtn.UseVisualStyleBackColor = false;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(426, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(415, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // reportdialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 254);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "reportdialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Voucher Details";
            this.Load += new System.EventHandler(this.reportdialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvsl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvitem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvmrp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvsettledate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvsettleamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}