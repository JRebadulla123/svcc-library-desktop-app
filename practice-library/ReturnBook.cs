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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace practice_library
{
    public partial class ReturnBook : Form
    {
        private string connStr;

        public ReturnBook()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connStr = "Server=localhost;Database=library;Uid=root;Pwd=";
            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand("view_issue_book", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@enrollment_num_ib", textBox4.Text);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = "Server=localhost;Database=library;Uid=root;Pwd=";
            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand("update_issueBook", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_uib", textBox1.Text);
                    cmd.Parameters.AddWithValue("@return_date_uib", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Returned");

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}