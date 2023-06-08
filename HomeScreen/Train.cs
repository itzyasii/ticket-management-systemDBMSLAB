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
    public partial class Train : Form
    {
        public Train()
        {
            InitializeComponent();
            comboBox1.Items.Add("Karachi");
            comboBox1.Items.Add("Lahore");
            comboBox1.Items.Add("Islamabad");
            comboBox1.Items.Add("Sukkur");
            comboBox1.Items.Add("Jacobabad");
            comboBox1.Items.Add("Hyderabad");


            comboBox2.Items.Add("Karachi");
            comboBox2.Items.Add("Lahore");
            comboBox2.Items.Add("Islamabad");
            comboBox2.Items.Add("Sukkur");
            comboBox2.Items.Add("Jacobabad");
            comboBox2.Items.Add("Hyderabad");

        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "From" || comboBox2.Text == "To")
            {
                MessageBox.Show("Please Select Stations", "Invalid Origin and Destination!" , MessageBoxButtons.OK ,MessageBoxIcon.Information);
                
            }
            else
            {
                TrainCompartments tc = new TrainCompartments();
                tc.Show();
                this.Hide();
            }

          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
