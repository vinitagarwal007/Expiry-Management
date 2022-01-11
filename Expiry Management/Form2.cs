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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Form1 f1 = new Form1();
        mainreport f2;
        private void createVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f1 = new Form1();
            f1.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(f1);
            f1.Show();
            f1.setup();
            this.Text = "Voucher Editing";
        }

        private void Form2_Load(object sender, EventArgs e)

        {
            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Expiry Management\\data.db"))
            {
                if(!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Expiry Management"))
                {
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Expiry Management");
                }
                SQLiteConnection.CreateFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Expiry Management\\data.db");
                var inicon = new SQLiteConnection("Data Source = " + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Expiry Management\\data.db");
                inicon.Open();
                var inicommand = @"CREATE TABLE data(
                                id        INT(100)     NOT NULL,
                                date      TEXT(100),
                                partyname TEXT(100),
                                itemname  TEXT(100),
                                mrp       DECIMAL(100),
                                qty       INTEGER(100),
                                sdate     TEXT(100),
                                samt      DECIMAL(100),
                                slno      TEXT(100) NOT NULL PRIMARY KEY
                                );
                                CREATE TABLE itemlist(
                                name TEXT(100)
                                );
                                CREATE TABLE partylist(
                                name TEXT(100) 
                                );
                                CREATE TABLE config(
                                lastvoucherid TEXT(100),
                                lastdataslno TEXT(100)
                                );";
                var inicmd = new SQLiteCommand(inicommand, inicon);
                inicmd.ExecuteReader();

                inicommand = "INSERT INTO config('lastvoucherid','lastdataslno') values(0,0);";
                inicmd = new SQLiteCommand(inicommand, inicon);
                inicmd.ExecuteNonQuery();

                inicon.Close();
            }
            homeToolStripMenuItem.PerformClick();
            this.Text = "Expiry Manager";
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            panel1.Controls.Clear();
            f3.TopLevel = false;
            panel1.Controls.Add(f3);
            f3.Show();
            f3.setup();
            this.Text = "Reports";
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2 = new mainreport();
            panel1.Controls.Clear();
            f2.TopLevel = false;
            panel1.Controls.Add(f2);
            f2.Show();
            f2.setup();
            this.Text = "Expiry Manager";
        }
        public void voucheredit(String id)
        {
            f1 = new Form1();
            f1.TopLevel = false;
            f1.sharedvoucherid = id;
            f1.toupdateparty = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(f1);
            f1.Show();
            f1.setup();
            this.Text = "Voucher Editing";
        }

        private void importPartyListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            import import = new import();
            import.ispartyname = true;
            import.ShowDialog();
        }

        private void importItemListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            import import = new import();
            import.isitemname = true;
            import.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
