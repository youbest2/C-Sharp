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
    public partial class Form1 : Form
    {
        private SqlConnection connection = new SqlConnection();
        public Form1()
        {
            InitializeComponent();
            connection.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\uids4736\documents\visual studio 2012\Projects\SQL_displayDataInGridview\SQL_displayDataInGridview\Database1.mdf;Integrated Security=True";
            
            //{

            //    ToolTip buttonToolTip = new ToolTip();
            //    buttonToolTip.ToolTipTitle = "Button Tooltip";
            //    buttonToolTip.IsBalloon = true;
            //    buttonToolTip.ShowAlways = true;
            //    buttonToolTip.SetToolTip(button1, "Hi User,Click to save.");
            //}

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            ToolTip buttonToolTip = new ToolTip();
            buttonToolTip.ToolTipTitle = "Button Tooltip";
            buttonToolTip.IsBalloon = true;
            buttonToolTip.ShowAlways = true;
            buttonToolTip.SetToolTip(button1, "Hi User,Click me."); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" )
            {
                SqlCommand CmdSql = new SqlCommand("INSERT INTO [Students] (ID, SName, Class, Section, RollNo, MainSubject, Address, Pincode, MobileNo) VALUES (@ID, @SName, @Class, @Section, @RollNo, @MainSubject, @Address, @Pincode, @MobileNo)", connection);
                try
                {
                    connection.Open();
                    CmdSql.Parameters.AddWithValue("@ID", textBox1.Text);
                    CmdSql.Parameters.AddWithValue("@SName", textBox2.Text);
                    CmdSql.Parameters.AddWithValue("@Class", textBox3.Text);
                    CmdSql.Parameters.AddWithValue("@Section", textBox4.Text);
                    CmdSql.Parameters.AddWithValue("@RollNo", textBox5.Text);
                    CmdSql.Parameters.AddWithValue("@MainSubject", textBox6.Text);
                    CmdSql.Parameters.AddWithValue("@Address", textBox7.Text);
                    CmdSql.Parameters.AddWithValue("@Pincode", textBox8.Text);
                    CmdSql.Parameters.AddWithValue("@MobileNo", textBox9.Text);

                    CmdSql.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Data Saved");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }
            else
            {
                MessageBox.Show("Please provide your Name , Class & First 5 Inputs");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
            connection.Close();
            // TODO: This line of code loads data into the 'database1DataSet1.Students' table. You can move, or remove it, as needed.
           // this.studentsTableAdapter.Fill(this.database1DataSet1.Students);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Enter Student Id To Update");
                }
                else if (textBox1.Text != "" && textBox2.Text != "" ) //&& textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
                {
                    connection.Open();
                    SqlCommand cmdupdate = new SqlCommand("UPDATE Students SET ID='" + textBox1.Text + "', SName='" + textBox2.Text + "', Class='" + textBox3.Text + "', Section='" + textBox4.Text + "', RollNo='" + textBox5.Text + "', MainSubject='" + textBox6.Text + "', Address='" + textBox7.Text + "', Pincode='" + textBox8.Text + "', MobileNo='" + textBox9.Text + "' where ID=" + textBox1.Text +"", connection);
                    cmdupdate.CommandType = CommandType.Text;
                    cmdupdate.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Data Updated");

                    //Update command Generated by the Command Builder : 
                    //==================================================
                    //UPDATE CustTest SET CustID = @p1 , CustName = @p2 WHERE ( CustID = @p3 AND CustName = @p4 )
                }
                else
                {
                
                    MessageBox.Show("Please provide your Name , Class & First 5 Inputs");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            

        }
    }
}
