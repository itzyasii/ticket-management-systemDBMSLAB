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
    public partial class TrainCompartments : Form
    {
        public TrainCompartments()
        {
            InitializeComponent();
            button33.GotFocus += button33_GotFocus;
            button33.Click += button33_Click;
            button34.GotFocus += button34_GotFocus;
            button35.GotFocus += button35_GotFocus;
            button36.GotFocus += button36_GotFocus;
            button37.GotFocus += button37_GotFocus;
            button38.GotFocus += button38_GotFocus;
            button39.GotFocus += button39_GotFocus;
            button40.GotFocus += button40_GotFocus;

            panel2.Visible = false;



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainpage m1 = new mainpage();
            m1.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }
        private void button33_GotFocus(object sender, EventArgs e)
        {
            button33.BackColor = Color.RoyalBlue;
            button34.BackColor = Color.Green;
            button35.BackColor = Color.Green;
            button36.BackColor = Color.Green;
            button37.BackColor = Color.Green;
            button38.BackColor = Color.Green;
            button39.BackColor = Color.Green;
            button40.BackColor = Color.Green;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }
        private void button34_GotFocus(object sender, EventArgs e)
        {
            button34.BackColor = Color.RoyalBlue;
            button33.BackColor = Color.Green;
            button35.BackColor = Color.Green;
            button36.BackColor = Color.Green;
            button37.BackColor = Color.Green;
            button38.BackColor = Color.Green;
            button39.BackColor = Color.Green;
            button40.BackColor = Color.Green;

        }

        private void button35_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }
        private void button35_GotFocus(object sender, EventArgs e)
        {
            button35.BackColor = Color.RoyalBlue;
            button34.BackColor = Color.Green;
            button33.BackColor = Color.Green;
            button36.BackColor = Color.Green;
            button37.BackColor = Color.Green;
            button38.BackColor = Color.Green;
            button39.BackColor = Color.Green;
            button40.BackColor = Color.Green;


        }

        private void button36_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }
        private void button36_GotFocus(object sender, EventArgs e)
        {
            button36.BackColor = Color.RoyalBlue;
            button35.BackColor = Color.Green;
            button34.BackColor = Color.Green;
            button33.BackColor = Color.Green;
            button37.BackColor = Color.Green;
            button38.BackColor = Color.Green;
            button39.BackColor = Color.Green;
            button40.BackColor = Color.Green;


        }

        private void button37_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }
        private void button37_GotFocus(object sender, EventArgs e)
        {
            button33.BackColor = Color.Green;
            button34.BackColor = Color.Green;
            button35.BackColor = Color.Green;
            button36.BackColor = Color.Green;
            button37.BackColor = Color.RoyalBlue;
            button38.BackColor = Color.Green;
            button39.BackColor = Color.Green;
            button40.BackColor = Color.Green;

        }
        private void button38_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }
        private void button38_GotFocus(object sender, EventArgs e)
        {
            button33.BackColor = Color.Green;
            button34.BackColor = Color.Green;
            button35.BackColor = Color.Green;
            button36.BackColor = Color.Green;
            button37.BackColor = Color.Green;
            button38.BackColor = Color.RoyalBlue;
            button39.BackColor = Color.Green;
            button40.BackColor = Color.Green;

        }

        private void button39_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }
        private void button39_GotFocus(object sender, EventArgs e)
        {
            button33.BackColor = Color.Green;
            button34.BackColor = Color.Green;
            button35.BackColor = Color.Green;
            button36.BackColor = Color.Green;
            button37.BackColor = Color.Green;
            button38.BackColor = Color.Green;
            button39.BackColor = Color.RoyalBlue;
            button40.BackColor = Color.Green;

        }

        private void button40_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }
        private void button40_GotFocus(object sender, EventArgs e)
        {
            button33.BackColor = Color.Green;
            button34.BackColor = Color.Green;
            button35.BackColor = Color.Green;
            button36.BackColor = Color.Green;
            button37.BackColor = Color.Green;
            button38.BackColor = Color.Green;
            button39.BackColor = Color.Green;
            button40.BackColor = Color.RoyalBlue;

        }

    }
}
