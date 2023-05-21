using MySqlConnector;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace practice_library
{
    public partial class IssueBooks : Form
    {
        public object dr { get; private set; }

        public IssueBooks()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = "Server=localhost;Database=library;Uid=root;Pwd=";
            using (MySqlConnection connection = new MySqlConnection(connStr))

                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_addissuebook", connection);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@student_name_aib", MySqlDbType.VarChar).Value = textBox1.Text;
                    cmd.Parameters.Add("@enrollment_no_aib", MySqlDbType.VarChar).Value = textBox2.Text;
                    cmd.Parameters.Add("@department_aib", MySqlDbType.VarChar).Value = textBox3.Text;
                    cmd.Parameters.Add("@contact_aib", MySqlDbType.VarChar).Value = textBox7.Text;
                    cmd.Parameters.Add("@email_aib", MySqlDbType.VarChar).Value = textBox5.Text;
                    cmd.Parameters.Add("@book_name_aib", MySqlDbType.VarChar).Value = comboBox1.Text;
                    cmd.Parameters.Add("@issue_date_aib", MySqlDbType.VarChar).Value = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    cmd.Parameters.Add("@return_date_aib", MySqlDbType.VarChar).Value = dateTimePicker1.Value.ToString("yyyy-MM-dd");

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Issued");
                    //p_student_name, p_enrollment, p_department,p_contact, p_email, p_semester
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox7.Text = "";
                    textBox5.Text = "";
                    textBox4.Text = "";
                }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connStr = "Server=localhost;Database=library;Uid=root;Pwd=";
            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand("view_student_issue_book", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@student_name_var_issue_book", textBox4.Text);
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            textBox1.Text = dr[0].ToString();
                            textBox2.Text = dr[1].ToString();
                            textBox3.Text = dr[2].ToString();
                            textBox7.Text = dr[3].ToString();
                            textBox5.Text = dr[4].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {


        }

        private void IssueBooks_Load(object sender, EventArgs e)
        {
            string connStr = "Server=localhost;Database=library;Uid=root;Pwd=";
            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT book_name FROM booktable", connection);
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            comboBox1.Items.Add(dr["book_name"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}





