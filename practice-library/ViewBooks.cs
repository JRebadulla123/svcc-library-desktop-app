using MySqlConnector;
using System.Data;

namespace practice_library
{
    public partial class ViewBooks : Form
    {
        string connStr = "Server=localhost;Database=library;Uid=root;Pwd=";

        public ViewBooks()
        {
            InitializeComponent();
        }



        private void ViewBooks_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("viewbooks", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@book_name_var", SqlDbType.VarChar).Value = "";
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;

                connection.Close();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("viewbooks", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@book_name_var", SqlDbType.VarChar).Value = textBox1.Text;
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;

                connection.Close();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


