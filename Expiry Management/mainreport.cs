using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Expiry_Management
{
    public partial class mainreport : Form
    {
        public mainreport()
        {
            InitializeComponent();
        }
        SQLiteConnection con;
        SQLiteDataReader reader;
        SQLiteCommand cmd;
        String command;
        private void mainreport_Load(object sender, EventArgs e)
        {
            
        }
        public void setup()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Partyname");
            comboBox1.Items.Add("Date");
            comboBox1.Items.Add("Voucher Id");
            comboBox1.Items.Add("Amount");
            con = new SQLiteConnection("Data Source = data.db");
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
            if(comboBox1.SelectedIndex == 0)
            {
                partynamesearchbox.Visible = true;
            }
            else
            {
                partynamesearchbox.Visible = false;
            }
            if(comboBox1.SelectedIndex == 1)
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
            if(comboBox1.SelectedIndex == 2)
            {
                vouchersearch.Visible = true ;
            }
            else
            {
                vouchersearch.Visible = false;
            }
            if(comboBox1.SelectedIndex == 3)
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
            dataGridView1.Rows.Clear();
            command = "select id,partyname,date,sum(qty*mrp) as tsum,sum(samt) as tsamt,sum(qty*mrp) - sum(samt) from data group by id having tsum != tsamt;";
            cmd = new SQLiteCommand(command, con);
            reader = cmd.ExecuteReader();
            int sl = 1;
            while (reader.Read())
            {
                dataGridView1.Rows.Add(Convert.ToString(sl), Convert.ToString(reader.GetInt32(0)), reader.GetString(1), reader.GetString(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5));
            }
        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            command = "select id,partyname,date,sum(qty*mrp) as tsum,sum(samt) as tsamt,sum(qty*mrp) - sum(samt) from data group by id having tsum != tsamt;";
            cmd = new SQLiteCommand(command, con);
            reader = cmd.ExecuteReader();
            int sl = 1;
            while (reader.Read())
            {
                if (reader.GetString(1).Contains(partynamesearchbox.Text.Trim()))
                {
                    dataGridView1.Rows.Add(Convert.ToString(sl), Convert.ToString(reader.GetInt32(0)), reader.GetString(1), reader.GetString(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5));
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
                maxamt.Text = Convert.ToString(Convert.ToInt64(minamt.Text) + 100) ;
            }
            dataGridView1.Rows.Clear();
            command = "select id,partyname,date,sum(qty*mrp) as tsum,sum(samt) as tsamt,sum(qty*mrp) - sum(samt) from data group by id having tsum != tsamt;";
            cmd = new SQLiteCommand(command, con);
            reader = cmd.ExecuteReader();
            int sl = 1;
            while (reader.Read())
            {
                if (reader.GetInt32(5) >= Convert.ToInt64(minamt.Text.Trim()) & reader.GetInt32(5) <= Convert.ToInt64(maxamt.Text.Trim()))
                {
                    dataGridView1.Rows.Add(Convert.ToString(sl), Convert.ToString(reader.GetInt32(0)), reader.GetString(1), reader.GetString(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5));
                }
            }
        }

        private void vouchersearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            command = "select id,partyname,date,sum(qty*mrp) as tsum,sum(samt) as tsamt,sum(qty*mrp) - sum(samt) from data group by id having tsum != tsamt;";
            cmd = new SQLiteCommand(command, con);
            reader = cmd.ExecuteReader();
            int sl = 1;
            while (reader.Read())
            {
                if (Convert.ToString(reader.GetInt32(0)).Contains(vouchersearch.Text.Trim()))
                {
                    dataGridView1.Rows.Add(Convert.ToString(sl), Convert.ToString(reader.GetInt32(0)), reader.GetString(1), reader.GetString(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5));
                }
            }
        }

        private void fromdate_CloseUp(object sender, EventArgs e)
        {

        }

        private void maxamt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
