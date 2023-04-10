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
    public partial class ReturnBookReport : Form
    {
        public ReturnBookReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ReturnBookReport_Load(object sender, EventArgs e)
        {
            string connStr = "Server=localhost;Database=library;Uid=root;Pwd=";
            using (MySqlConnection connection = new MySqlConnection(connStr))

                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand("reports", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@report_br", (DbType)SqlDbType.VarChar).Value = "Return";
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

