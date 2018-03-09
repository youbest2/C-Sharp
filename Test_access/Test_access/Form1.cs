using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Test_access
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginInfoDataSet.LoginInfo' table. You can move, or remove it, as needed.
            this.loginInfoTableAdapter.Fill(this.loginInfoDataSet.LoginInfo);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connectionString;
            OleDbConnection cnn;

            connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\uids4736\Documents\Visual Studio 2012\Projects\Test_access\Test_access\bin\Debug\LoginInfo.accdb";
            // Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\bin\Debug\LoginInfo.accdb
            // Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\uids4736\Documents\Visual Studio 2012\Projects\Test_access\Test_access\bin\Debug\LoginInfo.accdb
            cnn = new OleDbConnection(connectionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
             
        }
    }
}
