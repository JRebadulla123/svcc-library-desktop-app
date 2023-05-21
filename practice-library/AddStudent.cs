using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_library
{
    public partial class AddStudent : Form
    {


        public AddStudent()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = "Server=localhost;Database=library;Uid=root;Pwd=";
            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand("add_student", connection);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@p_student_name", MySqlDbType.VarChar).Value = textBox7.Text;
                    cmd.Parameters.Add("@p_enrollment", MySqlDbType.VarChar).Value = textBox2.Text;
                    cmd.Parameters.Add("@p_department", MySqlDbType.VarChar).Value = textBox3.Text;
                    cmd.Parameters.Add("@p_contact", MySqlDbType.VarChar).Value = textBox4.Text;
                    cmd.Parameters.Add("@p_email", MySqlDbType.VarChar).Value = textBox5.Text;
                    cmd.Parameters.Add("@p_semester", MySqlDbType.VarChar).Value = textBox6.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Details Added");
                    //p_student_name, p_enrollment, p_department,p_contact, p_email, p_semester
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                    textBox7.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                }






            }
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }
    }
}

