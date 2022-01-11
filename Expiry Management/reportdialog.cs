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
    public partial class reportdialog : Form
    {
        public reportdialog()
        {
            InitializeComponent();
        }
        SQLiteConnection con;
        SQLiteDataReader reader;
        SQLiteCommand cmd;
        String command;
        public string sharedvoucherid = "";
        private void reportdialog_Load(object sender, EventArgs e)
        {
            con = new SQLiteConnection("Data Source = data.db");
            con.Open();
            dgv.Rows.Clear();
            command = "select * from data where id ='" + sharedvoucherid +"';";
            MessageBox.Show(command);
            cmd = new SQLiteCommand(command, con);
            reader = cmd.ExecuteReader();
            int sl = 1;
            while (reader.Read())
            {
                dgv.Rows.Add(sl, reader.GetString(3), reader.GetDecimal(4), reader.GetInt64(5), reader.GetString(6), reader.GetDecimal(7));
                sl++;
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Program.form.voucheredit(sharedvoucherid);
            this.DialogResult = DialogResult.OK;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
