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


namespace SQL_displayDataInGridview
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'database1DataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.database1DataSet.Students);
           
            
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection();
            //connection.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\uids4736\documents\visual studio 2012\Projects\SQL_displayDataInGridview\SQL_displayDataInGridview\Database1.mdf;Integrated Security=True";
            //connection.Open();
            
            //connection.Close();
            //DataTable dt = new DataTable();
            //BindingSource bs = new BindingSource();
            //bs.DataSource = dt;
            //dataGridView1.DataSource = bs;
            
            
      
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
