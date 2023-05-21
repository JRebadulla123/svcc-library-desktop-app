using MySqlConnector;
using System;
using System.Windows.Forms;

namespace practice_library
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string email = emailTextBox.Text;

            // Validate user input
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter all required information.");
                return;
            }

            // Save user information to database
            bool signUpSuccess = SaveUserInfoToDatabase(username, password, email);

            if (signUpSuccess)
            {
                MessageBox.Show("Sign-up successful!");
                this.Close();
            }
            else
            {
                MessageBox.Show("An error occurred. Please try again.");
            }
        }

        private bool SaveUserInfoToDatabase(string username, string password, string email)
        {
            // Set up connection to MySQL database
            string connStr = "Server=localhost;Database=library;Uid=root;Pwd=";
            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                try
                {
                    // Open the database connection
                    connection.Open();

                    // Execute the SQL command to insert the new user
                    string sql = "INSERT INTO users (username, password, email) VALUES (@username, @password, @email)";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@email", email);
                    command.ExecuteNonQuery();

                    // Execute the SQL command to insert the new user into the "login" table
                    sql = "INSERT INTO login (username, password) VALUES (@username, @password)";
                    command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.ExecuteNonQuery();

                    return true;
                }
                catch (Exception ex)
                {
                    // Log or handle any errors that occur
                    Console.WriteLine(ex.ToString());
                    return false;
                }
                finally
                {
                    // Close the database connection
                    connection.Close();
                }
            }
        }
    }
}

