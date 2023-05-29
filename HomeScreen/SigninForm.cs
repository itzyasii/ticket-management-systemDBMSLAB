using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            password.UseSystemPasswordChar = true;
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

        }
    }
}
