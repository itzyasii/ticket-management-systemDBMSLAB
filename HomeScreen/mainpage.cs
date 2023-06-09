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
    public partial class mainpage : Form
    {
        public mainpage()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button8_Click(object sender, EventArgs e)
        {
            SigninForm s1 = new SigninForm();
            MessageBox.Show("Thanks for visiting");

            s1.Show();
            this.Hide();
        }
        public void Settextfromlabel(string mytext)
        {
            this.label1.Text = mytext;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Bus b1 = new Bus();
            b1.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Flights f1 = new Flights();
            f1.Show();
            this.Hide();

        
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Train t1 = new Train();
            t1.Show();
            this.Hide();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            movies m1 = new movies();
            m1.Show();
            this.Hide();
        }

        private void mainpage_Load(object sender, EventArgs e)
        {

        }
    }
}
