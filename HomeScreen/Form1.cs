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
        private int currentImageIndex = 0;
        private int targetX;
        private int stepSize = 5;
        private bool isAnimating = false;

        private Image[] images = new Image[]
        {
            Image.FromFile(@"E:\Visual Studio Workspace C#\DBMSLab-project\ticket-management-systemDBMSLAB\HomeScreen\images\Busimage2.jpg"),
            Image.FromFile(@"E:\Visual Studio Workspace C#\DBMSLab-project\ticket-management-systemDBMSLAB\HomeScreen\images\Busimage.jpg"),
            Image.FromFile(@"E:\Visual Studio Workspace C#\DBMSLab-project\ticket-management-systemDBMSLAB\HomeScreen\images\railwayweb.jpg"),
            Image.FromFile(@"E:\Visual Studio Workspace C#\DBMSLab-project\ticket-management-systemDBMSLAB\HomeScreen\images\rentcarweb.png")
        };

        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(1400, 840);
            targetX = pictureBox1.Left + 100; // Example: slide the image 100 pixels to the right
            stepSize = 5; // Example: move the image 5 pixels in each step
            timer1.Tick += timer1_Tick; // Hook up the event handler for the Timer control
            timer1.Start(); // Start the animation
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isAnimating)
            {
                if (pictureBox1.Left < targetX)
                {
                    pictureBox1.Left += stepSize; // Slide the image in slowly
                }
                else
                {
                    isAnimating = false;
                    timer1.Stop();
                    pictureBox1.Image = images[currentImageIndex];
                    currentImageIndex = (currentImageIndex + 1) % images.Length;
                    targetX = pictureBox1.Left - pictureBox1.Width; // Slide the image out quickly
                    stepSize = (int)(pictureBox1.Width / (timer1.Interval / 1000.0) * 2); // Calculate the step size for 2-second animation
                    timer1.Interval = 3000; // Set the interval to 3000 milliseconds (3 seconds)
                    timer1.Start();
                }
            }
            else
            {
                if (pictureBox1.Left > targetX)
                {
                    pictureBox1.Left -= stepSize; // Slide the image out quickly
                }
                else
                {
                    isAnimating = true;
                    timer1.Stop();
                    pictureBox1.Image = null; // Clear the image
                    targetX = pictureBox1.Left + pictureBox1.Width + 100; // Example: slide the image 100 pixels to the right for the next animation
                    stepSize = (int)(pictureBox1.Width / (timer1.Interval / 1000.0) * 2); // Calculate the step size for 2-second animation
                    timer1.Interval = 3000; // Set the interval to 3000 milliseconds (3 seconds)
                    timer1.Start();
                }
            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            // Handle HomeButton click event
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = images[currentImageIndex];
            targetX = pictureBox1.Left + 100; // Example: slide the image 100 pixels to the right for the first animation
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Handle pictureBox1 click event
        }
    }
}
