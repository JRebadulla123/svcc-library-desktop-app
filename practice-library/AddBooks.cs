using MySqlConnector;
using System.Data;

namespace practice_library
{
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBooks_Load(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connStr = "Server=localhost;Database=library;Uid=root;Pwd=";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("add_books", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@book_ISBN", MySqlDbType.VarChar).Value = textBox4.Text;
                cmd.Parameters.Add("@book_name", MySqlDbType.VarChar).Value = textBox1.Text;
                cmd.Parameters.Add("@autor_name", MySqlDbType.VarChar).Value = textBox2.Text;
                cmd.Parameters.Add("@publication", MySqlDbType.VarChar).Value = textBox3.Text;
                cmd.Parameters.Add("@purchase_date", MySqlDbType.VarChar).Value = (dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.Add("@book_price", MySqlDbType.VarChar).Value = textBox5.Text;
                cmd.Parameters.Add("@Books_Available", MySqlDbType.VarChar).Value = textBox6.Text;



                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();

                textBox4.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

