using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeScreen
{
    public partial class SigninForm : Form
    {
        public SigninForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void SigninForm_Load(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            pass.UseSystemPasswordChar = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            SignupForm signupForm = new SignupForm();
            signupForm.Show();
            this.Hide();
        }

        private void signin_Click(object sender, EventArgs e)
        {
    string connectionString = "Data Source=(localdb)\\bookmedatabase;Initial Catalog=BOOKMEDATABASE;Integrated Security=True"; // Replace with your actual connection string

    string username = user.Text;
    string password = pass.Text;

    using (SqlConnection connection = new SqlConnection(connectionString))
    {
        connection.Open();
        using (SqlCommand command = connection.CreateCommand())
        {
            command.CommandText = "SELECT COUNT(*) FROM UserInformation WHERE username = @username AND user_pass = @password";
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            int result = (int)command.ExecuteScalar();

            if (result > 0)
            {
                MessageBox.Show("Sign-in successful!");
                        Form1 form1 = new Form1();
                        form1.Show();
                        this.Hide();


            }
            else
            {
                MessageBox.Show("Invalid username or password!");
                // Handle invalid credentials
            }
        }
    }
}
    }
}
