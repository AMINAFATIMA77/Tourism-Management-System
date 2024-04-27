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
    public partial class ResourceManager : Form
    {
        public ResourceManager()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form = new UpdateHotel();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new AddHotel();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new RemoveHotel();
            form.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form = new AddFood();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form form = new UpdateFood();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form form = new RemoveFood();
            form.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form form = new UpdateMedicine();
            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form form = new AddMedicine();
            form.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form form = new DeleteMedicine();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new ViewPackage();
            form.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form form = new ViewHotelsByName();
            form.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form form = new ViewHotels();
            form.Show();
        }
    }
}
