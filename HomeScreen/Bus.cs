using System;
using System.Windows.Forms;
namespace HomeScreen
{
    public partial class Bus : Form
    {
        
        public Bus()
        { 
            InitializeComponent();
            //panel1.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        { }

        private void Bus_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainpage m1 = new mainpage();
            m1.Show();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Select Departure" || comboBox2.Text == "Select Arrival")
            {
                MessageBox.Show("No City is Selected");
            }
            else
            {
                this.Refresh();
                timer1.Interval = 5;
                timer1.Start();
                //panel1.Visible = true;
                timer1.Stop();
                busseat b1 = new busseat();
                b1.Show();
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //panel1.Width = panel1.Width + 15;
        }
    }
}
