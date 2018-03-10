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

namespace LoginForm
{
    public partial class Form1 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form1()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\source\repos\LoginForm\LoginForm\LoginInfo.accdb";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                ConnectionStatus.Text = "Online";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show ("Error" + ex);
            }
            



        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select * from LoginInfo where UID='"+ txt_Username.Text+ "' and PASS = '"+ txt_Password.Text + "'"; // Decleration of Query LoginInfo_tableName
            OleDbDataReader reader =  command.ExecuteReader();
            int count = 0;
            while(reader.Read())
            { 
                count = count + 1;
                //count++
            }
            if(count == 1)
            {
                MessageBox.Show("login successful");
            }
            if (count > 1)
            {
                MessageBox.Show("Duplicate ID and PASSWORD");
            }
            else
            {
                MessageBox.Show("Wrong User ID or Password");
            }
            connection.Close();

        }
    }
}
