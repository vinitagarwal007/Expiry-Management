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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dgvsl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvitem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvmrp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvsettledate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvsettleamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.savebtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.partyname = new System.Windows.Forms.TextBox();
            this.itemname = new System.Windows.Forms.TextBox();
            this.mrp = new System.Windows.Forms.TextBox();
            this.qty = new System.Windows.Forms.TextBox();
            this.amt = new System.Windows.Forms.TextBox();
            this.adate = new System.Windows.Forms.TextBox();
            this.samt = new System.Windows.Forms.TextBox();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.voucherid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Partyname ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Item Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "MRP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 147);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Qty   ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 173);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Amount ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 223);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Settle Amt ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 198);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Settle Date ";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
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
            this.dgvsettleamount});
            this.dgv.Location = new System.Drawing.Point(308, 8);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(728, 301);
            this.dgv.TabIndex = 8;
            // 
            // dgvsl
            // 
            this.dgvsl.HeaderText = "Sl.";
            this.dgvsl.MinimumWidth = 8;
            this.dgvsl.Name = "dgvsl";
            this.dgvsl.ReadOnly = true;
            this.dgvsl.Width = 55;
            // 
            // dgvitem
            // 
            this.dgvitem.HeaderText = "Item";
            this.dgvitem.MinimumWidth = 8;
            this.dgvitem.Name = "dgvitem";
            this.dgvitem.ReadOnly = true;
            this.dgvitem.Width = 250;
            // 
            // dgvmrp
            // 
            this.dgvmrp.HeaderText = "MRP";
            this.dgvmrp.MinimumWidth = 8;
            this.dgvmrp.Name = "dgvmrp";
            this.dgvmrp.ReadOnly = true;
            // 
            // dgvqty
            // 
            this.dgvqty.HeaderText = "QTY";
            this.dgvqty.MinimumWidth = 8;
            this.dgvqty.Name = "dgvqty";
            this.dgvqty.ReadOnly = true;
            // 
            // dgvsettledate
            // 
            this.dgvsettledate.HeaderText = "Settle Date";
            this.dgvsettledate.MinimumWidth = 8;
            this.dgvsettledate.Name = "dgvsettledate";
            this.dgvsettledate.ReadOnly = true;
            this.dgvsettledate.Width = 110;
            // 
            // dgvsettleamount
            // 
            this.dgvsettleamount.HeaderText = "Settle Amt.";
            this.dgvsettleamount.MinimumWidth = 8;
            this.dgvsettleamount.Name = "dgvsettleamount";
            this.dgvsettleamount.ReadOnly = true;
            this.dgvsettleamount.Width = 110;
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.ForestGreen;
            this.savebtn.FlatAppearance.BorderSize = 0;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.savebtn.Location = new System.Drawing.Point(14, 250);
            this.savebtn.Margin = new System.Windows.Forms.Padding(2);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(280, 31);
            this.savebtn.TabIndex = 7;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = false;
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.Color.Crimson;
            this.cancelbtn.FlatAppearance.BorderSize = 0;
            this.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbtn.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelbtn.Location = new System.Drawing.Point(13, 285);
            this.cancelbtn.Margin = new System.Windows.Forms.Padding(2);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(281, 28);
            this.cancelbtn.TabIndex = 8;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = false;
            // 
            // partyname
            // 
            this.partyname.Location = new System.Drawing.Point(100, 63);
            this.partyname.Margin = new System.Windows.Forms.Padding(2);
            this.partyname.Name = "partyname";
            this.partyname.Size = new System.Drawing.Size(195, 20);
            this.partyname.TabIndex = 0;
            // 
            // itemname
            // 
            this.itemname.Location = new System.Drawing.Point(100, 100);
            this.itemname.Margin = new System.Windows.Forms.Padding(2);
            this.itemname.Name = "itemname";
            this.itemname.Size = new System.Drawing.Size(195, 20);
            this.itemname.TabIndex = 1;
            // 
            // mrp
            // 
            this.mrp.Location = new System.Drawing.Point(100, 124);
            this.mrp.Margin = new System.Windows.Forms.Padding(2);
            this.mrp.Name = "mrp";
            this.mrp.Size = new System.Drawing.Size(195, 20);
            this.mrp.TabIndex = 2;
            // 
            // qty
            // 
            this.qty.Location = new System.Drawing.Point(100, 148);
            this.qty.Margin = new System.Windows.Forms.Padding(2);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(195, 20);
            this.qty.TabIndex = 3;
            // 
            // amt
            // 
            this.amt.Location = new System.Drawing.Point(100, 174);
            this.amt.Margin = new System.Windows.Forms.Padding(2);
            this.amt.Name = "amt";
            this.amt.Size = new System.Drawing.Size(195, 20);
            this.amt.TabIndex = 4;
            // 
            // adate
            // 
            this.adate.Location = new System.Drawing.Point(100, 199);
            this.adate.Margin = new System.Windows.Forms.Padding(2);
            this.adate.Name = "adate";
            this.adate.Size = new System.Drawing.Size(195, 20);
            this.adate.TabIndex = 5;
            // 
            // samt
            // 
            this.samt.Location = new System.Drawing.Point(100, 224);
            this.samt.Margin = new System.Windows.Forms.Padding(2);
            this.samt.Name = "samt";
            this.samt.Size = new System.Drawing.Size(195, 20);
            this.samt.TabIndex = 6;
            // 
            // datetime
            // 
            this.datetime.Location = new System.Drawing.Point(100, 37);
            this.datetime.Margin = new System.Windows.Forms.Padding(2);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(195, 20);
            this.datetime.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 11F);
            this.label9.Location = new System.Drawing.Point(10, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Voucher Id";
            // 
            // voucherid
            // 
            this.voucherid.AutoSize = true;
            this.voucherid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.voucherid.Location = new System.Drawing.Point(103, 16);
            this.voucherid.Name = "voucherid";
            this.voucherid.Size = new System.Drawing.Size(13, 13);
            this.voucherid.TabIndex = 20;
            this.voucherid.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 320);
            this.Controls.Add(this.voucherid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.datetime);
            this.Controls.Add(this.samt);
            this.Controls.Add(this.adate);
            this.Controls.Add(this.amt);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.mrp);
            this.Controls.Add(this.itemname);
            this.Controls.Add(this.partyname);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Create Voucher";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.TextBox partyname;
        private System.Windows.Forms.TextBox itemname;
        private System.Windows.Forms.TextBox mrp;
        private System.Windows.Forms.TextBox qty;
        private System.Windows.Forms.TextBox amt;
        private System.Windows.Forms.TextBox adate;
        private System.Windows.Forms.TextBox samt;
        private System.Windows.Forms.DateTimePicker datetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvsl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvitem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvmrp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvsettledate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvsettleamount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label voucherid;
    }
}

