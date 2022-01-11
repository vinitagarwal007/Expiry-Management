using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SQLite;
using System.Threading;
namespace Expiry_Management
{
    public partial class import : Form
    {
        public import()
        {
            InitializeComponent();
        }
        public Boolean ispartyname = false;
        public Boolean isitemname = false;
        SQLiteConnection con;
        SQLiteDataReader reader;
        SQLiteCommand cmd;
        String command;
        private void import_Load(object sender, EventArgs e)
        {
            if (ispartyname)
            {
                pictureBox1.Image = Expiry_Management.Properties.Resources.importlayout1;
            }
            if (isitemname)
            {
                pictureBox1.Image = Expiry_Management.Properties.Resources.importlayout;
            }
            con = new SQLiteConnection("Data Source = data.db");
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog1.Filter = "Excel File(.xlsx)|*.xlsx;";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
        }
        public delegate void updatetitle(string s);
        public updatetitle delegateupdatetitle;
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            delegateupdatetitle = (string s) =>
            {
                this.Text = s;
            };
            Thread th = new Thread(() =>
             {
                 Excel.Application exapp = new Excel.Application();
                 Excel.Workbook workbook = exapp.Workbooks.Open(openFileDialog1.FileName);
                 Excel.Sheets sheets = workbook.Worksheets;
                 Excel.Worksheet worksheet = sheets[1];
                 int rowindex = 2;
                 string value = "";
                 if (ispartyname)
                 {
                     command = "delete from partylist";
                     cmd = new SQLiteCommand(command, con);
                     cmd.ExecuteNonQuery();
                 }
                 if (isitemname)
                 {
                     command = "delete from itemlist";
                     cmd = new SQLiteCommand(command, con);
                     cmd.ExecuteNonQuery();
                 }
                 cmd = new SQLiteCommand(command, con);
                 cmd.ExecuteNonQuery();
                 while (worksheet.Range["A" + rowindex].Value != null)
                 {
                     value = worksheet.Range["A" + rowindex].Value;
                     if (isitemname)
                     {
                         command = "insert into itemlist select '" + value.Trim() + "' where not exists(select * from itemlist where name = '" + value.Trim() + "');";
                         cmd = new SQLiteCommand(command, con);
                         cmd.ExecuteNonQuery();
                     }
                     if (ispartyname)
                     {
                         command = "insert into partylist select '" + value.Trim() + "' where not exists(select * from partylist where name = '" + value.Trim() + "');";
                         cmd = new SQLiteCommand(command, con);
                         cmd.ExecuteNonQuery();
                     }
                     rowindex++;
                 }
                 exapp.Quit();
                 this.Invoke(this.delegateupdatetitle, new object[] { "Completed" });
                 Thread.Sleep(1000);
                 try
                 {
                     this.Invoke(this.delegateupdatetitle, new object[] { "Import" });
                 }
                 catch (Exception){}
                 
             });
            th.Start();

        }
    }
}
