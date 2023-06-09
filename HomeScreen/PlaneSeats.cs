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
    public partial class PlaneSeats : Form
    {
        public PlaneSeats()
        {
            InitializeComponent();
            monthCalendar1.MaxSelectionCount = 1;
        }

       
        private void PlaneSeats_Load(object sender, EventArgs e)
        {
            //panel1.BackColor = Color.FromArgb(100, 0, 0,0);
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == " Date of Birth") {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
                monthCalendar1.Visible = true;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (!monthCalendar1.Focused || textBox3.Text == "")
                textBox3.Text = " Date of Birth";
                textBox3.ForeColor = SystemColors.WindowFrame;
                monthCalendar1.Visible = false;
            
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            var monthCalendar = sender as MonthCalendar;
            textBox3.Text = monthCalendar.SelectionStart.ToString();
           

        }

        private void monthCalendar1_Leave(object sender, EventArgs e)
        {
            var monthCalendar = sender as MonthCalendar;
            monthCalendar.Visible = false;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == " Enter Your Name")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;

            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
           if (textBox1.Text == "")
            {
                textBox1.Text = " Enter Your Name";
                textBox1.ForeColor = SystemColors.WindowFrame;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == " CNIC")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = " CNIC";
                textBox4.ForeColor = SystemColors.WindowFrame;
            }

        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if(textBox5.Text == " Mobile no")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if(textBox5.Text == "")
            {
                textBox5.Text = " Mobile no";
                textBox5.ForeColor = SystemColors.WindowFrame;
            }
        }

        private void textBox4_Enter_1(object sender, EventArgs e)
        {
            if (textBox4.Text == " CNIC")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox7_Enter_1(object sender, EventArgs e)
        {
            if (textBox7.Text == " Enter email address")
            {
                textBox7.Text = "";
                textBox7.ForeColor = Color.Black;
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                textBox7.Text = " Enter email address";
                textBox7.ForeColor = SystemColors.WindowFrame;
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
