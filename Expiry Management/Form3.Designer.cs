namespace Expiry_Management
{
    partial class Form3
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amtlable = new System.Windows.Forms.Label();
            this.maxamt = new System.Windows.Forms.TextBox();
            this.minamt = new System.Windows.Forms.TextBox();
            this.partynamesearchbox = new System.Windows.Forms.TextBox();
            this.todate = new System.Windows.Forms.DateTimePicker();
            this.vouchersearch = new System.Windows.Forms.TextBox();
            this.fromdate = new System.Windows.Forms.DateTimePicker();
            this.datelabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.itemnamesearchbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Search By :-";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(167, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 34);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(7, 51);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1293, 422);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 20F;
            this.Column1.HeaderText = "Sl.No.";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 40F;
            this.Column6.HeaderText = "Voucher Id";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Partyname";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 40F;
            this.Column3.HeaderText = "Date";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 40F;
            this.Column4.HeaderText = "Expiry Amt.";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 40F;
            this.Column5.HeaderText = "Settled Amt.";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 40F;
            this.Column7.HeaderText = "Rem Amt.";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // amtlable
            // 
            this.amtlable.BackColor = System.Drawing.Color.Transparent;
            this.amtlable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.amtlable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amtlable.Location = new System.Drawing.Point(787, 14);
            this.amtlable.Name = "amtlable";
            this.amtlable.Size = new System.Drawing.Size(22, 22);
            this.amtlable.TabIndex = 18;
            this.amtlable.Text = "-";
            this.amtlable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.amtlable.Visible = false;
            // 
            // maxamt
            // 
            this.maxamt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxamt.Location = new System.Drawing.Point(810, 11);
            this.maxamt.Name = "maxamt";
            this.maxamt.Size = new System.Drawing.Size(435, 32);
            this.maxamt.TabIndex = 17;
            this.maxamt.Text = "0";
            this.maxamt.Visible = false;
            this.maxamt.TextChanged += new System.EventHandler(this.minamt_TextChanged);
            this.maxamt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maxamt_KeyPress);
            // 
            // minamt
            // 
            this.minamt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minamt.Location = new System.Drawing.Point(349, 11);
            this.minamt.Name = "minamt";
            this.minamt.Size = new System.Drawing.Size(435, 32);
            this.minamt.TabIndex = 16;
            this.minamt.Text = "0";
            this.minamt.Visible = false;
            this.minamt.TextChanged += new System.EventHandler(this.minamt_TextChanged);
            this.minamt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maxamt_KeyPress);
            // 
            // partynamesearchbox
            // 
            this.partynamesearchbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partynamesearchbox.Location = new System.Drawing.Point(349, 11);
            this.partynamesearchbox.Name = "partynamesearchbox";
            this.partynamesearchbox.Size = new System.Drawing.Size(897, 32);
            this.partynamesearchbox.TabIndex = 13;
            this.partynamesearchbox.Visible = false;
            this.partynamesearchbox.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
            // 
            // todate
            // 
            this.todate.CustomFormat = "dd-MM-yyyy";
            this.todate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.todate.Location = new System.Drawing.Point(811, 14);
            this.todate.Name = "todate";
            this.todate.Size = new System.Drawing.Size(435, 26);
            this.todate.TabIndex = 21;
            this.todate.Visible = false;
            this.todate.CloseUp += new System.EventHandler(this.fromdate_CloseUp);
            // 
            // vouchersearch
            // 
            this.vouchersearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vouchersearch.Location = new System.Drawing.Point(349, 11);
            this.vouchersearch.Name = "vouchersearch";
            this.vouchersearch.Size = new System.Drawing.Size(897, 32);
            this.vouchersearch.TabIndex = 19;
            this.vouchersearch.Visible = false;
            this.vouchersearch.TextChanged += new System.EventHandler(this.vouchersearch_TextChanged);
            // 
            // fromdate
            // 
            this.fromdate.CustomFormat = "dd-MM-yyyy";
            this.fromdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromdate.Location = new System.Drawing.Point(350, 14);
            this.fromdate.Name = "fromdate";
            this.fromdate.Size = new System.Drawing.Size(435, 26);
            this.fromdate.TabIndex = 20;
            this.fromdate.Visible = false;
            this.fromdate.CloseUp += new System.EventHandler(this.fromdate_CloseUp);
            // 
            // datelabel
            // 
            this.datelabel.BackColor = System.Drawing.Color.Transparent;
            this.datelabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.datelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelabel.Location = new System.Drawing.Point(787, 15);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(22, 22);
            this.datelabel.TabIndex = 22;
            this.datelabel.Text = "-";
            this.datelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.datelabel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Expiry_Management.Properties.Resources.imageedit_2_4039505882;
            this.pictureBox1.Location = new System.Drawing.Point(1255, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // itemnamesearchbox
            // 
            this.itemnamesearchbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemnamesearchbox.Location = new System.Drawing.Point(349, 11);
            this.itemnamesearchbox.Name = "itemnamesearchbox";
            this.itemnamesearchbox.Size = new System.Drawing.Size(897, 32);
            this.itemnamesearchbox.TabIndex = 24;
            this.itemnamesearchbox.Visible = false;
            this.itemnamesearchbox.TextChanged += new System.EventHandler(this.itemnamesearchbox_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 483);
            this.Controls.Add(this.itemnamesearchbox);
            this.Controls.Add(this.amtlable);
            this.Controls.Add(this.minamt);
            this.Controls.Add(this.maxamt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.fromdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.todate);
            this.Controls.Add(this.vouchersearch);
            this.Controls.Add(this.partynamesearchbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label amtlable;
        private System.Windows.Forms.TextBox maxamt;
        private System.Windows.Forms.TextBox minamt;
        private System.Windows.Forms.TextBox partynamesearchbox;
        private System.Windows.Forms.DateTimePicker todate;
        private System.Windows.Forms.TextBox vouchersearch;
        private System.Windows.Forms.DateTimePicker fromdate;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox itemnamesearchbox;
    }
}