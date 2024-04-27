using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tourism_Management_System.UI
{
    public partial class Destinations : Form
    {

        string[] imagePaths = { "D:\\WEB DEVELOPMENT\\HTML\\STATIC\\Images\\Muree.jpg", "D:\\WEB DEVELOPMENT\\HTML\\STATIC\\Images\\Beauty-of-Kashmir.jpg", "D:\\WEB DEVELOPMENT\\HTML\\STATIC\\Images\\Neelum-Valley.jpg" };
        int currentIndex = 0;
        public Destinations()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            currentIndex = (currentIndex + 1) % imagePaths.Length;
            DisplayCurrentImage();

        }
            private void DisplayCurrentImage()
            {
                // Load and display the current image
                try
                {
                    string imagePath = imagePaths[currentIndex];
                    guna2PictureBox1.Image = Image.FromFile(imagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }

        }
    }

