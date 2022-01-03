using System;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Application.StartupPath);
            if (!File.Exists("hello.db"))
            {
                MessageBox.Show("vint");
                SQLiteConnection.CreateFile("hello.db");
                var inicon = new SQLiteConnection("Data Source = hello.db");
                inicon.Open();
                var inicommand = @"CREATE TABLE details(
                                   name TEXT,
                                     class INTEGER
                                    );";
                var inicmd = new SQLiteCommand(inicommand, inicon);
                inicmd.ExecuteReader();
                inicon.Close();
            }
            var con = new SQLiteConnection("Data Source = hello.db");
            con.Open();
            string command = "select * from details";
            var cmd = new SQLiteCommand(command,con);
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr.GetValue(0)+"\t"+dr.GetValue(1));
            }
        }
    }
}
