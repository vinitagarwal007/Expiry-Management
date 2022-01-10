﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;

namespace Expiry_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SQLiteConnection con;
        SQLiteDataReader reader;
        SQLiteCommand cmd;
        String command;
        long lastslno;
        List<string> voucheridlist = new List<string>();
        public string sharedvoucherid = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            //if (!File.Exists("data.db"))
            //{
            //    SQLiteConnection.CreateFile("data.db");
            //    var inicon = new SQLiteConnection("Data Source = data.db");
            //    inicon.Open();
            //    var inicommand = @"CREATE TABLE data(
            //                    id        INT(100)     NOT NULL,
            //                    date      TEXT(100),
            //                    partyname TEXT(100),
            //                    itemname  TEXT(100),
            //                    mrp       DECIMAL(100),
            //                    qty       INTEGER(100),
            //                    sdate     TEXT(100),
            //                    samt      DECIMAL(100),
            //                    slno      TEXT(100) NOT NULL PRIMARY KEY
            //                    );
            //                    CREATE TABLE itemlist(
            //                    name TEXT(100),
            //                    mrp  TEXT(100) 
            //                    );
            //                    CREATE TABLE partylist(
            //                    name TEXT(100) 
            //                    );
            //                    CREATE TABLE config(
            //                    lastvoucherid TEXT(100),
            //                    lastdataslno TEXT(100)
            //                    );";
            //    var inicmd = new SQLiteCommand(inicommand, inicon);
            //    inicmd.ExecuteReader();

            //    inicommand = "INSERT INTO config('lastvoucherid','lastdataslno') values(0,0);";
            //    inicmd = new SQLiteCommand(inicommand, inicon);
            //    inicmd.ExecuteNonQuery();

            //    inicon.Close(); 
            //}
        }
        public void setup()
        {
            con = new SQLiteConnection("Data Source = data.db");
            con.Open();
            command = "select * from config;";
            cmd = new SQLiteCommand(command, con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                voucherid.Text = Convert.ToString(Convert.ToInt64(reader.GetString(0)) + 1);
                lastslno = Convert.ToInt64(reader.GetString(1)) + 1;
            }
            if (sharedvoucherid != "")
            {
                voucherid.Text = sharedvoucherid;
            }

            command = "select * from data where id =" + voucherid.Text;
            cmd = new SQLiteCommand(command, con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                datetime.Value = Convert.ToDateTime(reader.GetString(1));
                partyname.Text = reader.GetString(2);
            }
            refreshdgv();
            autocompletesetup();
        }
        private void savebtn_Click(object sender, EventArgs e)
        {
            setup();
            clear();
            dgv.Rows.Clear();
        }


        private void autocompletesetup()
        {
            command = "select  * from partylist;";
            cmd = new SQLiteCommand(command, con);
            reader = cmd.ExecuteReader();
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                col.Add(reader.GetString(0));
            }
            partyname.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            partyname.AutoCompleteSource = AutoCompleteSource.CustomSource;
            partyname.AutoCompleteCustomSource = col;
            itemname.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            itemname.AutoCompleteSource = AutoCompleteSource.CustomSource;
            command = "select  * from itemlist;";
            cmd = new SQLiteCommand(command, con);
            reader = cmd.ExecuteReader();
            col = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                col.Add(reader.GetString(0));
            }
            itemname.AutoCompleteCustomSource = col;
        }
        private void refreshdgv()
        {
            dgv.Rows.Clear();
            command = "select * from data where id =" + voucherid.Text;
            cmd = new SQLiteCommand(command, con);
            reader = cmd.ExecuteReader();
            int sl = 1;
            voucheridlist.Clear();
            while (reader.Read())
            {
                voucheridlist.Add(reader.GetString(8));
                dgv.Rows.Add(sl, reader.GetString(3), reader.GetDecimal(4), reader.GetInt64(5), reader.GetString(6), reader.GetDecimal(7));
                sl++;
            }

        }
        private void savedata()
        {
            if (!toupdate)
            {
                command = "insert into data values(" + voucherid.Text + ",\"" + datetime.Value.ToString("dd-MM-yyyy") + "\",\"" + partyname.Text + "\",\"" + itemname.Text + "\"," + mrp.Text + "," + qty.Text + ",\"" + sdate.Value.ToString("dd-MM-yyyy") + "\"," + samt.Text + ",\"" + lastslno + "\")";
                cmd = new SQLiteCommand(command, con);
                cmd.ExecuteNonQuery();

                command = "update config set lastdataslno = " + Convert.ToString(lastslno) + ";";
                cmd = new SQLiteCommand(command, con);
                reader = cmd.ExecuteReader();

                command = "select * from config;";
                cmd = new SQLiteCommand(command, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lastslno = Convert.ToInt64(reader.GetString(1)) + 1;
                }
                command = "update config set lastvoucherid = '" + voucherid.Text + "';";
                cmd = new SQLiteCommand(command, con);
                cmd.ExecuteNonQuery();
            }
            else
            {
                command = "update data set id =" + voucherid.Text + ",date =\"" + datetime.Value.ToString("dd-MM-yyyy") + "\",partyname =\"" + partyname.Text + "\",itemname=\"" + itemname.Text + "\",mrp =" + mrp.Text + ",qty =" + qty.Text + ",sdate =\"" + sdate.Value.ToString("dd-MM-yyyy") + "\",samt = " + samt.Text + " where slno = \"" + voucheridlist[currentcell] + "\";";
                cmd = new SQLiteCommand(command, con);
                var output = cmd.ExecuteNonQuery();
                toupdate = false;
                MessageBox.Show(String.Format("{0} entry was updated", Convert.ToString(output)));
                cancelbtn.Text = "Add";
            }

            refreshdgv();
        }
        private Boolean validate()
        {
            if (partyname.Text.Trim() == "")
            {
                MessageBox.Show("enter a valid partyname");
                return false;
            }
            if (itemname.Text.Trim() == "")
            {
                MessageBox.Show("enter a valid itemname");
                return false;
            }
            return true;
        }
        private void clear()
        {
            partyname.Text = "";
            itemname.Text = "";
            mrp.Text = "0";
            qty.Text = "0";
            samt.Text = "0";
            partyname.Focus();
            datetime.Value = DateTime.Now;
            sdate.Value = DateTime.Now;
        }



        private void mrp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void mrp_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == "")
            {
                textBox.Text = "0";
            }
            amt.Text = Convert.ToString(Convert.ToDecimal(mrp.Text.Trim()) * Convert.ToDecimal(qty.Text.Trim()));
        }

        private void samt_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                if (itemname.Text.Trim() != "")
                {
                    DialogResult result = MessageBox.Show("Do You Want To Save The Data", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        if (validate())
                        {
                            savedata();
                            string temp = partyname.Text;
                            clear();
                            partyname.Text = temp;
                            itemname.Focus();
                        }
                    }
                }
                e.IsInputKey = true;
                itemname.Focus();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
        }
        int currentcell;
        private void dgv_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                currentcell = e.RowIndex;
                dgv.ClearSelection();
                dgv.Rows[currentcell].Selected = true;

            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(String.Format("Are you sure you want to delete entry no. {0}", voucheridlist[currentcell]), "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                command = "delete from data where slno = '" + voucheridlist[currentcell] + "';";
                cmd = new SQLiteCommand(command, con);
                var output = cmd.ExecuteNonQuery();
                MessageBox.Show(String.Format("{0} entry was deleted", Convert.ToString(output)));
                refreshdgv();
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                savedata();
                string temp = partyname.Text;
                clear();
                partyname.Text = temp;
                itemname.Focus();
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv.ClearSelection();
            dgv.Rows[e.RowIndex].Selected = true;
        }
        Boolean toupdate = false;
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            itemname.Text = dgv.Rows[currentcell].Cells[1].Value.ToString();
            mrp.Text = dgv.Rows[currentcell].Cells[2].Value.ToString();
            qty.Text = dgv.Rows[currentcell].Cells[3].Value.ToString();
            amt.Text = Convert.ToString(Convert.ToDecimal(mrp.Text.Trim()) * Convert.ToDecimal(qty.Text.Trim()));
            sdate.Value = Convert.ToDateTime(dgv.Rows[currentcell].Cells[4].Value.ToString());
            samt.Text = dgv.Rows[currentcell].Cells[5].Value.ToString();
            cancelbtn.Text = "Update";
            toupdate = true;
        }
    }
}
