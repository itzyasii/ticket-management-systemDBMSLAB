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
    public partial class Flights : Form
    {
        public Flights()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true) {
                this.dateTimePicker2.Visible = true;
                this.checkBox2.Checked = false;
                this.checkBox3.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked == true)
            {
                this.dateTimePicker2.Visible = false;
                this.checkBox1.Checked = false;
                this.checkBox3.Checked = false;

            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox3.Checked == true)
            {
                this.dateTimePicker2.Visible = false;
                this.checkBox2.Checked = false;
                this.checkBox1.Checked = false;
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "CITY OR AIRPORT";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void textBox1_Enter_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "CITY OR AIRPORT")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "CITY OR AIRPORT")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "CITY OR AIRPORT";
                textBox2.ForeColor = Color.Silver;
            }
        }

        private void Flights_Load(object sender, EventArgs e)
        {

        }
    }
}
