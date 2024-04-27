using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS_LIbrary.Utilities;
using Tourism_Management_System.Utilities;

namespace Tourism_Management_System.UI
{
    public partial class RemoveHotel : Form
    {
        public RemoveHotel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            if(string.IsNullOrEmpty(Name))
            {
                MessageBox.Show("Invalid Name of Hotel.Please ReEnter");
                return;
            }
            if (! ObjectHandler.GetHotelDl().HotelExists(Name))
            {
                MessageBox.Show("Hotel with this name do no exist.Please ReEnter the name of hotel");
            }
            else
            {
                MessageBox.Show("Hotel exists.Please carry on");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string hotelName=textBox1.Text;
            if (string.IsNullOrEmpty(Name))
            {
                MessageBox.Show("Invalid Name of Hotel.Please ReEnter");
                return;
            }
            if (ObjectHandler.GetHotelDl().DeleteHotel(hotelName))
            {
                MessageBox.Show("Hotel Deleted successfully");
            }
            else
            {
                MessageBox.Show("Hotel could not be deleted");
            }
        }
    }
}
