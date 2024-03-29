﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Excel = Microsoft.Office.Interop.Excel;

namespace Expiry_Management
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SQLiteConnection con;
        SQLiteDataReader reader;
        SQLiteCommand cmd;
        String command;
        private void Form3_Load(object sender, EventArgs e)
        {
        }
        public void setup()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Partyname");
            comboBox1.Items.Add("Date");
            comboBox1.Items.Add("Voucher Id");
            comboBox1.Items.Add("Amount");
            comboBox1.Items.Add("Item Name");
            comboBox1.Items.Add("Company");
            con = new SQLiteConnection("Data Source = " + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Expiry Management\\data.db");
            con.Open();
            //command = "select id,partyname,date,sum(qty*mrp) as tsum,sum(samt) as tsamt,sum(qty*mrp) - sum(samt) from data group by id having tsum != tsamt;";
            //cmd = new SQLiteCommand(command, con);
            //reader = cmd.ExecuteReader();
            //int sl = 1;
            //while (reader.Read())
            //{
            //    dataGridView1.Rows.Add(Convert.ToString(sl),Convert.ToString(reader.GetInt32(0)),reader.GetString(1),reader.GetString(2),reader.GetValue(3),reader.GetValue(4),reader.GetValue(5));
            //}
            comboBox1.SelectedItem = "Partyname";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                partynamesearchbox.Visible = true;
            }
            else
            {
                partynamesearchbox.Visible = false;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                fromdate.Visible = true;
                todate.Visible = true;
                datelabel.Visible = true;
            }
            else
            {
                fromdate.Visible = false;
                todate.Visible = false;
                datelabel.Visible = false;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                vouchersearch.Visible = true;
            }
            else
            {
                vouchersearch.Visible = false;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                minamt.Visible = true;
                maxamt.Visible = true;
                amtlable.Visible = true;
            }
            else
            {
                minamt.Visible = false;
                maxamt.Visible = false;
                amtlable.Visible = false;
            }
            if (comboBox1.SelectedIndex == 4)
            {
                itemnamesearchbox.Visible = true;
            }
            else
            {
                itemnamesearchbox.Visible = false;
            }
            if (comboBox1.SelectedIndex == 5)
            {
                companyname.Visible = true;
            }
            else
            {
                companyname.Visible = false;
            }
            dataGridView1.Rows.Clear();
            command = "select id,partyname,date,sum(qty*mrp) as tsum,sum(samt) as tsamt from data group by id;";
            cmd = new SQLiteCommand(command, con);
            reader = cmd.ExecuteReader();
            int sl = 1;
            while (reader.Read())
            {
                dataGridView1.Rows.Add(Convert.ToString(sl), Convert.ToString(reader.GetInt32(0)), reader.GetString(1), reader.GetString(2), reader.GetValue(3), reader.GetValue(4));
            }
        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            command = "select id,partyname,date,sum(qty*mrp) as tsum,sum(samt) as tsamt from data group by id;";
            cmd = new SQLiteCommand(command, con);
            reader = cmd.ExecuteReader();
            int sl = 1;
            while (reader.Read())
            {
                if (reader.GetString(1).Contains(partynamesearchbox.Text.Trim()))
                {
                    dataGridView1.Rows.Add(Convert.ToString(sl), Convert.ToString(reader.GetInt32(0)), reader.GetString(1), reader.GetString(2), reader.GetValue(3), reader.GetValue(4));
                }
            }
        }

        private void minamt_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == "")
            {
                textBox.Text = "0";
            }
            if (Convert.ToInt64(minamt.Text) > Convert.ToInt64(maxamt.Text))
            {
                maxamt.Text = Convert.ToString(Convert.ToInt64(minamt.Text) + 100);
            }
            dataGridView1.Rows.Clear();
            command = "select id,partyname,date,sum(qty*mrp) as tsum,sum(samt) as tsamt from data group by id;";
            cmd = new SQLiteCommand(command, con);
            reader = cmd.ExecuteReader();
            int sl = 1;
            while (reader.Read())
            {
                if (reader.GetInt32(4) >= Convert.ToInt64(minamt.Text.Trim()) & reader.GetInt32(4) <= Convert.ToInt64(maxamt.Text.Trim()))
                {
                    dataGridView1.Rows.Add(Convert.ToString(sl), Convert.ToString(reader.GetInt32(0)), reader.GetString(1), reader.GetString(2), reader.GetValue(3), reader.GetValue(4));
                }
            }
        }

        private void vouchersearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            command = "select id,partyname,date,sum(qty*mrp) as tsum,sum(samt) as tsamt from data group by id;";
            cmd = new SQLiteCommand(command, con);
            reader = cmd.ExecuteReader();
            int sl = 1;
            while (reader.Read())
            {
                if (Convert.ToString(reader.GetInt32(0)).Contains(vouchersearch.Text.Trim()))
                {
                    dataGridView1.Rows.Add(Convert.ToString(sl), Convert.ToString(reader.GetInt32(0)), reader.GetString(1), reader.GetString(2), reader.GetValue(3), reader.GetValue(4));
                }
            }
        }

        private void fromdate_CloseUp(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            DateTime fdate = fromdate.Value;
            DateTime tdate = todate.Value;
            if (tdate < fdate)
            {
                todate.Value = fromdate.Value;
            }
            for (var dt = fdate; dt <= tdate.AddDays(1); dt = dt.AddDays(1))
            {
                list.Add(dt.ToString("dd-MM-yyyy"));
            }


            dataGridView1.Rows.Clear();
            command = "select id,partyname,date,sum(qty*mrp) as tsum,sum(samt) as tsamt from data group by id;";
            cmd = new SQLiteCommand(command, con);
            reader = cmd.ExecuteReader();
            int sl = 1;
            while (reader.Read())
            {
                if (list.Contains(reader.GetString(2)))
                {
                    dataGridView1.Rows.Add(Convert.ToString(sl), Convert.ToString(reader.GetInt32(0)), reader.GetString(1), reader.GetString(2), reader.GetValue(3), reader.GetValue(4));
                }
            }
        }

        private void maxamt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Excel.Application exapp = new Excel.Application();
            Excel.Workbooks workbooks = exapp.Workbooks;
            Excel.Workbook workbook = workbooks.Add();
            Excel.Sheets sheets = workbook.Worksheets;
            Excel.Worksheet worksheet = sheets[1];
            Excel.Range range;
            int excelindex = 1;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int temp = excelindex;
                range = worksheet.Range["A" + (excelindex), "A" + (excelindex)];
                range.Value = "Voucher Id";
                range = worksheet.Range["B" + (excelindex), "G" + (excelindex)];
                range.Merge(true);
                range.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft; 
                range.Value = dataGridView1.Rows[i].Cells[1].Value;
                excelindex += 1;
                range = worksheet.Range["A" + (excelindex), "A" + (excelindex)];
                range.Value = "Paryname";
                range = worksheet.Range["B" + (excelindex), "G" + (excelindex)];
                range.Merge(true);
                range.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                range.Value = dataGridView1.Rows[i].Cells[2].Value;
                excelindex += 1;
                range = worksheet.Range["A" + (excelindex), "A" + (excelindex)];
                range.Value = "Date";
                range = worksheet.Range["B" + (excelindex), "G" + (excelindex)];
                range.Merge(true);
                range.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                range.Value = dataGridView1.Rows[i].Cells[3].Value;

                excelindex += 1;
                range = worksheet.Range["A" + (excelindex), "A" + (excelindex)];
                range.Value = "Sl.No.";
                range = worksheet.Range["B" + (excelindex), "B" + (excelindex)];
                range.Value = "Item Name";
                range = worksheet.Range["C" + (excelindex), "C" + (excelindex)];
                range.Value = "MRP";
                range = worksheet.Range["D" + (excelindex), "D" + (excelindex)];
                range.Value = "QTY";
                range = worksheet.Range["E" + (excelindex), "E" + (excelindex)];
                range.Value = "Amount";
                range = worksheet.Range["F" + (excelindex), "F" + (excelindex)];
                range.Value = "Settle Date";
                range = worksheet.Range["G" + (excelindex), "G" + (excelindex)];
                range.Value = "Settle Amount";
                range = worksheet.Range["H" + (excelindex), "H" + (excelindex)];
                range.Value = "Settle Amount";
                range = worksheet.Range["A" + (excelindex - 3), "H" + excelindex];
                range.Interior.Color = ColorTranslator.FromHtml("#90c3f5");
                range.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                range.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                range.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                range.Font.Bold = true;

                excelindex += 1;
                int slno = 1;
                command = "select * from data where id = "+dataGridView1.Rows[i].Cells[1].Value+";";
                cmd = new SQLiteCommand(command, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    range = worksheet.Range["A"+(excelindex), "A" + (excelindex)];
                    range.Value = Convert.ToString(slno);
                    range = worksheet.Range["B"+(excelindex), "B"+(excelindex)];
                    range.Value = reader.GetValue(3);
                    range = worksheet.Range["C" + (excelindex), "C" + (excelindex)];
                    range.Value = reader.GetValue(4);
                    range = worksheet.Range["D" + (excelindex), "D" + (excelindex)];
                    range.Value = reader.GetValue(5);
                    range = worksheet.Range["E" + (excelindex), "E" + (excelindex)];
                    range.Value = Convert.ToInt64(reader.GetValue(4)) * Convert.ToInt64(reader.GetValue(5)); 
                    range = worksheet.Range["F" + (excelindex), "F" + (excelindex)];
                    range.Value = reader.GetValue(6);
                    range = worksheet.Range["G" + (excelindex), "G" + (excelindex)];
                    range.Value = reader.GetValue(7);
                    range = worksheet.Range["H" + (excelindex), "H" + (excelindex)];
                    range.Value = reader.GetValue(9);
                    slno += 1;
                    excelindex += 1;
                }
                range = worksheet.Range["A" + temp, "H" + (excelindex-1)];
                range.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                excelindex += 2;
            }
            range = worksheet.Range["A1", "H" + (excelindex)];
            range.Columns.AutoFit();
            exapp.Visible = true;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.Rows[e.RowIndex].Selected = true;
        }

        private void itemnamesearchbox_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            command = "select id,partyname,date,sum(qty*mrp) as tsum,sum(samt) as tsamt from data where itemname like '%" + itemnamesearchbox.Text.Trim() + "%' group by id;";
            cmd = new SQLiteCommand(command, con);
            reader = cmd.ExecuteReader();
            int sl = 1;
            while (reader.Read())
            {
                dataGridView1.Rows.Add(Convert.ToString(sl), Convert.ToString(reader.GetInt32(0)), reader.GetString(1), reader.GetString(2), reader.GetValue(3), reader.GetValue(4));
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            reportdialog reportdialog = new reportdialog();
            reportdialog.sharedvoucherid = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            reportdialog.ShowDialog();
        }

        private void companyname_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            command = "select id,partyname,date,sum(qty*mrp) as tsum,sum(samt) from data where company like '%" + companyname.Text.Trim() + "%' group by id ;";
            cmd = new SQLiteCommand(command, con);
            reader = cmd.ExecuteReader();
            int sl = 1;
            while (reader.Read())
            {
                dataGridView1.Rows.Add(Convert.ToString(sl), Convert.ToString(reader.GetInt32(0)), reader.GetString(1), reader.GetString(2), reader.GetValue(3), reader.GetValue(4));
            }
        }
    }
}
