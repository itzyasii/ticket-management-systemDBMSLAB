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
    public partial class Form1 : Form
    {

      
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(1400, 840);


            targetX = pictureBox1.Left + 100; // Example: slide the image 100 pixels to the right
            stepSize = 5; // Example: move the image 5 pixels in each step

            timer1.Tick += timer1_Tick; // Hook up the event handler for the Timer control
            timer1.Start(); // Start the animation

        }


        private void button1_Click(object sender, EventArgs e)
        {
            isImageChangePending = true;

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private int currentImageIndex = 0;
        private int targetX;
        private int stepSize = 5;
        private bool isAnimating = false;

        private Image[] images = new Image[]
{
    Image.FromFile("E:\\Visual Studio Workspace C#\\DBMSLab-project\\ticket-management-systemDBMSLAB\\HomeScreen\\Bus image.jpg"), // Replace with the path to your first image
    Image.FromFile("E:\\Visual Studio Workspace C#\\DBMSLab-project\\ticket-management-systemDBMSLAB\\HomeScreen\\Busimage2.jpg"), // Replace with the path to your first image
    Image.FromFile("E:\\Visual Studio Workspace C#\\DBMSLab-project\\ticket-management-systemDBMSLAB\\HomeScreen\\railwayweb.jpg"), // Replace with the path to your first image
    Image.FromFile("E:\\Visual Studio Workspace C#\\DBMSLab-project\\ticket-management-systemDBMSLAB\\HomeScreen\\rentcarweb.png"), // Replace with the path to your first image
    // Replace with the path to your second image
    // Add more images as needed
};
    }
    private void timer1_Tick(object sender, EventArgs e)
    {
        if (isAnimating)
        {
            if (pictureBox1.Left < targetX)
            {
                pictureBox1.Left += stepSize;
            }
            else
            {
                isAnimating = false;
                timer1.Stop();
                pictureBox1.Image = images[currentImageIndex];
                currentImageIndex = (currentImageIndex + 1) % images.Length;
                targetX = pictureBox1.Left + 100; // Example: slide the image 100 pixels to the right for the next animation
                timer1.Start();
            }
        }
    }


}
