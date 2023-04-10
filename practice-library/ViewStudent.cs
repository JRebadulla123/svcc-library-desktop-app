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
    public partial class ViewStudent : Form
    {
        string connStr = "Server=localhost;Database=library;Uid=root;Pwd=";
        public ViewStudent()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("view_student", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@student_name_var", SqlDbType.VarChar).Value = textBox1.Text;
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;

                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("view_student", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@student_name_var", SqlDbType.VarChar).Value = "";
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;

                connection.Close();
            }
        }
    }

}

