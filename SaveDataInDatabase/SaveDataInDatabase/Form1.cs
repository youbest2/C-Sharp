using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SaveDataInDatabase
{
    public partial class Form1 : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\uids4736\documents\visual studio 2012\Projects\SaveDataInDatabase\SaveDataInDatabase\Database1.mdf;Integrated Security=True"); 
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.database1DataSet1.Table);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                SqlCommand CmdSql = new SqlCommand("INSERT INTO [Table] (Name, HomeTown, Degree, Year) VALUES (@Name, @HomeTown, @Degree, @Year)", con);
                try
                {
                    con.Open();
                    CmdSql.Parameters.AddWithValue("@Name", textBox1.Text);
                    CmdSql.Parameters.AddWithValue("@HomeTown", textBox2.Text);
                    CmdSql.Parameters.AddWithValue("@Degree", textBox3.Text);
                    CmdSql.Parameters.AddWithValue("@Year", textBox4.Text);
                    CmdSql.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data Saved");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }
            else
            {
                MessageBox.Show("Please provide your Name $ HomeTown");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
